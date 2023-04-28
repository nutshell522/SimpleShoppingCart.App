using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ShoppingCart
{
    public class HistoryOrders
    {
        public readonly List<Order> _orders =new List<Order>();
        public readonly int _discount;
        public HistoryOrders(int discount)
        {
            _discount = discount;
        }

        /// <summary>
        /// 將資料加進_orders
        /// </summary>
        /// <param name="order"></param>
        public void CheckOut(Order order)
        {
            if (order == null) return;
            _orders.Add(order);
        }
    }
}
