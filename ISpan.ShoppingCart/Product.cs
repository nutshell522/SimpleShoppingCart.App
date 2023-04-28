using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ShoppingCart
{
    public class Product
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = String.IsNullOrEmpty(value) ? "**商品名稱錯誤**" : value;
            }
        }
        private int _price;
        public int Price
        {
            get => _price;
            set 
            {
                _price = Math.Max(0, value); 
            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
