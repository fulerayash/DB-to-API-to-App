using ProductApi.Core.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Infrastructure
{
    public class ProductInitializeDB : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.products.Add(new Product
            {
                ProductID = "1",
                Color="Red",
                Details="It is made of Carbon Fiber",
                ExpiryDate=DateTime.Now,
                ImageUrl="HammerImg.png",
                InStock=true,
                Price=4000,
                Quantity= 5,
                Rating=5,
                Title="Hammer"
            });
            context.products.Add(new Product
            {
                ProductID = "2",
                Color = "Blue",
                Details = "It is made of Iron",
                ExpiryDate = DateTime.Now,
                ImageUrl = "NailsImg.png",
                InStock = true,
                Price = 40,
                Quantity = 5,
                Rating = 5,
                Title = "Nail"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
