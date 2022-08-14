using Microsoft.EntityFrameworkCore;

namespace BusinessStaffManger.DbContexts
{
    public class BusinessStaffDbContextFactory
    {
        private readonly string _connectionString;
        public BusinessStaffDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public BusinessStaffDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;
            return new BusinessStaffDbContext(options);
        }
    }
}
