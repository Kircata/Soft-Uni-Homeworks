namespace Orders
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class OrdersApplication
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var dataMapper = new DataMapper();
            var allCategoriesInData = dataMapper.GetAllCategories();
            var allProductsInData = dataMapper.GetAllProducts();
            var allOrdersInData = dataMapper.GetAllOrders();

            var fiveMostExpensiveProducts = allProductsInData
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);

            Console.WriteLine(string.Join(Environment.NewLine, fiveMostExpensiveProducts));

            PrintLine();

            var numberOfProdcutsPerCategory = allProductsInData
                .GroupBy(p => p.CategoryId)
                .Select(group => new
                {
                    Category = allCategoriesInData
                        .First(c => c.Id == group.Key)
                        .Name,
                    Count = group.Count()                 
                })
                .ToList();

            foreach (var category in numberOfProdcutsPerCategory)
            {
                Console.WriteLine("{0}: {1}", category.Category, category.Count);
            }

            PrintLine();

            var productsWithTheMostQuantity = allOrdersInData
                .GroupBy(order => order.ProductId)
                .Select(group => new
                {
                    Product = allProductsInData
                        .First(p => p.Id == group.Key)
                        .Name,
                    Quantities = group.Sum(grpgrp => grpgrp.Quantity)
                })
                .OrderByDescending(products => products.Quantities)
                .Take(5);

            foreach (var product in productsWithTheMostQuantity)
            {
                Console.WriteLine("{0}: {1}", product.Product, product.Quantities);
            }

            PrintLine();

            var mostProfitableCategory = allOrdersInData
                .GroupBy(o => o.ProductId)
                .Select(group => new 
                {
                    CatId = allProductsInData
                        .First(product => product.Id == group.Key)
                        .CategoryId,
                    Price = allProductsInData
                        .First(product => product.Id == group.Key)
                        .UnitPrice,
                    Quantity = group.Sum(order => order.Quantity)                
                })
                .GroupBy(group => group.CatId)
                .Select(group => new
                {
                    CategoryName = allCategoriesInData
                        .First(category => category.Id == group.Key)
                        .Name,
                    TotalQuantity = group.Sum(g => g.Quantity * g.Price)                 
                })
                .OrderByDescending(group => group.TotalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }

        private static void PrintLine()
        {
            Console.WriteLine(new string('-', 10));
        }
    }
}
