using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachAssignment.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get;set; }

        public DbSet<Address> Addresses { get; set; }


        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("Server=HSC-PG02B5AZ\\SQLEXPRESS;Database=Example1DB;Integrated Security=true;TrustServerCertificate=true");


         }*/
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}

