using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemToc.Data
{
    public class QLTiemTocDbContext : DbContext
    {
        // Constructor dùng khi chạy runtime
        public QLTiemTocDbContext(DbContextOptions<QLTiemTocDbContext> options)
            : base(options)
        {
        }

        // Constructor cho design-time (Add-Migration)
        public QLTiemTocDbContext()
        {
        }

        // Cấu hình quan hệ – tránh lỗi cascade delete
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var fk in modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.NoAction;
            }

            base.OnModelCreating(modelBuilder);
        }

        // Đọc chuỗi kết nối từ App.config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    ConfigurationManager
                        .ConnectionStrings["QLTiemTocDbContext"]
                        .ConnectionString
                );
            }
        }

        // ===== DBSET =====

        // Khách hàng
        public DbSet<KhachHang> KhachHang { get; set; }

        // Nhân viên
        public DbSet<NhanVien> NhanVien { get; set; }

        // Dịch vụ (cắt, uốn, nhuộm…)
        public DbSet<DichVu> DichVu { get; set; }

        // Sản phẩm (dầu gội, sáp, thuốc nhuộm…)
        public DbSet<SanPham> SanPham { get; set; }

        // Hóa đơn
        public DbSet<HoaDon> HoaDon { get; set; }

        // Hóa đơn chi tiết
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
