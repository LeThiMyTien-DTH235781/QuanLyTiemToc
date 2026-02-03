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
    public partial class frmNhanVien : Form
    {
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        bool isThem = false;
        int id = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadChuyenMon();
            LoadNhanVien();
            BatTatChucNang(false);
        }
        private void BatTatChucNang(bool flag)
        {
            txtHoTen.Enabled = flag;
            txtSDT.Enabled = flag;
            txtDiaChi.Enabled = flag;
            txtTenDangNhap.Enabled = flag;
            txtMK.Enabled = flag;
            cbChuyenMon.Enabled = flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
            btnHuy.Enabled = flag;
        }

        // ================== LOAD CHUYÊN MÔN ==================
        private void LoadChuyenMon()
        {
            cbChuyenMon.Items.Clear();
            cbChuyenMon.Items.Add("Thợ cắt tóc");
            cbChuyenMon.Items.Add("Thợ uốn");
            cbChuyenMon.Items.Add("Thợ nhuộm");
            cbChuyenMon.Items.Add("Gội đầu massage");

            cbChuyenMon.SelectedIndex = -1;
        }

        // ================== LOAD NHÂN VIÊN ==================
        private void LoadNhanVien()
        {
            var data = context.NhanVien
                .Select(nv => new
                {
                    nv.NhanVienId,
                    nv.HoTen,
                    nv.DienThoai,
                    nv.DiaChi,
                    nv.TenDangNhap,
                    nv.ChuyenMon
                })
                .ToList();

            dtNhanVien.DataSource = data;
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
            txtTenDangNhap.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0) return;

            var nv = context.NhanVien.Find(id);
            if (nv != null)
            {
                if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    LoadNhanVien();
                    ClearText();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                if (isThem)
                {
                    var nv = new NhanVien
                    {
                        HoTen = txtHoTen.Text.Trim(),
                        DienThoai = txtSDT.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        TenDangNhap = txtTenDangNhap.Text.Trim(),
                        MatKhau = txtMK.Text.Trim(),
                        ChuyenMon = cbChuyenMon.Text
                    };

                    context.NhanVien.Add(nv);
                }
                else
                {
                    var nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoTen = txtHoTen.Text.Trim();
                        nv.DienThoai = txtSDT.Text.Trim();
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.MatKhau = txtMK.Text.Trim();
                        nv.ChuyenMon = cbChuyenMon.Text;
                    }
                }

                context.SaveChanges();
                LoadNhanVien();
                BatTatChucNang(false);
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

        private void dtNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = Convert.ToInt32(dtNhanVien.Rows[e.RowIndex].Cells["NhanVienId"].Value);

            txtHoTen.Text = dtNhanVien.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            txtSDT.Text = dtNhanVien.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            txtDiaChi.Text = dtNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtTenDangNhap.Text = dtNhanVien.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
            cbChuyenMon.Text = dtNhanVien.Rows[e.RowIndex].Cells["ChuyenMon"].Value.ToString();
        }
        private void ClearText()
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMK.Clear();
            cbChuyenMon.SelectedIndex = -1;
            id = 0;
        }

       
    }

}
