using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

namespace QuanLyTiemToc.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();

        }
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        int id;


        private void LoadHoaDon()
        {
            var ds = context.HoaDon
                .Include(x => x.NhanVien)
                .Include(x => x.KhachHang)
                .Select(x => new
                {
                    x.HoaDonId,
                    TenNhanVien = x.NhanVien != null ? x.NhanVien.HoTen : "",
                    TenKhachHang = x.KhachHang != null ? x.KhachHang.TenKH : "",
                    x.NgayLap,
                    x.TongTien
                })
                .OrderByDescending(x => x.NgayLap)
                .ToList();

            dataGridView.DataSource = ds;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDonChiTiet frm = new frmHoaDonChiTiet())
            {
                frm.ShowDialog();
                LoadHoaDon();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                Width = 50
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoaDonId",
                DataPropertyName = "HoaDonId",
                Visible = false
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenNhanVien",
                HeaderText = "Nhân viên",
                DataPropertyName = "TenNhanVien",
                Width = 150
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenKhachHang",
                HeaderText = "Khách hàng",
                DataPropertyName = "TenKhachHang",
                Width = 150
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayLap",
                HeaderText = "Ngày lập",
                DataPropertyName = "NgayLap",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TongTien",
                HeaderText = "Tổng tiền",
                DataPropertyName = "TongTien",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0", 
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            LoadHoaDon();

          
            dataGridView.RowPostPaint += (s, ev) =>
            {
                dataGridView.Rows[ev.RowIndex].Cells["ID"].Value = ev.RowIndex + 1;
            };
        }
        private void LoadData()
        {
            var list = context.HoaDon
                .Include(x => x.NhanVien)
                .Include(x => x.KhachHang)
                .ToList();

            var data = list.Select(x => new DanhSachHoaDon
            {
                ID = x.HoaDonId,
                HoVaTenNhanVien = x.NhanVien != null ? x.NhanVien.HoTen : "",
                HoVaTenKhachHang = x.KhachHang != null ? x.KhachHang.TenKH : "",
                NgayLap = x.NgayLap,
                TongTien = x.TongTien
            }).ToList();

            dataGridView.DataSource = data;
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["HoaDonId"].Value);

            var hoaDon = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDonChiTiet)
                .FirstOrDefault(r => r.HoaDonId == id);

            if (hoaDon == null) return;

            string noiDung =
                $"MÃ HÓA ĐƠN: {hoaDon.HoaDonId}\n" +
                $"NHÂN VIÊN: {hoaDon.NhanVien?.HoTen ?? ""}\n" +
                $"KHÁCH HÀNG: {hoaDon.KhachHang?.TenKH ?? ""}\n" +
                $"NGÀY LẬP: {hoaDon.NgayLap:dd/MM/yyyy HH:mm}\n\n" +
                $"TỔNG TIỀN: {hoaDon.TongTien:N0} VNĐ";

            MessageBox.Show(noiDung, "Hóa Đơn");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["HoaDonId"].Value);

            using (frmHoaDonChiTiet frm = new frmHoaDonChiTiet(id))
            {
                frm.ShowDialog();
                LoadHoaDon();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xóa hóa đơn?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["HoaDonId"].Value);

                var hoaDon = context.HoaDon
                    .Include(r => r.HoaDonChiTiet)
                    .FirstOrDefault(r => r.HoaDonId == id);

                if (hoaDon != null)
                {
                    context.HoaDonChiTiet.RemoveRange(hoaDon.HoaDonChiTiet);
                    context.HoaDon.Remove(hoaDon);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa!");
                    LoadHoaDon();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = Microsoft.VisualBasic.Interaction
                .InputBox("Nhập tên:", "Tìm kiếm")
                .Trim()
                .ToLower();

            if (string.IsNullOrWhiteSpace(tuKhoa)) return;

            var ds = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Select(r => new
                {
                    r.HoaDonId,
                    TenNhanVien = r.NhanVien != null ? r.NhanVien.HoTen : "",
                    TenKhachHang = r.KhachHang != null ? r.KhachHang.TenKH : "",
                    r.NgayLap,
                    r.TongTien
                })
                .Where(r =>
                    r.TenNhanVien.ToLower().Contains(tuKhoa) ||
                    r.TenKhachHang.ToLower().Contains(tuKhoa) ||
                    r.HoaDonId.ToString().Contains(tuKhoa))
                .ToList();

            dataGridView.DataSource = ds;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
                return;
            }

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "CSV|*.csv",
                FileName = "HoaDon"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("MaHD,NhanVien,KhachHang,NgayLap,TongTien");

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    sb.AppendLine(
                        $"{row.Cells["HoaDonId"].Value}," +
                        $"{row.Cells["TenNhanVien"].Value}," +
                        $"{row.Cells["TenKhachHang"].Value}," +
                        $"{Convert.ToDateTime(row.Cells["NgayLap"].Value):dd/MM/yyyy}," +
                        $"{row.Cells["TongTien"].Value}");
                }

                System.IO.File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Xuất file OK!");
            }
        }
    }
}