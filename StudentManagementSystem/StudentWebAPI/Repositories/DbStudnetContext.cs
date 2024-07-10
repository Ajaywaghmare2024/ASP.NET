using Microsoft.EntityFrameworkCore;
using StudentWebAPI.Entities;
namespace StudentWebAPI.Repositories
{
    public class DbStudnetContext:DbContext
    {
        public DbSet<Student> students {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string conString = @"server=localhost;port=3306;user=root;password=root123;database=ecommerce";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s=>s.Student_Id);
                entity.Property(s=>s.Student_Name); 
            });
            modelBuilder.Entity<Student>().ToTable("student");
        }
    }
}

