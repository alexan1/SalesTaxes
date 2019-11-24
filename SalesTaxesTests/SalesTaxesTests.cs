using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SalesTaxes
{
    [TestClass]
    public class SalesTaxesTests
    {
        [TestMethod]
        public void TestProduct1()
        {
            var product1 = new Product
            {
                Name = "Book",
                Price = 12.49m,
                IsImport = false,
                Type = Product.ProductType.Book
            };
            var item1 = new ShoppingCartItem
            {
                Item = product1,
                Quantity = 1
            };

            var actual = item1.Taxes;
            var expected = 0.00m;
            Assert.AreEqual(expected, actual, "Should be zero taxes");
        }

        [TestMethod]
        public void TestProduct2()
        {
            var product1 = new Product
            {
                Name = "music CD",
                Price = 14.99m,
                IsImport = false,
                Type = Product.ProductType.Other
            };

            var item1 = new ShoppingCartItem
            {
                Item = product1,
                Quantity = 1
            };

            var actual = item1.Taxes;
            var expected = 1.5m;
            Assert.AreEqual(expected, actual, "Wrong taxes");
        }

        [TestMethod]
        public void TestProduct3()
        {
            var product1 = new Product
            {
                Name = "imported box of chocolates",
                Price = 10.00m,
                IsImport = true,
                Type = Product.ProductType.Food
            };

            var item1 = new ShoppingCartItem
            {
                Item = product1,
                Quantity = 1
            };

            var actual = item1.Taxes;
            var expected = 0.50m;
            Assert.AreEqual(expected, actual, "Wrong taxes");
        }

        [TestMethod]
        public void TestProduct4()
        {
            var product1 = new Product
            {
                Name = "imported bottle of perfume",
                Price = 47.50m,
                IsImport = true,
                Type = Product.ProductType.Other
            };

            var item1 = new ShoppingCartItem
            {
                Item = product1,
                Quantity = 1
            };

            var actual = item1.Taxes;
            var expected = 7.15m;
            Assert.AreEqual(expected, actual, "Wrong taxes");
        }

        [TestMethod]
        public void TestCart1()
        {
            IEnumerable<ShoppingCartItem> itemList = Util.GetItemsList(1);

        }
    }
}
