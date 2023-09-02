using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LibraryApp
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> BookTable { get; set; }
        public DbSet<Patron> Patron { get; set; } // Add Patron DbSet
        public DbSet<RemovedBook> RemovedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=LibraryAppDB; User Id=UserLapp; Password=12345678; TrustServerCertificate=True; MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("BookTable");
            modelBuilder.Entity<Patron>().ToTable("Patron"); // Specify the table name here
        }
    }
}
