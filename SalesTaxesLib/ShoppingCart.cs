using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes
{
    public class ShoppingCart
    {
        public ShoppingCart(IEnumerable<ShoppingCartItem> items)
        {
            ItemList = items;
        }
        private IEnumerable<ShoppingCartItem> ItemList { get; set; } = new List<ShoppingCartItem>();

        public void CalcualteTotalPriceandTaxes()
        {
            var salestaxes = 0.00m;
            var totalprice = 0.00m;
            foreach (var item in ItemList)
            {
                SalesTaxes += item.Taxes * item.Quantity;
                totalprice += item.Item.Price * item.Quantity;
                Console.WriteLine("{0} {1} : {2}", item.Quantity, item.Item.Name, (item.Item.Price + item.Taxes) * item.Quantity);
            }
            TotalPrice += salestaxes;
        }

        public decimal TotalPrice { get; set; }
        public decimal SalesTaxes { get; set; }
    }
}
