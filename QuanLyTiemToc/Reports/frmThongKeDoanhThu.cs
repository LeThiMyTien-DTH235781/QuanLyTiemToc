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

namespace QuanLyTiemToc.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        QLTiemTocDataSet.DoanhThuDataTable doanhThuDataTable =
            new QLTiemTocDataSet.DoanhThuDataTable();

        private void NapReport(string moTa)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DoanhThu";
            reportDataSource.Value = doanhThuDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportEmbeddedResource =
                "QuanLyTiemToc.Reports.rptThongKeDoanhThu.rdlc";

            ReportParameter reportParameter =
                new ReportParameter("MoTaKetQuaHienThi", moTa);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        // ===== HÀM ĐỔ DỮ LIỆU =====
        private void DoDuLieu(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            var query = context.LichHen
                .Select(lh => new
                {
                    LichHenId = lh.LichHenId,
                    NgayHen = lh.ThoiGianHen,
                    TenKhachHang = lh.TenKhachHang,
                    TenNhanVien = lh.TenNhanVien,
                    TenDichVu = lh.DichVu,
                    Gia = context.DichVu
                                       .Where(dv => dv.TenDichVu == lh.DichVu)
                                       .Select(dv => dv.Gia)
                                       .FirstOrDefault(),
                    ThoiGian = context.DichVu
                                       .Where(dv => dv.TenDichVu == lh.DichVu)
                                       .Select(dv => dv.ThoiGian)
                                       .FirstOrDefault()
                });

            if (tuNgay.HasValue)
                query = query.Where(lh => lh.NgayHen >= tuNgay.Value);
            if (denNgay.HasValue)
                query = query.Where(lh => lh.NgayHen <= denNgay.Value);

            var doanhThu = query.ToList();

            doanhThuDataTable.Clear();
            foreach (var row in doanhThu)
            {
                doanhThuDataTable.AddDoanhThuRow(
                    row.LichHenId,
                    row.NgayHen,
                    row.TenKhachHang,
                    row.TenNhanVien,
                    row.TenDichVu,
                    row.Gia,
                    row.ThoiGian,
                    row.Gia          // ThanhTien = Gia
                );
            }
        }
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                DoDuLieu();
                NapReport("(Tất cả thời gian)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo:\n" + ex.Message
                    + "\n\nChi tiết: " + ex.InnerException?.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DoDuLieu(tuNgay, denNgay);
                NapReport("Từ ngày: " + dtpTuNgay.Text + " – Đến ngày: " + dtpDenNgay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu:\n" + ex.Message
                    + "\n\nChi tiết: " + ex.InnerException?.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);

        }
    }
}
