﻿using ProductApi.Core.Entites;
using ProductApi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext context = new ProductContext();
        public void Add(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();
        }

        public void Delete(string ProductID)
        {
            Product p = context.products.Find(ProductID);
            context.products.Remove(p);
            context.SaveChanges();
        }

        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public Product GetById(string ProductID)
        {
            var p = (from r in context.products where r.ProductID == ProductID select r).FirstOrDefault();
            return p;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.products;
        }
    }
}
