using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ShoppingCartItem
    {
        const decimal TaxRate = 0.1m;
        const decimal ImpTaxRate = 0.05m;
        public Product Item { get; set; }
        public int Quantity { get; set; }
        public decimal Taxes
        {
            get
            {
                return decimal.Ceiling(Item.Price * ((Item.IsExempt ? 0 : TaxRate) + (Item.IsImport ? ImpTaxRate : 0)) * 20) / 20;
            }
        }
    }
}
