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

<<<<<<< HEAD
        private Dictionary<string, (decimal gia, int thoiGian)> danhSachDichVu
            = new Dictionary<string, (decimal, int)>
        {
            { "Cắt tóc nam",        (50000,  30) },
            { "Nhuộm tóc",          (200000, 90) },
            { "Uốn tóc",            (300000, 120) },
            { "Duỗi tóc",           (350000, 150) },
            { "Gội đầu massage",    (50000,  40) },
            { "Tạo kiểu",           (80000,  45) },
            { "Phục hồi tóc",       (250000, 60) }
        };
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            // Cấu hình numThoiGian
            numThoiGian.Minimum = 0;
            numThoiGian.Maximum = 300; // Tối đa 300 phút
            numThoiGian.Value = 0;

            // Cấu hình numDonGia
            numDonGia.Minimum = 0;
            numDonGia.Maximum = 99999999;
            numDonGia.DecimalPlaces = 0;
            numDonGia.ThousandsSeparator = true;

            LoadDichVu();
            BatTatChucNang(false);
            NapDuLieuComboBox();
=======
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            BatTatChucNang(false);
            NapDuLieuComboBox();
            dtThoiGian.Format = DateTimePickerFormat.Custom;
            dtThoiGian.CustomFormat = "mm";
            dtThoiGian.ShowUpDown = true;
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
        }

        private void BatTatChucNang(bool flag)
        {
            cboDichVu.Enabled = flag;
<<<<<<< HEAD
            numDonGia.Enabled = flag;
            numThoiGian.Enabled = flag;
=======
            txtGia.Enabled = flag;
            dtThoiGian.Enabled = flag;
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a

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
<<<<<<< HEAD
                dataGridView.Columns["DichVuId"].Visible = false;
=======
                dataGridView.Columns["DichVuId"].HeaderText = "ID";
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
                dataGridView.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
                dataGridView.Columns["Gia"].HeaderText = "Giá";
                dataGridView.Columns["ThoiGian"].HeaderText = "Thời gian (phút)";

                dataGridView.Columns["Gia"].DefaultCellStyle.Format = "N0";
<<<<<<< HEAD
                dataGridView.Columns["Gia"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        // ================= NẠP COMBOBOX =================
        private void NapDuLieuComboBox()
        {
            cboDichVu.Items.Clear();
            foreach (var ten in danhSachDichVu.Keys)
                cboDichVu.Items.Add(ten);
            cboDichVu.SelectedIndex = -1;
        }

=======
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
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
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

<<<<<<< HEAD
            if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int xoaId = Convert.ToInt32(
                dataGridView.CurrentRow.Cells["DichVuId"].Value);

            using (var db = new QLTiemTocDbContext())
            {
                var dv = db.DichVu.Find(xoaId);
=======
            int id = Convert.ToInt32(
                dataGridView.CurrentRow.Cells["DichVuId"].Value
            );

            using (var db = new QLTiemTocDbContext())
            {
                var dv = db.DichVu.Find(id);
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
                if (dv != null)
                {
                    db.DichVu.Remove(dv);
                    db.SaveChanges();
                }
            }

<<<<<<< HEAD
            LoadDichVu();
            ClearText();
=======
            LoadDichVu(); // reload grid
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDichVu.Text))
            {
<<<<<<< HEAD
                MessageBox.Show("Vui lòng chọn tên dịch vụ!");
                return;
            }
            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0!");
                return;
            }
            if (numThoiGian.Value <= 0)
            {
                MessageBox.Show("Thời gian phải lớn hơn 0!");
=======
                MessageBox.Show("Vui lòng nhập tên dịch vụ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giá!");
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
                return;
            }

            try
            {
<<<<<<< HEAD
                decimal gia = numDonGia.Value;
                int thoiGian = (int)numThoiGian.Value;
=======
                decimal gia = decimal.Parse(txtGia.Text);
                int thoiGian = dtThoiGian.Value.Minute;

                if (gia <= 0)
                {
                    MessageBox.Show("Giá phải lớn hơn 0!");
                    return;
                }
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a

                if (isThem)
                {
                    var dv = new DichVu
                    {
                        TenDichVu = cboDichVu.Text.Trim(),
                        Gia = gia,
                        ThoiGian = thoiGian
                    };
<<<<<<< HEAD
=======

>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
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
<<<<<<< HEAD
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
=======
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
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
<<<<<<< HEAD
                Close();
=======
            {
                Close();
            }
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDichVu.Text))
            {
                LoadDichVu();
                return;
            }

            string keyword = cboDichVu.Text.Trim().ToLower();
<<<<<<< HEAD
=======

>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
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
<<<<<<< HEAD
=======

>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
            MessageBox.Show($"Tìm thấy {data.Count} kết quả");
        }



        private void ClearText()
        {
            cboDichVu.Text = "";
<<<<<<< HEAD
            cboDichVu.SelectedIndex = -1;
            numDonGia.Value = 0;
            numThoiGian.Value = 0;
=======
            txtGia.Clear();
            dtThoiGian.Value = DateTime.Now;
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
            id = 0;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

<<<<<<< HEAD
        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenDichVu = cboDichVu.Text;
            if (danhSachDichVu.ContainsKey(tenDichVu))
            {
                var info = danhSachDichVu[tenDichVu];
                numDonGia.Value = info.gia;
                numThoiGian.Value = info.thoiGian;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["DichVuId"].Value);
            cboDichVu.Text = dataGridView.Rows[e.RowIndex].Cells["TenDichVu"].Value.ToString();
            numDonGia.Value = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["Gia"].Value);
            numThoiGian.Value = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ThoiGian"].Value);
=======
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
        }
    }

}
