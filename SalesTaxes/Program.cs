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
            IEnumerable<ShoppingCartItem> itemList = GetItemsList();

            var salestaxes = 0.00m;
            var totalprice = 0.00m;

            foreach (var item in itemList)
            {
                salestaxes += item.Taxes * item.Quantity;
                totalprice += item.Item.Price * item.Quantity;
                Console.WriteLine("{0} {1} : {2}", item.Quantity, item.Item.Name, (item.Item.Price + item.Taxes) * item.Quantity);
            }
            totalprice += salestaxes;
            Console.WriteLine("Sales Taxes : {0} ", salestaxes);
            Console.WriteLine("Total : {0}", totalprice);
            Console.ReadLine();
        }

        private static IEnumerable<ShoppingCartItem> GetItemsList()
        {
            return new List<ShoppingCartItem>

            {
                //input 1

                new ShoppingCartItem 
                { 
                    Item = new Product { Name = "Book", Price = 12.49m, Type = Product.ProductType.Book, IsImport = false }, 
                    Quantity = 1 
                },
                new ShoppingCartItem {
                    Item = new Product { Name = "music CD", Price = 14.99m, Type = Product.ProductType.Other, IsImport = false }, 
                    Quantity = 1 
                },
                new ShoppingCartItem { 
                    Item = new Product { Name = "chocolate bar", Price = 0.85m, Type = Product.ProductType.Food, IsImport = false }, 
                    Quantity = 1 
                },
            };
        }
            
    }
}
