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
using Microsoft.Reporting.WinForms;

namespace QuanLyTiemToc.Reports
{
    public partial class frmThongKeDichVu : Form
    {
        public frmThongKeDichVu()
        {
            InitializeComponent();
        }
        QLTiemTocDbContext context = new QLTiemTocDbContext();

        QLTiemTocDataSet.DanhSachDichVuDataTable danhSachDichVuDataTable =
            new QLTiemTocDataSet.DanhSachDichVuDataTable();

        string reportsFolder = Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

        private void DanhSachDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                var danhSachDichVu = context.DichVu
                    .Select(r => new
                    {
                        r.DichVuId,
                        r.TenDichVu,
                        r.Gia,
                        r.ThoiGian
                    })
                    .ToList();

                danhSachDichVuDataTable.Clear();
                foreach (var row in danhSachDichVu)
                {
                    danhSachDichVuDataTable.AddDanhSachDichVuRow(
                        row.DichVuId,
                        row.TenDichVu,
                        row.Gia,
                        row.ThoiGian
                    );
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name  = "DanhSachDichVu";
                reportDataSource.Value = danhSachDichVuDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                reportViewer.LocalReport.ReportEmbeddedResource =
                    "QuanLyTiemToc.Reports.rptThongKeDichVu.rdlc";

                ReportParameter reportParameter = new ReportParameter(
                    "MoTaKetQuaHienThi", "(Tất cả dịch vụ)");
                reportViewer.LocalReport.SetParameters(reportParameter);

                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode    = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                string chiTiet = ex.Message;
                if (ex.InnerException != null)
                    chiTiet += "\n\nChi tiết: " + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    chiTiet += "\n\nChi tiết 2: " + ex.InnerException.InnerException.Message;

                MessageBox.Show(chiTiet, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
