using CricketWebApp.Entitties;
using Microsoft.EntityFrameworkCore;

namespace CricketWebApp.Repositories
{
    public class DbCricketerContext:DbContext
    {
        public DbSet<Cricketer> cricketers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"Server=localhost;port=3306;user=root;password=root123;database=ecommerce";
;            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cricketer>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Name);
            });
            modelBuilder.Entity<Cricketer>().ToTable("Cricketer");
        }
    }
}
