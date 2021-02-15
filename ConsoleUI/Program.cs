using Business;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------------------");

            foreach (var p in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine("{0} : {1}$", p.ProductName, p.UnitPrice);
            }

            
        }
    }
}
