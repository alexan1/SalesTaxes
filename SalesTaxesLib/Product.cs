using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class Product
    {
        public enum ProductType
        {
            food = 1,
            book = 2,
            medical = 3,
            other = 4
        };

        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public bool IsImport { get; set; }
        public bool IsExempt
        {
            get
            {
                return (int)Type < 4;
            }
        }
    }
}
