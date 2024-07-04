using Microsoft.EntityFrameworkCore;
using FlipKart.Models;
namespace FlipKart.Repositories
{
    public class EstoreCollectionContext:DbContext

    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root;password=root123;Database=flipkart";
            optionsBuilder.UseMySQL(conString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p=>p.Title);    
                entity.Property(p=>p.Description);
                entity.Property(p=>p.Price);    
                entity.Property(p=>p.ImageUrl);
                entity.Property(p => p.Quantity);

            });

            modelBuilder.Entity<Product>().ToTable("Product");
        }


    }
}
