using MvcCoreCastleWindsor.Abstract;
using MvcCoreCastleWindsor.Models;
using System.Collections.Generic;

namespace MvcCoreCastleWindsor.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id =1,
                    Name = "Laptop",
                    Price = 1000
                },

                new Product()
                {
                    Id = 2,
                    Name = "Phone",
                    Price = 1600
                },


                new Product()
                {
                    Id = 3,
                    Name = "Tablet",
                    Price = 1900
                },

            };
        }
    }
}
