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



        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDonChiTiet frm = new frmHoaDonChiTiet())
            {
                frm.ShowDialog();
                LoadData();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadData();
        }
        private void LoadData()
        {
            var hd = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDonChiTiet)
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.HoaDonId,
                    HoVaTenNhanVien = r.NhanVien.HoTen,
                    HoVaTenKhachHang = r.KhachHang.TenKH,
                    NgayLap = r.NgayLap,
                    TongTien = r.TongTien
                }).ToList();

            dataGridView.DataSource = hd;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn nào để in.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            var hoaDon = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDonChiTiet)
                .FirstOrDefault(r => r.HoaDonId == id);

            string noiDung = $"MÃ HÓA ĐƠN: {hoaDon.HoaDonId}\n" +
                             $"NHÂN VIÊN: {hoaDon.NhanVien.HoTen}\n" +
                             $"KHÁCH HÀNG: {hoaDon.KhachHang.TenKH}\n" +
                             $"NGÀY LẬP: {hoaDon.NgayLap:dd/MM/yyyy HH:mm}\n\n";

            noiDung += $"\nTỔNG TIỀN: {hoaDon.TongTien:N0} VNĐ";

            MessageBox.Show(noiDung, "Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            using (frmHoaDonChiTiet frm = new frmHoaDonChiTiet(id))
            {
                frm.ShowDialog();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                var hoaDon = context.HoaDon
                    .Include(r => r.HoaDonChiTiet)
                    .FirstOrDefault(r => r.HoaDonId == id);

                if (hoaDon != null)
                {
                    context.HoaDonChiTiet.RemoveRange(hoaDon.HoaDonChiTiet);
                    context.HoaDon.Remove(hoaDon);
                    context.SaveChanges();
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên nhân viên hoặc khách hàng:", "Tìm kiếm").Trim().ToLower();

            if (string.IsNullOrWhiteSpace(tuKhoa)) return;

            var hd = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDonChiTiet)
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.HoaDonId,
                    HoVaTenNhanVien = r.NhanVien.HoTen,
                    HoVaTenKhachHang = r.KhachHang.TenKH,
                    NgayLap = r.NgayLap,
                    TongTien = r.TongTien
                })
                .Where(r => r.HoVaTenNhanVien.ToLower().Contains(tuKhoa) ||
                            r.HoVaTenKhachHang.ToLower().Contains(tuKhoa) ||
                            r.ID.ToString().Contains(tuKhoa))
                .ToList();

            dataGridView.DataSource = hd;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV File|*.csv";
            saveDialog.FileName = "DanhSachHoaDon";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("Mã HĐ,Nhân viên,Khách hàng,Ngày lập,Tổng tiền");

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    sb.AppendLine($"{row.Cells["ID"].Value}," +
                                  $"{row.Cells["HoVaTenNhanVien"].Value}," +
                                  $"{row.Cells["HoVaTenKhachHang"].Value}," +
                                  $"{Convert.ToDateTime(row.Cells["NgayLap"].Value):dd/MM/yyyy}," +
                                  $"{row.Cells["TongTien"].Value}");
                }

                System.IO.File.WriteAllText(saveDialog.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                MessageBox.Show("Xuất file thành công!", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
