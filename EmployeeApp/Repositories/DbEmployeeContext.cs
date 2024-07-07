using EmployeeApp.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeApp.Repositories
{
    public class DbEmployeeContext:DbContext
    {

        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root;password=root123;database=ecommerce";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name);
            });

            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
