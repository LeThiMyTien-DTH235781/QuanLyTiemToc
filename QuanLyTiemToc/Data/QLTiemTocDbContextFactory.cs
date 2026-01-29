using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace QuanLyTiemToc.Data
{
    public class QLTiemTocDbContextFactory
        : IDesignTimeDbContextFactory<QLTiemTocDbContext>
    {
        public QLTiemTocDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QLTiemTocDbContext>();

            // Đọc connection string từ App.config
            var connectionString =
                ConfigurationManager.ConnectionStrings["QLTiemTocDbContext"].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);

            return new QLTiemTocDbContext(optionsBuilder.Options);
        }
    }
}
