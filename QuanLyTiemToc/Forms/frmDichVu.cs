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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        bool isThem = false;
        int id = 0;

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            BatTatChucNang(false);
            NapDuLieuComboBox();
            dtThoiGian.Format = DateTimePickerFormat.Custom;
            dtThoiGian.CustomFormat = "mm";
            dtThoiGian.ShowUpDown = true;
        }

        private void BatTatChucNang(bool flag)
        {
            cboDichVu.Enabled = flag;
            txtGia.Enabled = flag;
            dtThoiGian.Enabled = flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
            btnHuy.Enabled = flag;
        }

        // ================= LOAD DỊCH VỤ =================
        private void LoadDichVu()
        {
            var data = context.DichVu
                .Select(dv => new
                {
                    dv.DichVuId,
                    dv.TenDichVu,
                    dv.Gia,
                    dv.ThoiGian
                })
                .OrderByDescending(dv => dv.DichVuId)
                .ToList();

            dataGridView.DataSource = data;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns["DichVuId"].HeaderText = "ID";
                dataGridView.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
                dataGridView.Columns["Gia"].HeaderText = "Giá";
                dataGridView.Columns["ThoiGian"].HeaderText = "Thời gian (phút)";

                dataGridView.Columns["Gia"].DefaultCellStyle.Format = "N0";
            }
        }

        // ================= NẠP DỮ LIỆU COMBOBOX =================

        private void NapDuLieuComboBox()
        {
            cboDichVu.Items.Clear();
            cboDichVu.Items.Add("Cắt tóc nam");
            cboDichVu.Items.Add("Cắt tóc nữ");
            cboDichVu.Items.Add("Nhuộm tóc");
            cboDichVu.Items.Add("Uốn tóc");
            cboDichVu.Items.Add("Duỗi tóc");
            cboDichVu.Items.Add("Gội đầu massage");
            cboDichVu.Items.Add("Tạo kiểu");
            cboDichVu.Items.Add("Phục hồi tóc");
            cboDichVu.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearText();
            BatTatChucNang(true);
            cboDichVu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!");
                return;
            }
            isThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView.CurrentRow.Cells["DichVuId"].Value
            );

            using (var db = new QLTiemTocDbContext())
            {
                var dv = db.DichVu.Find(id);
                if (dv != null)
                {
                    db.DichVu.Remove(dv);
                    db.SaveChanges();
                }
            }

            LoadDichVu(); // reload grid
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDichVu.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giá!");
                return;
            }

            try
            {
                decimal gia = decimal.Parse(txtGia.Text);
                int thoiGian = dtThoiGian.Value.Minute;

                if (gia <= 0)
                {
                    MessageBox.Show("Giá phải lớn hơn 0!");
                    return;
                }

                if (isThem)
                {
                    var dv = new DichVu
                    {
                        TenDichVu = cboDichVu.Text.Trim(),
                        Gia = gia,
                        ThoiGian = thoiGian
                    };

                    context.DichVu.Add(dv);
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    var dv = context.DichVu.Find(id);
                    if (dv != null)
                    {
                        dv.TenDichVu = cboDichVu.Text.Trim();
                        dv.Gia = gia;
                        dv.ThoiGian = thoiGian;
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }

                context.SaveChanges();
                LoadDichVu();
                BatTatChucNang(false);
                ClearText();
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDichVu.Text))
            {
                LoadDichVu();
                return;
            }

            string keyword = cboDichVu.Text.Trim().ToLower();

            var data = context.DichVu
                .Where(dv => dv.TenDichVu.ToLower().Contains(keyword))
                .Select(dv => new
                {
                    dv.DichVuId,
                    dv.TenDichVu,
                    dv.Gia,
                    dv.ThoiGian
                })
                .ToList();

            dataGridView.DataSource = data;

            MessageBox.Show($"Tìm thấy {data.Count} kết quả");
        }



        private void ClearText()
        {
            cboDichVu.Text = "";
            txtGia.Clear();
            dtThoiGian.Value = DateTime.Now;
            id = 0;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
