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
    public partial class frmLichHen : Form
    {
        public frmLichHen()
        {
            InitializeComponent();
        }
        QLTiemTocDbContext context = new QLTiemTocDbContext();

        private Dictionary<string, (decimal gia, int thoiGian)> danhSachDichVu
            = new Dictionary<string, (decimal, int)>
        {
            { "Cắt tóc nam",     (50000,  30) },
            { "Nhuộm tóc",       (200000, 90) },
            { "Uốn tóc",         (300000, 120) },
            { "Duỗi tóc",        (350000, 150) },
            { "Gội đầu massage", (50000,  40) },
            { "Tạo kiểu",        (80000,  45) },
            { "Phục hồi tóc",    (250000, 60) }
        };

        bool isThem = false;
        int id = 0;

        private void frmLichHen_Load(object sender, EventArgs e)
        {
            LoadHoTen();
            LoadDichVu();
            LoadTrangThai();
            LoadKhachHang();
            LoadLichHen();
            BatTatChucNang(false);
        }

        private void BatTatChucNang(bool flag)
        {
            cboNhanVien.Enabled = flag;
            cboKhachHang.Enabled = flag;
            cboDichVu.Enabled = flag;
            dateThoiGian.Enabled = flag;
            cboTrangThai.Enabled = flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
            btnHuy.Enabled = flag;
        }

        private void ClearText()
        {
            cboNhanVien.SelectedIndex = -1;
            cboNhanVien.Text = "";
            cboKhachHang.SelectedIndex = -1; 
            cboKhachHang.Text = "";
            cboDichVu.SelectedIndex = -1;
            cboDichVu.Text = "";
            dateThoiGian.Value = DateTime.Today;
            cboTrangThai.SelectedIndex = -1;
            cboTrangThai.Text = "";
            id = 0;
        }

        private void LoadHoTen()
        {
            cboNhanVien.Items.Clear();
            cboNhanVien.Items.Add("Liễu Trí Mẫn");
            cboNhanVien.Items.Add("Hạ Dĩ Thần");
            cboNhanVien.Items.Add("Trịnh Đình Vũ");
            cboNhanVien.Items.Add("Thẩm Luyện");
            cboNhanVien.Items.Add("Ngôn Nhất Tri");

            cboNhanVien.SelectedIndex = -1;
        }
        private void LoadKhachHang()
        {
            var ds = context.KhachHang
                .Select(kh => new
                {
                    kh.KhachHangId,
                    kh.TenKH 
                })
                .ToList();

            cboKhachHang.DataSource = ds;
            cboKhachHang.DisplayMember = "TenKH"; 
            cboKhachHang.ValueMember = "TenKH";   
            cboKhachHang.SelectedIndex = -1;
        }

        private void LoadDichVu()
        {
            cboDichVu.Items.Clear();
            foreach (var key in danhSachDichVu.Keys)
                cboDichVu.Items.Add(key);

            cboDichVu.SelectedIndex = -1;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Chờ xử lý");
            cboTrangThai.Items.Add("Hoàn thành");
            cboTrangThai.Items.Add("Đã hủy");

            cboTrangThai.SelectedIndex = -1;
        }

        private void LoadLichHen()
        {
            var data = context.LichHen
                 .Select(lh => new
                 {
                     lh.LichHenId,
                     lh.TenNhanVien,
                     lh.TenKhachHang,
                     lh.DichVu,
                     lh.ThoiGianHen,
                     lh.TrangThai
                 })
                 .ToList();

            dataGridView.DataSource = data;

            dataGridView.Columns["LichHenId"].HeaderText = "ID";
            dataGridView.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dataGridView.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dataGridView.Columns["DichVu"].HeaderText = "Dịch vụ";
            dataGridView.Columns["ThoiGianHen"].HeaderText = "Thời gian hẹn";
            dataGridView.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            BatTatChucNang(true);
            ClearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0) return;
            isThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0) return;

            var lh = context.LichHen.Find(id);
            if (lh != null)
            {
                if (MessageBox.Show("Xóa lịch hẹn này?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.LichHen.Remove(lh);
                    context.SaveChanges();
                    LoadLichHen();
                    ClearText();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn tên nhân viên!");
                return;
            }
            if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }
            if (string.IsNullOrWhiteSpace(cboDichVu.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!");
                return;
            }
            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                MessageBox.Show("Vui lòng chọn trạng thái!");
                return;
            }

            try
            {
                if (isThem)
                {
                    var lh = new LichHen
                    {
                        TenNhanVien = cboNhanVien.Text.Trim(),
                        TenKhachHang = cboKhachHang.Text.Trim(),
                        DichVu = cboDichVu.Text.Trim(),
                        ThoiGianHen = dateThoiGian.Value,
                        TrangThai = cboTrangThai.Text.Trim()
                    };

                    context.LichHen.Add(lh);
                }
                else
                {
                    var lh = context.LichHen.Find(id);
                    if (lh != null)
                    {
                        lh.TenNhanVien = cboNhanVien.Text.Trim();
                        lh.TenKhachHang = cboKhachHang.Text.Trim();
                        lh.DichVu = cboDichVu.Text.Trim();
                        lh.ThoiGianHen = dateThoiGian.Value;
                        lh.TrangThai = cboTrangThai.Text.Trim();
                    }
                }

                context.SaveChanges();
                LoadLichHen();
                BatTatChucNang(false);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["LichHenId"].Value);

            cboNhanVien.Text = dataGridView.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();
            cboKhachHang.Text = dataGridView.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
            cboDichVu.Text = dataGridView.Rows[e.RowIndex].Cells["DichVu"].Value.ToString();

            var thoiGian = dataGridView.Rows[e.RowIndex].Cells["ThoiGianHen"].Value;
            if (thoiGian != null && thoiGian != DBNull.Value)
                dateThoiGian.Value = Convert.ToDateTime(thoiGian);

            cboTrangThai.Text = dataGridView.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
        }

    }
}
