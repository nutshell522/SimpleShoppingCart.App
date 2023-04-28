using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ShoppingCart
{
    public class Order
    {
        public Product Product { get; }
        public int Quantity { get; set; }
        public Order(Product product, int quantity)
        {
            if (product == null) throw new ArgumentNullException("order");
            if (quantity < 0) throw new ArgumentOutOfRangeException(nameof(quantity));

            if (quantity == 0) return;

            Product = product;
            Quantity = quantity;
        }
    }
}
