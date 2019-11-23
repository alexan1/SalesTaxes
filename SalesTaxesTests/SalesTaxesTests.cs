using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesTaxes
{
    [TestClass]
    public class SalesTaxesTests
    {
        [TestClass]
        public class SalexTaxesUnitTest
        {
            [TestMethod]
            public void TestProduct1()
            {
                var product1 = new Product
                {
                    Name = "Book",
                    Price = 12.49m,
                    IsImport = false,
                    Type = Product.ProductType.book
                };
                var item1 = new ShoppingCartItem
                {
                    Item = product1,
                    Quantity = 1
                };

                var actual = item1.Taxes;
                decimal expected = 0.00m;
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
                    Type = Product.ProductType.other
                };

                var item1 = new ShoppingCartItem
                {
                    Item = product1,
                    Quantity = 1
                };

                var actual = item1.Taxes;
                decimal expected = 1.5m;
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
                    Type = Product.ProductType.food
                };

                var item1 = new ShoppingCartItem
                {
                    Item = product1,
                    Quantity = 1
                };

                var actual = item1.Taxes;
                decimal expected = 0.50m;
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
                    Type = Product.ProductType.other
                };

                var item1 = new ShoppingCartItem
                {
                    Item = product1,
                    Quantity = 1
                };

                var actual = item1.Taxes;
                decimal expected = 7.15m;
                Assert.AreEqual(expected, actual, "Wrong taxes");
            }
        }
    }
}
