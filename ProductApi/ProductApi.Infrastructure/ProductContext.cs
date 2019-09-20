using ProductApi.Core.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Infrastructure
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        public ProductContext() : base("name = ProductContext")
        {
            var a = Database.Connection.ConnectionString;
        }
    }
}
