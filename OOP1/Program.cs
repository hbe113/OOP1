using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnıtInStock = 2;

            Product product2 = new Product {Id=2, CategoryId=5, ProductName="Kalem", UnıtInStock=60, UnıtPrice=5};

            //PascalCase    camelCase
            //Case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
