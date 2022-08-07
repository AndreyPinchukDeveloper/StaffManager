using Microsoft.EntityFrameworkCore;

namespace BusinessStaffManager.Models.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();//ensure to create database if it's not exist
        }
        protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database = BusinessStaffManagerDB;Trusted_connection=true;");
        }
    }
}
