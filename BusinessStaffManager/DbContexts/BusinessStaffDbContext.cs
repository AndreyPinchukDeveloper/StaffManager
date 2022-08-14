using Microsoft.EntityFrameworkCore;
using BusinessStaffManger.DTOs;

namespace BusinessStaffManger.DbContexts
{
    public class BusinessStaffDbContext:DbContext
    {
        public DbSet<DepartmentDTO> Departments { get; set; }
        public DbSet<PositionDTO> Positions { get; set; }
        public DbSet<StaffDTO> Staffs { get; set; }

        public BusinessStaffDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
