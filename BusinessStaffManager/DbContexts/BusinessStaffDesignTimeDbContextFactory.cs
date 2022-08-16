using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BusinessStaffManger.DbContexts
{
    /// <summary>
    /// We need class to implement IDesignTimeDbContextFactory<T> - t is our context
    /// to create a Migrations
    /// </summary>
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
