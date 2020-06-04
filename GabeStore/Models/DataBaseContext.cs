using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabeStore.Models
{
    public class DataBaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Developer> Developers { get; set; }
        //public DbSet<Product> Products { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }
    }
}
