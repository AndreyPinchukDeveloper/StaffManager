using Microsoft.EntityFrameworkCore;
using BusinessStaffManger.DTOs;

namespace BusinessStaffManger.DbContexts
{
    public class BusinessStaffDbContext:DbContext
    {
        //DbSet - remote collection(not from memory) behold separate table to us 
        public DbSet<DepartmentDTO> Departments { get; set; }
        public DbSet<PositionDTO> Positions { get; set; }
        public DbSet<StaffDTO> Staffs { get; set; }

        public BusinessStaffDbContext(DbContextOptions options):base(options)
        {

        }

        //we can redefine the method OnConfiguring to define
        //which db we want to bind with our context
    }
}
