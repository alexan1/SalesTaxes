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
            Food = 1,
            Book = 2,
            Medical = 3,
            Other = 4
        };

        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public bool IsImport { get; set; }
        public bool IsExempt
        {
            get
            {
                return Type != ProductType.Other;
            }
        }
    }
}
