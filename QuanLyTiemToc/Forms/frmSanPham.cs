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
    public partial class frmSanPham : Form
    {
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        bool isThem = false;
        int id = 0;

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadLoai();
            LoadDonVi();
            LoadSanPham();
            BatTatChucNang(false);
        }
        private void BatTatChucNang(bool flag)
        {
            txtTenSanPham.Enabled = flag;
            cbLoai.Enabled = flag;
            txtSoLuong.Enabled = flag;
            txtDonGia.Enabled = flag;
            cbDonVi.Enabled = flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
            btnHuy.Enabled = flag;
        }

        // ================= LOAD LOẠI =================
        private void LoadLoai()
        {
            cbLoai.Items.Clear();
            cbLoai.Items.Add("Dầu gội");
            cbLoai.Items.Add("Sáp vuốt tóc");
            cbLoai.Items.Add("Thuốc nhuộm");
            cbLoai.Items.Add("Thuốc uốn");
            cbLoai.Items.Add("Khác");
            cbLoai.SelectedIndex = -1;
        }

        // ================= LOAD ĐƠN VỊ =================
        private void LoadDonVi()
        {
            cbDonVi.Items.Clear();
            cbDonVi.Items.Add("Chai");
            cbDonVi.Items.Add("Hộp");
            cbDonVi.Items.Add("Tuýp");
            cbDonVi.Items.Add("Cái");
            cbDonVi.SelectedIndex = -1;
        }

        // ================= LOAD SẢN PHẨM =================
        private void LoadSanPham()
        {
            var data = context.SanPham
                .Select(sp => new
                {
                    sp.SanPhamId,
                    sp.TenSanPham,
                    sp.Loai,
                    sp.SoLuong,
                    sp.DonGia,
                    sp.DonVi
                })
                .ToList();

            dtSanPham.DataSource = data;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearText();
            BatTatChucNang(true);
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

            var sp = context.SanPham.Find(id);
            if (sp != null)
            {
                if (MessageBox.Show("Xóa sản phẩm này?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.SanPham.Remove(sp);
                    context.SaveChanges();
                    LoadSanPham();
                    ClearText();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                cbLoai.SelectedIndex == -1 ||
                cbDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                if (isThem)
                {
                    var sp = new SanPham
                    {
                        TenSanPham = txtTenSanPham.Text.Trim(),
                        Loai = cbLoai.Text,
                        SoLuong = int.Parse(txtSoLuong.Text),
                        DonGia = decimal.Parse(txtDonGia.Text),
                        DonVi = cbDonVi.Text
                    };
                    context.SanPham.Add(sp);
                }
                else
                {
                    var sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TenSanPham = txtTenSanPham.Text.Trim();
                        sp.Loai = cbLoai.Text;
                        sp.SoLuong = int.Parse(txtSoLuong.Text);
                        sp.DonGia = decimal.Parse(txtDonGia.Text);
                        sp.DonVi = cbDonVi.Text;
                    }
                }

                context.SaveChanges();
                LoadSanPham();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu: " + ex.Message);
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

        private void dtSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = Convert.ToInt32(dtSanPham.Rows[e.RowIndex].Cells["SanPhamId"].Value);

            txtTenSanPham.Text = dtSanPham.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString();
            cbLoai.Text = dtSanPham.Rows[e.RowIndex].Cells["Loai"].Value.ToString();
            txtSoLuong.Text = dtSanPham.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = dtSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            cbDonVi.Text = dtSanPham.Rows[e.RowIndex].Cells["DonVi"].Value.ToString();
        }
        private void ClearText()
        {
            txtTenSanPham.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            cbLoai.SelectedIndex = -1;
            cbDonVi.SelectedIndex = -1;
            id = 0;
        }
    }
}
