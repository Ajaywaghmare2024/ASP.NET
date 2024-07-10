using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using StudentWebApp.Models;


namespace StudentWebApp.Repositories
{
    public class DbStudentContext : DbContext
    {
        public DbSet<Student> students { get; set; }

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
                entity.HasKey(s => s.Student_Id);
                entity.Property(s => s.Student_Name);
                entity.Property(s => s.Student_Email);
                entity.Property(s => s.Mobile_Number);
                entity.Property(s => s.Student_Address);
                entity.Property(s => s.Admission);
                entity.Property(s => s.Fees);
                entity.Property(s => s.Status);

            });
            modelBuilder.Entity<Student>().ToTable("student");
        }

    }
}
