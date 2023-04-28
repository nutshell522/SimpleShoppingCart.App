namespace ISpan.ShoppingCart.app
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productName = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.unitPrice = new System.Windows.Forms.TextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.productNameLable = new System.Windows.Forms.Label();
            this.BtnCheckIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Discount = new System.Windows.Forms.ComboBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.TatalPriceLabel = new System.Windows.Forms.Label();
            this.ShowTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.PaidListLable = new System.Windows.Forms.Label();
            this.ShoppingCartViewer = new System.Windows.Forms.DataGridView();
            this.PaidList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.Controls.Add(this.productName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.quantityLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.quantity, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.unitPrice, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnitPriceLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.productNameLable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCheckIn, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productName.Location = new System.Drawing.Point(80, 20);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(127, 29);
            this.productName.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(250, 25);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(44, 18);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "數量";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantity.Location = new System.Drawing.Point(302, 20);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(76, 29);
            this.quantity.TabIndex = 3;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unitPrice
            // 
            this.unitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unitPrice.Location = new System.Drawing.Point(460, 20);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(152, 29);
            this.unitPrice.TabIndex = 4;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(408, 25);
            this.UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(44, 18);
            this.UnitPriceLabel.TabIndex = 5;
            this.UnitPriceLabel.Text = "金額";
            // 
            // productNameLable
            // 
            this.productNameLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productNameLable.AutoSize = true;
            this.productNameLable.Location = new System.Drawing.Point(28, 25);
            this.productNameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLable.Name = "productNameLable";
            this.productNameLable.Size = new System.Drawing.Size(44, 18);
            this.productNameLable.TabIndex = 0;
            this.productNameLable.Text = "產品";
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCheckIn.Location = new System.Drawing.Point(620, 17);
            this.BtnCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(112, 34);
            this.BtnCheckIn.TabIndex = 6;
            this.BtnCheckIn.Text = "CheckIn";
            this.BtnCheckIn.UseVisualStyleBackColor = true;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Discount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DiscountLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(840, 70);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Discount
            // 
            this.Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Discount.FormattingEnabled = true;
            this.Discount.Items.AddRange(new object[] {
            "無",
            "按讚優惠 -200"});
            this.Discount.Location = new System.Drawing.Point(97, 22);
            this.Discount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(199, 26);
            this.Discount.TabIndex = 0;
            this.Discount.SelectedIndexChanged += new System.EventHandler(this.Discount_SelectedIndexChanged);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(45, 26);
            this.DiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(44, 18);
            this.DiscountLabel.TabIndex = 1;
            this.DiscountLabel.Text = "優惠";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel3.Controls.Add(this.BtnCheckOut, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TatalPriceLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ShowTotalPrice, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 621);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(840, 78);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCheckOut.Location = new System.Drawing.Point(108, 10);
            this.BtnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(154, 57);
            this.BtnCheckOut.TabIndex = 0;
            this.BtnCheckOut.Text = "CheckOut";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // TatalPriceLabel
            // 
            this.TatalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TatalPriceLabel.AutoSize = true;
            this.TatalPriceLabel.Location = new System.Drawing.Point(378, 30);
            this.TatalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TatalPriceLabel.Name = "TatalPriceLabel";
            this.TatalPriceLabel.Size = new System.Drawing.Size(67, 18);
            this.TatalPriceLabel.TabIndex = 1;
            this.TatalPriceLabel.Text = "總金額:";
            // 
            // ShowTotalPrice
            // 
            this.ShowTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShowTotalPrice.AutoSize = true;
            this.ShowTotalPrice.Location = new System.Drawing.Point(458, 30);
            this.ShowTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowTotalPrice.Name = "ShowTotalPrice";
            this.ShowTotalPrice.Size = new System.Drawing.Size(117, 18);
            this.ShowTotalPrice.TabIndex = 2;
            this.ShowTotalPrice.Text = "ShowTotalPrice";
            this.ShowTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel4.Controls.Add(this.ShoppingCartLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PaidListLable, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ShoppingCartViewer, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.PaidList, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 139);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(840, 482);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Location = new System.Drawing.Point(45, 11);
            this.ShoppingCartLabel.Margin = new System.Windows.Forms.Padding(45, 0, 4, 0);
            this.ShoppingCartLabel.Name = "ShoppingCartLabel";
            this.ShoppingCartLabel.Size = new System.Drawing.Size(80, 18);
            this.ShoppingCartLabel.TabIndex = 0;
            this.ShoppingCartLabel.Text = "購物清單";
            // 
            // PaidListLable
            // 
            this.PaidListLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaidListLable.AutoSize = true;
            this.PaidListLable.Location = new System.Drawing.Point(615, 11);
            this.PaidListLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaidListLable.Name = "PaidListLable";
            this.PaidListLable.Size = new System.Drawing.Size(98, 18);
            this.PaidListLable.TabIndex = 1;
            this.PaidListLable.Text = "已結帳清單";
            // 
            // ShoppingCartViewer
            // 
            this.ShoppingCartViewer.AllowUserToAddRows = false;
            this.ShoppingCartViewer.AllowUserToDeleteRows = false;
            this.ShoppingCartViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingCartViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShoppingCartViewer.Location = new System.Drawing.Point(45, 40);
            this.ShoppingCartViewer.Margin = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.ShoppingCartViewer.Name = "ShoppingCartViewer";
            this.ShoppingCartViewer.RowHeadersWidth = 62;
            this.ShoppingCartViewer.RowTemplate.Height = 24;
            this.ShoppingCartViewer.Size = new System.Drawing.Size(521, 442);
            this.ShoppingCartViewer.TabIndex = 2;
            this.ShoppingCartViewer.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ShoppingCartViewer_CellBeginEdit);
            this.ShoppingCartViewer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShoppingCartViewer_CellValueChanged);
            // 
            // PaidList
            // 
            this.PaidList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaidList.FormattingEnabled = true;
            this.PaidList.ItemHeight = 18;
            this.PaidList.Location = new System.Drawing.Point(615, 44);
            this.PaidList.Margin = new System.Windows.Forms.Padding(4);
            this.PaidList.Name = "PaidList";
            this.PaidList.Size = new System.Drawing.Size(206, 434);
            this.PaidList.TabIndex = 3;
            this.PaidList.DoubleClick += new System.EventHandler(this.PaidList_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 699);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.TextBox unitPrice;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label productNameLable;
        private System.Windows.Forms.Button BtnCheckIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox Discount;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Label TatalPriceLabel;
        private System.Windows.Forms.Label ShowTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label ShoppingCartLabel;
        private System.Windows.Forms.Label PaidListLable;
        private System.Windows.Forms.DataGridView ShoppingCartViewer;
        private System.Windows.Forms.ListBox PaidList;
    }
}

