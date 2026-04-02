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
            this.Load += new EventHandler(frmDichVu_Load);
        }
        bool isThem = false;
        int id = 0;

        private Dictionary<string, (decimal gia, int thoiGian)> danhSachDichVu
             = new Dictionary<string, (decimal, int)>
        {
            { "Cắt tóc nam",        (50000,  30)  },
            { "Nhuộm tóc",          (200000, 90)  },
            { "Uốn tóc",            (300000, 120) },
            { "Duỗi tóc",           (350000, 150) },
            { "Gội đầu massage",    (50000,  40)  },
            { "Tạo kiểu",           (80000,  45)  },
            { "Phục hồi tóc",       (250000, 60)  }
        };
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            numThoiGian.Minimum = 0;
            numThoiGian.Maximum = 300;
            numThoiGian.Value = 0;

            numDonGia.Minimum = 0;
            numDonGia.Maximum = 99999999;
            numDonGia.DecimalPlaces = 0;
            numDonGia.ThousandsSeparator = true;

            LoadDichVu();
            BatTatChucNang(false);
            NapDuLieuComboBox();
        }

        private void BatTatChucNang(bool flag)
        {
            cboDichVu.Enabled = flag;
            numDonGia.Enabled = flag;
            numThoiGian.Enabled = flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
            btnHuy.Enabled = flag;
        }

        // ================= LOAD DỊCH VỤ =================
        private void LoadDichVu()
        {
            try
            {
                using (var db = new QLTiemTocDbContext())
                {
                    var data = db.DichVu
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
                        dataGridView.Columns["DichVuId"].Visible = false;
                        dataGridView.Columns["DichVuId"].HeaderText = "ID";
                        dataGridView.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
                        dataGridView.Columns["Gia"].HeaderText = "Giá (VNĐ)";
                        dataGridView.Columns["ThoiGian"].HeaderText = "Thời gian (phút)";

                        dataGridView.Columns["Gia"].DefaultCellStyle.Format = "N0";
                        dataGridView.Columns["Gia"].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                    }

                    if (data.Count == 0)
                    {
                        MessageBox.Show("Chưa có dịch vụ nào trong cơ sở dữ liệu.\nHãy nhấn 'Thêm' để thêm dịch vụ mới.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message
                    + "\n\nChi tiết: " + ex.InnerException?.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // ================= NẠP DỮ LIỆU COMBOBOX =================


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

            if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int xoaId = Convert.ToInt32(
                dataGridView.CurrentRow.Cells["DichVuId"].Value);

            try
            {
                using (var db = new QLTiemTocDbContext())
                {
                    var dv = db.DichVu.Find(xoaId);
                    if (dv != null)
                    {
                        db.DichVu.Remove(dv);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                    }
                }

                LoadDichVu();
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message
                    + "\n\nChi tiết: " + ex.InnerException?.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDichVu.Text))
            {
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
                return;
            }

            // ❌ XÓA TOÀN BỘ ĐOẠN TEST KẾT NỐI Ở ĐÂY

            try
            {
                decimal gia = numDonGia.Value;
                int thoiGian = (int)numThoiGian.Value;

                using (var db = new QLTiemTocDbContext())
                {
                    if (isThem)
                    {
                        var dv = new DichVu
                        {
                            TenDichVu = cboDichVu.Text.Trim(),
                            Gia = gia,
                            ThoiGian = thoiGian
                        };
                        db.DichVu.Add(dv);
                    }
                    else
                    {
                        var dv = db.DichVu.Find(id);
                        if (dv == null)
                        {
                            MessageBox.Show("Không tìm thấy dịch vụ!");
                            return;
                        }
                        dv.TenDichVu = cboDichVu.Text.Trim();
                        dv.Gia = gia;
                        dv.ThoiGian = thoiGian;
                    }

                    db.SaveChanges(); // ← chỉ gọi 1 lần
                }

                MessageBox.Show(isThem ? "Thêm thành công!" : "Cập nhật thành công!");
                LoadDichVu();
                BatTatChucNang(false);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message
                    + "\n\nChi tiết: " + ex.InnerException?.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                using (var db = new QLTiemTocDbContext())
                {
                    var data = db.DichVu
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearText()
        {
            cboDichVu.SelectedIndex = -1;
            cboDichVu.Text = "";
            if (numDonGia.Minimum <= 0) numDonGia.Value = 0;
            if (numThoiGian.Minimum <= 0) numThoiGian.Value = 0;
            id = 0;
        }


        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenDichVu = cboDichVu.Text?.Trim();

            if (string.IsNullOrEmpty(tenDichVu)) return;

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

            var row = dataGridView.Rows[e.RowIndex];

            // ✅ Kiểm tra null trước khi convert
            if (row.Cells["DichVuId"].Value == null) return;

            id = Convert.ToInt32(row.Cells["DichVuId"].Value);
            cboDichVu.Text = row.Cells["TenDichVu"].Value?.ToString() ?? "";

            decimal gia = 0;
            decimal.TryParse(row.Cells["Gia"].Value?.ToString(), out gia);
            numDonGia.Value = gia;

            int thoiGian = 0;
            int.TryParse(row.Cells["ThoiGian"].Value?.ToString(), out thoiGian);
            numThoiGian.Value = thoiGian;
        }
      
    }
}

