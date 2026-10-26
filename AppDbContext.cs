using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment01
{
    internal class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BooksStore;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Book> Books {  get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
