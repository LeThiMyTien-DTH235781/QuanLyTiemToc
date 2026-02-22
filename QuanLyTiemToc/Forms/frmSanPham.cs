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

            LoadDonVi();
            LoadSanPham();
            LoadDanhSachSanPham();
            BatTatChucNang(false);
        }
        private void BatTatChucNang(bool flag)
        {
            txtMaSanPham.Enabled = false;
            cboSanPham.Enabled = flag;
            numSoLuong.Enabled = flag;
            numDonGia.Enabled = flag;
            cbDonVi.Enabled = flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;
            btnTim.Enabled = !flag;
            btnNhap.Enabled = !flag;
            btnXuat.Enabled = !flag;
            btnThoat.Enabled = !flag;

            btnLuu.Enabled = flag;
            btnHuy.Enabled = flag;
        }

        private void LoadSanPham()
        {
            cboSanPham.Items.Clear();
            cboSanPham.Items.Add("Dầu gội");
            cboSanPham.Items.Add("Sáp vuốt tóc");
            cboSanPham.Items.Add("Thuốc nhuộm");
            cboSanPham.Items.Add("Thuốc uốn");
            cboSanPham.Items.Add("Khác");
            cboSanPham.SelectedIndex = -1;
        }

        private void LoadDanhSachSanPham()
        {
            dtSanPham.AutoGenerateColumns = false;

            // Luôn clear để tránh bị trùng/đè
            dtSanPham.DataSource = null;
            dtSanPham.Columns.Clear(); // ← Thêm dòng này

            dtSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SanPhamId",
                HeaderText = "ID",
                DataPropertyName = "SanPhamId",
                Width = 50
            });

            dtSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSanPham",
                HeaderText = "Sản phẩm",
                DataPropertyName = "TenSanPham",
                Width = 200
            });

            dtSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số lượng",
                DataPropertyName = "SoLuong",
                Width = 100
            });

            dtSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonVi",
                HeaderText = "Đơn vị",
                DataPropertyName = "DonVi",
                Width = 100
            });

            dtSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            var danhSach = context.SanPham.ToList();
            dtSanPham.DataSource = danhSach;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearText();
            BatTatChucNang(true);
            cboSanPham.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isThem = false;
            BatTatChucNang(true);
            cboSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        context.SanPham.Remove(sp);
                        context.SaveChanges();
                        LoadDanhSachSanPham();
                        ClearText();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập tên sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSanPham.Focus();
                return;
            }

            if (cbDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDonVi.Focus();
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoLuong.Focus();
                return;
            }

            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDonGia.Focus();
                return;
            }

            try
            {
                if (isThem)
                {
                    var sp = new SanPham
                    {
                        TenSanPham = cboSanPham.Text.Trim(),
                        SoLuong = (int)numSoLuong.Value,
                        DonGia = numDonGia.Value,
                        DonVi = cbDonVi.Text
                    };
                    context.SanPham.Add(sp);
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TenSanPham = cboSanPham.Text.Trim();
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.DonGia = numDonGia.Value;
                        sp.DonVi = cbDonVi.Text;
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                context.SaveChanges();
                LoadDanhSachSanPham();
                BatTatChucNang(false);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearText()
        {
            txtMaSanPham.Text = string.Empty;
            cboSanPham.Text = string.Empty;
            cboSanPham.SelectedIndex = -1;
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            cbDonVi.SelectedIndex = -1;
            id = 0;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên sản phẩm cần tìm:", "Tìm kiếm", "");

            if (string.IsNullOrWhiteSpace(keyword)) return;

            var ketQua = context.SanPham
                .Where(sp => sp.TenSanPham.Contains(keyword))
                .ToList();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSanPham(); // Reset lại danh sách
            }
            else
            {
                dtSanPham.DataSource = null;
                dtSanPham.DataSource = ketQua;
                MessageBox.Show($"Tìm thấy {ketQua.Count} sản phẩm.", "Kết quả",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file nhập dữ liệu";
                ofd.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = ofd.FileName;
                        string ext = System.IO.Path.GetExtension(filePath).ToLower();

                        if (ext == ".csv")
                        {
                            NhapTuCSV(filePath);
                        }
                        else
                        {
                            MessageBox.Show("Hiện chỉ hỗ trợ file CSV!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi nhập file: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void NhapTuCSV(string filePath)
        {
            int soLuongNhap = 0;
            int soLuongLoi = 0;
            var lines = System.IO.File.ReadAllLines(filePath, Encoding.UTF8);

            // Bỏ qua dòng tiêu đề (dòng đầu tiên)
            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    var cols = lines[i].Split(',');
                    if (cols.Length < 4) continue;

                    var sp = new SanPham
                    {
                        TenSanPham = cols[0].Trim(),
                        SoLuong = int.Parse(cols[1].Trim()),
                        DonVi = cols[2].Trim(),
                        DonGia = decimal.Parse(cols[3].Trim())
                    };

                    context.SanPham.Add(sp);
                    soLuongNhap++;
                }
                catch
                {
                    soLuongLoi++;
                }
            }

            context.SaveChanges();
            LoadDanhSachSanPham();
            MessageBox.Show($"Nhập thành công {soLuongNhap} sản phẩm.\nLỗi: {soLuongLoi} dòng.",
                "Kết quả nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu file xuất dữ liệu";
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"DanhSachSanPham_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var danhSach = context.SanPham.ToList();
                        var sb = new StringBuilder();

                        // Header
                        sb.AppendLine("Tên sản phẩm,Số lượng,Đơn vị,Đơn giá");

                        // Data
                        foreach (var sp in danhSach)
                        {
                            sb.AppendLine($"{sp.TenSanPham},{sp.SoLuong},{sp.DonVi},{sp.DonGia}");
                        }

                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show($"Xuất thành công {danhSach.Count} sản phẩm!\nFile: {sfd.FileName}",
                            "Xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bangGia = new Dictionary<string, decimal>
    {
        { "Dầu gội",        50000 },
        { "Sáp vuốt tóc",   80000 },
        { "Thuốc nhuộm",   150000 },
        { "Thuốc uốn",     120000 },
        { "Khác",                0 }
    };

            string tenSanPham = cboSanPham.Text;

            if (bangGia.ContainsKey(tenSanPham))
            {
                numDonGia.Value = bangGia[tenSanPham];
            }
        }

        private void dtSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dtSanPham.CurrentRow == null) return;

            try
            {
                var row = dtSanPham.CurrentRow;

                id = Convert.ToInt32(row.Cells["SanPhamId"].Value);
                txtMaSanPham.Text = id.ToString();
                cboSanPham.Text = row.Cells["TenSanPham"].Value?.ToString() ?? "";
                numSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                numDonGia.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
                cbDonVi.Text = row.Cells["DonVi"].Value?.ToString() ?? "";
            }
            catch { }
        }
    }
}

