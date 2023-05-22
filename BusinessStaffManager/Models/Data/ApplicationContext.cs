using BusinessStaffManger.Models.Reservations;
using Microsoft.EntityFrameworkCore;

namespace BusinessStaffManager.Models.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<StaffReservation> Staffs { get; set; }
        public DbSet<PositionReservation> Positions { get; set; }
        public DbSet<DepartmentReservation> Departments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();//ensure to create database if it's not exist
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database = BusinessStaffManagerDB;Trusted_connection=true;");
        }
    }
}
