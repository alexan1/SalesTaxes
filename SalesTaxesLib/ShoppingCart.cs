using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes
{
    public class ShoppingCart
    {
        public IEnumerable<ShoppingCartItem> ItemList { get; set; } = new List<ShoppingCartItem>();

        public int TotalPrice { get; set; }
        public int SalesTaxes { get; set; }
    }
}
