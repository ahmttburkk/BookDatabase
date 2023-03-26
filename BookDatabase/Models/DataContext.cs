using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDatabase.Models
{
    internal class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-06IBDOO\SQLEXPRESS;Database=BookDb;Trusted_Connection=True;Trust Server Certificate=true");
        }
    }
}
