﻿using System;
using System.Collections.Generic;

namespace SalesTaxes
{
    public static class Util
    {
        public static IEnumerable<ShoppingCartItem> GetItemsList(int listnum)
        {

            var lstItems = new List<ShoppingCartItem>();

            switch (listnum)
            {
                case 1:
                    lstItems.AddRange(new List<ShoppingCartItem>
                    {
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "Book", Price = 12.49m, Type = Product.ProductType.Book, IsImport = false },
                            Quantity = 1
                        },

                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "music CD", Price = 14.99m, Type = Product.ProductType.Other, IsImport = false },
                            Quantity = 1
                        },
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "chocolate bar", Price = 0.85m, Type = Product.ProductType.Food, IsImport = false },
                            Quantity = 1
                        },
                    });
                    break;

                case 2:
                    lstItems.AddRange(new List<ShoppingCartItem>
                    {
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "imported box of chocolates", Price = 10.0m, Type = Product.ProductType.Food, IsImport = true },
                            Quantity = 1
                        },
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "imported bottle of perfume", Price = 47.5m, Type = Product.ProductType.Other, IsImport = true },
                            Quantity = 1
                        },
                    });
                    break;
                case 3:
                    lstItems.AddRange(new List<ShoppingCartItem>
                    {
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "imported bottle of perfume", Price = 27.99m, Type = Product.ProductType.Other, IsImport = true },
                            Quantity = 1
                        },
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "bottle of perfume", Price = 18.99m, Type = Product.ProductType.Other, IsImport = false },
                            Quantity = 1
                        },
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "packet of headache pills", Price = 9.75m, Type = Product.ProductType.Medical, IsImport = false },
                            Quantity = 1
                        },
                        new ShoppingCartItem
                        {
                            Item = new Product { Name = "box of imported chocolates", Price = 11.25m, Type = Product.ProductType.Food, IsImport = true },
                            Quantity = 1
                        },
                    });
                    break;
                default:
                    break;
            }

            return lstItems;
        }

        public static void PrintRecept(IEnumerable<ShoppingCartItem> items)
        {
            var salestaxes = 0.00m;
            var totalprice = 0.00m;

            foreach (var item in items)
            {
                salestaxes += item.Taxes * item.Quantity;
                totalprice += item.Item.Price * item.Quantity;
                Console.WriteLine("{0} {1} : {2}", item.Quantity, item.Item.Name, (item.Item.Price + item.Taxes) * item.Quantity);
            }
            totalprice += salestaxes;
            Console.WriteLine("Sales Taxes : {0} ", salestaxes);
            Console.WriteLine("Total : {0}", totalprice);
            Console.WriteLine(" ");
        }

    }
}
