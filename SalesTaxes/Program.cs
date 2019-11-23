using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingCartItem> itemList = getItemsList();

            decimal salestaxes = 0.00m;
            decimal totalprice = 0.00m;

            foreach (ShoppingCartItem item in itemList)
            {
                salestaxes += item.Taxes * item.Quantity;
                totalprice += item.Item.Price * item.Quantity;
                Console.WriteLine(string.Format("{0} {1} : {2}", item.Quantity, item.Item.Name, (item.Item.Price + item.Taxes) * item.Quantity));
            }
            totalprice += salestaxes;
            Console.WriteLine("Sales Taxes : " + salestaxes);
            Console.WriteLine("Total : " + totalprice);
            Console.ReadLine();
        }

        private static List<ShoppingCartItem> getItemsList()
        {
            List<ShoppingCartItem> lstItems = new List<ShoppingCartItem>();
            //input 1

            lstItems.Add(new ShoppingCartItem { Item = new Product { Name = "Book", Price = 12.49m, Type = Product.ProductType.book, IsImport = false }, Quantity = 1 });
            lstItems.Add(new ShoppingCartItem { Item = new Product { Name = "music CD", Price = 14.99m, Type = Product.ProductType.other, IsImport = false }, Quantity = 1 });
            lstItems.Add(new ShoppingCartItem { Item = new Product { Name = "chocolate bar", Price = 0.85m, Type = Product.ProductType.food, IsImport = false }, Quantity = 1 });

            return lstItems;
        }
    }
}
