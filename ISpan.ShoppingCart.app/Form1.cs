using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.ShoppingCart.app
{
    public partial class Form1 : Form
    {
        // 資料表上次編輯記錄保存
        private string _dataTableEditHistory = null;
        // Viewer資料來源
        private DataTable _dataTable = null;
        // 目前購物車內清單保存
        private Dictionary<string, Order> _orderList = null;
        // 目前購物車內折扣
        private int _discountPrice = 0;
        // 歷史訂單索引
        private int _orderListId = 0;
        // 歷史訂單保存
        private Dictionary<int, HistoryOrders> HistoryOrderList = new Dictionary<int, HistoryOrders>();
        // 總金額
        private int TotalPrice
        {
            get
            {
                int sum = 0;
                foreach (DataGridViewRow row in ShoppingCartViewer.Rows)
                {

                    if(!int.TryParse(row.Cells[1].Value.ToString(),out int quantity)) quantity = 1;

                    int rowCount = (int)row.Cells[2].Value * quantity;
                    sum += rowCount;
                }
                return Math.Max(0, sum);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _dataTable = ResetDataTable();
            ShoppingCartViewer.DataSource = _dataTable;
            ShowTotalPrice.Text = "0 元";
        }

        /// <summary>
        /// 清空購物車
        /// </summary>
        private void ClearShoppingCart()
        {
            _orderList = null;
            _discountPrice = 0;
            _dataTableEditHistory = null;
            Discount.ResetText();
        }
        /// <summary>
        /// 加入歷史清單
        /// </summary>
        private void CheckInHistoryOrders()
        {
            PaidList.DataSource = HistoryOrderList.Keys.ToList();
        }
        /// <summary>
        /// 顯示資料表
        /// </summary>
        /// <param name="orders">購物清單</param>
        /// <param name="discount">折扣</param>
        /// <param name="isReadOnly">是否唯讀</param>
        /// <param name="dataTable">輸出資料表</param>
        private void DisplayTable(IEnumerable<Order> orders, int discount, bool isReadOnly, out DataTable dataTable)
        {
            dataTable = DisplayShoppingCart(orders, discount);
            ShoppingCartViewer.DataSource = dataTable;
            ShoppingCartViewer.ReadOnly = isReadOnly;
            ShoppingCartViewer.Columns[2].ReadOnly = true;
        }
        /// <summary>
        /// 顯示購物車內容
        /// </summary>
        /// <param name="orders">購物清單</param>
        /// <param name="discount">折扣</param>
        /// <returns></returns>
        private DataTable DisplayShoppingCart(IEnumerable<Order> orders, int discount)
        {
            var dataTable = ResetDataTable();
            if (orders == null) return dataTable;
            foreach (var order in orders)
            {
                dataTable.Rows.Add(order.Product.Name, order.Quantity, order.Product.Price);
            }
            if (discount != 0)
            {
                dataTable.Rows.Add("優惠", DBNull.Value, discount);
            }
            return dataTable;
        }

        /// <summary>
        /// 重置資料表
        /// </summary>
        /// <returns></returns>
        private DataTable ResetDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("產品名稱", typeof(string));
            dataTable.Columns.Add("數量", typeof(string));
            dataTable.Columns.Add("價格", typeof(int));
            return dataTable;
        }

        /// <summary>
        /// 顯示總金額資訊
        /// </summary>
        private void ShowTotalPriceInfo()
        {
            ShowTotalPrice.Text = $"{TotalPrice} 元";
        }
        /// <summary>
        /// 嘗試建立新的購物車
        /// </summary>
        /// <param name="orderList">回傳新購物車</param>
        /// <returns></returns>
        private bool TryGetNewShoppingCart(out Dictionary<string, Order> orderList)
        {
            orderList = null;
            var messageResult = MessageBox.Show("是否建立新購物車?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (messageResult == DialogResult.Yes)
            {
                orderList = new Dictionary<string, Order>();
                return true;
            }
            return false;
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            // 如果沒有購物車，嘗試獲得新購物車，如使用者拒絕，則直接結束事件
            if (_orderList == null && !TryGetNewShoppingCart(out _orderList))
                return;

            if (string.IsNullOrWhiteSpace(productName.Text))
            {
                MessageBox.Show("名稱不能為空");
                return;
            }

            if (quantity.Value <= 0)
            {
                MessageBox.Show("數量需至少為1");
                return;
            }

            if (!int.TryParse(unitPrice.Text, out int price) || price < 0)
            {
                MessageBox.Show("請輸入正確之金額");
                return;
            }

            // 判斷是否購物車內是否已有相同的產品名稱
            if (_orderList.TryGetValue(productName.Text, out var existingOrder))
            {
                var messageResult = MessageBox.Show("購物車內已有相同產品，是否增加數量?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (messageResult == DialogResult.Yes)
                    existingOrder.Quantity += (int)quantity.Value;


                if (existingOrder.Product.Price != price)
                {
                    messageResult = MessageBox.Show("輸入價格不同，是否更新該產品價格?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (messageResult == DialogResult.Yes)
                        existingOrder.Product.Price = price;
                }
            }
            else
            {
                var product = new Product { Name = productName.Text, Price = price };

                _orderList.Add(product.Name, new Order(product, (int)quantity.Value));
            }
            DisplayTable(_orderList.Values, _discountPrice, false, out _dataTable);
            ShowTotalPriceInfo();

        }

        private void Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 如果優惠選擇無，則返回0
            _discountPrice = Discount.SelectedIndex == 0 ? 0 :
                // 嘗試獲得優惠金額，如果無法獲得優惠金額，返回0
                (int.TryParse(Discount.SelectedItem.ToString().Split(' ')[1], out int discount) ? discount : 0);


            // 如果沒有購物車，嘗試獲得新購物車，如使用者拒絕，則直接結束事件
            if (_orderList == null && !TryGetNewShoppingCart(out _orderList))
                return;


            DisplayTable(_orderList.Values, _discountPrice, false, out _dataTable);
            ShowTotalPriceInfo();
        }

        private void ShoppingCartViewer_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _dataTableEditHistory = ShoppingCartViewer[e.ColumnIndex, e.RowIndex].Value?.ToString();
        }

        private void ShoppingCartViewer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string pName = ShoppingCartViewer.Rows[e.RowIndex].Cells[0].Value.ToString();
            var cell = ShoppingCartViewer.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var columnName = ShoppingCartViewer.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "產品名稱":
                    if (_dataTableEditHistory != "優惠" && !_orderList.ContainsKey(pName.Trim()))
                    {
                        _orderList.Remove(_dataTableEditHistory);
                        _orderList.Add(pName.Trim(), new Order(new Product
                        {
                            Name = pName.Trim(),
                            Price = int.Parse(ShoppingCartViewer.Rows[e.RowIndex].Cells[2].Value.ToString())
                        },
                        int.Parse(ShoppingCartViewer.Rows[e.RowIndex].Cells[1].Value.ToString())));
                    }
                    else if (_orderList.ContainsKey(pName.Trim()))
                    {
                        MessageBox.Show("錯誤，商品已存在");
                    }
                    else if (pName.Trim() == "優惠")
                    {
                        MessageBox.Show("優惠不能為產品名稱");
                    }
                    break;
                case "數量":
                    if (string.IsNullOrEmpty(_dataTableEditHistory)) break;

                    var result = int.TryParse(cell.Value.ToString(), out int quantity);

                    if (!result || quantity < 0)
                    {
                        MessageBox.Show("請輸入正確數量");
                        quantity = 1;
                    }
                    else if (quantity == 0)
                    {
                        var messageResult = MessageBox.Show("是否刪除此品項?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (messageResult == DialogResult.Yes)
                        {
                            _orderList.Remove(pName);
                        }
                        else
                        {
                            quantity = 1;
                        }
                    }
                    if (_orderList.ContainsKey(pName))
                    {
                        _orderList[pName].Quantity = quantity;
                    }
                    break;
                default:
                    break;
            }

            DisplayTable(_orderList.Values, _discountPrice, false, out _dataTable);
            ShowTotalPriceInfo();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            if (_orderList == null) return;
            _orderListId += 1;
            HistoryOrderList.Add(_orderListId, new HistoryOrders(_discountPrice));
            foreach (var order in _orderList.Values)
            {
                HistoryOrderList[_orderListId].CheckOut(order);
            }
            CheckInHistoryOrders();
            ClearShoppingCart();
            DisplayTable(null, _discountPrice, false, out _dataTable);
            ShowTotalPriceInfo();
        }

        private void PaidList_DoubleClick(object sender, EventArgs e)
        {
            int index = (int)PaidList.Items[PaidList.SelectedIndex];
            DisplayTable(HistoryOrderList[index]._orders, HistoryOrderList[index]._discount, true, out _dataTable);
            ShowTotalPriceInfo();
        }
    }
}
