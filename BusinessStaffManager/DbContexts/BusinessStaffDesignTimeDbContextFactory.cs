using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BusinessStaffManger.DbContexts
{
    public class BusinessStaffDesignTimeDbContextFactory : IDesignTimeDbContextFactory<BusinessStaffDbContext>
    {
        public BusinessStaffDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite
                ("Sata Source = BusinessStaff.db").Options;
            return new BusinessStaffDbContext(options);
        }
    }
}
