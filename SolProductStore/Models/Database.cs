using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolProductStore.Models
{
    public class Database
    {
        public static List<Product> GetProduct() 
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Product 1",
                    Price = (decimal) 500.00
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Best Product Ever",
                    Price = (decimal)1500.00
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Papper Clip",
                    Price = (decimal)200.00
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Laptop",
                    Price = (decimal)2000.00
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Product Of the Month",
                    Price = (decimal)3000.00
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Furniture",
                    Price = (decimal)1100.00
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Board",
                    Price = (decimal)150.00
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Hoodie",
                    Price = (decimal)200.00
                },
                new Product
                {
                    ProductId = 9,
                    Name = "shoes",
                    Price = (decimal)110.00
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Phone",
                    Price = (decimal)1000.00
                }
            };
            return products;
        }
        public static Product GetProduct(string slug)
        {
            List<Product> products = Database.GetProduct();
            foreach (Product item in products)
            {
                if (item.Slug == slug)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
