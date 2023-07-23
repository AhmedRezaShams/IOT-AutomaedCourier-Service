using PetInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInformation.Models
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }

        public List<Product> findAll()
        {
            _products = new List<Product>
            {
                new Product()
                {
                    Id = "1",
                    Name = "a",
                    Photo = "a.jpg",
                    Price = 100.00
                },
                new Product()
                {
                    Id = "2",
                    Name = "b",
                    Photo = "a.jpg",
                    Price = 100.00
                },
                 new Product()
                {
                    Id = "3",
                    Name = "c",
                    Photo = "a.jpg",
                    Price = 100.00
                }
            };
            return _products;
        }
        public Product find(string Id)
        {
            List<Product> products = findAll();
            var prod = products.Where(a => a.Id == Id).FirstOrDefault();
            return prod;
        }
    }
}
