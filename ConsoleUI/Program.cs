using Business;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();

            // UnitPriceTest();

            // CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine($"{p.ProductName} / {p.CategoryName} ");
            }

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void UnitPriceTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());            

            foreach (var p in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine("{0} : {1}$", p.ProductName, p.UnitPrice);
            }
        }

        private static ProductManager ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            return productManager;
        }
    }
}
