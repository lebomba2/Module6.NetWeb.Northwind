using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Models
{
    // The database context. This is the connection to the database
    public class NorthwindContext : DbContext
    {
        // Constructor passing in DBContext options
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        // The connections to the tables in the database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}