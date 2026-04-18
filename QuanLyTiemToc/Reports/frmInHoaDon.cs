using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyTiemToc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyTiemToc.Reports.QLTiemTocDataSet;

namespace QuanLyTiemToc.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLTiemTocDbContext context = new QLTiemTocDbContext();

        QLTiemTocDataSet.DanhSachHoaDonDataTable table =
            new QLTiemTocDataSet.DanhSachHoaDonDataTable();

        int id;
        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // Nếu không truyền id thì lấy hóa đơn mới nhất
                var hoaDon = context.HoaDon
                    .Include(hd => hd.KhachHang)
                    .Include(hd => hd.NhanVien)
                    .Include(hd => hd.HoaDonChiTiet)
                        .ThenInclude(ct => ct.DichVu)
                    .Include(hd => hd.HoaDonChiTiet)
                        .ThenInclude(ct => ct.SanPham)
                    .OrderByDescending(hd => hd.HoaDonId)
                    .FirstOrDefault(hd => id == 0 || hd.HoaDonId == id);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                table.Clear();
                int stt = 1;
                foreach (var ct in hoaDon.HoaDonChiTiet)
                {
                    table.AddDanhSachHoaDonRow(
                        ct.HoaDonChiTietId,
                        hoaDon.KhachHang != null ? hoaDon.KhachHang.TenKH : "",
                        ct.DichVu != null ? ct.DichVu.TenDichVu : "",
                        ct.DichVu != null ? ct.DichVu.Gia : 0,  
                        ct.SanPham != null ? ct.SanPham.TenSanPham : "",
                        ct.SanPham != null ? ct.DonGia : 0,
                        ct.ThanhTien
                    );
                }

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DanhSachHoaDon";
                rds.Value = table;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "QuanLyTiemToc.Reports.rptInHoaDonrdlc.rdlc";

                reportViewer1.LocalReport.SetParameters(new[]
                {
                    new ReportParameter("MoTaKetQuaHienThi"," ")
                });

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn:\n" + ex.Message
                    + "\n\nChi tiết: " + ex.InnerException?.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
