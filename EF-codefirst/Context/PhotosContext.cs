using EF_codefirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_codefirst.Context
{
    public class PhotosContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=DESKTOP-I7SR8GJ;Database=CodeFirst;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Item>()
                .HasMany(p => p.Persons);
            base.OnModelCreating(modelBuilder);
        }

    }
}
