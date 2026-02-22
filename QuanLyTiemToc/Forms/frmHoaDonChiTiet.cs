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
    public partial class frmHoaDonChiTiet : Form
    {
        public frmHoaDonChiTiet()
        {
            InitializeComponent();

        }
        public frmHoaDonChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        int id;
        decimal giaDichVu = 0;
        BindingList<DanhSachHoaDonChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>();
        private void LayNhanVienVaoComboBox()
        {
            cboNhanVien.Items.Clear();
            cboNhanVien.Items.Add("Liễu Trí Mẫn");
            cboNhanVien.Items.Add("Hạ Dĩ Thần");
            cboNhanVien.Items.Add("Trịnh Đinh Vũ");
            cboNhanVien.Items.Add("Thẩm Luyện");
            cboNhanVien.Items.Add("Ngôn Nhất Trì");
            cboNhanVien.SelectedIndex = -1;
        }
        public void LayDichVuVaoComboBox()
        {
            var danhSach = context.DichVu.ToList();

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Chưa có dịch vụ nào trong database!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cboDichVu.DataSource = null;
            cboDichVu.Items.Clear();
            cboDichVu.DataSource = danhSach;
            cboDichVu.ValueMember = "DichVuId";
            cboDichVu.DisplayMember = "TenDichVu";
        }

        public void LaySanPhamVaoComboBox()
        {
            var danhSach = context.SanPham.ToList();

            cboSanPham.DataSource = null;
            cboSanPham.Items.Clear();
            cboSanPham.DataSource = danhSach;
            cboSanPham.ValueMember = "SanPhamId";
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.SelectedIndex = -1;
        }

        public void BatTatChucNang()
        {

            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }
        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            numDonGiaBan.Minimum = 0;
            numDonGiaBan.Maximum = 99999999;
            numDonGiaBan.DecimalPlaces = 0;
            numDonGiaBan.ThousandsSeparator = true;

            LayNhanVienVaoComboBox();
            LayDichVuVaoComboBox();
            LaySanPhamVaoComboBox();

            dataGridView.AutoGenerateColumns = false;

            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoaDonId", DataPropertyName = "HoaDonId", Visible = false });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "SanPhamID", DataPropertyName = "SanPhamID", Visible = false });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID", Width = 50 });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSanPham", HeaderText = "Tên sản phẩm", DataPropertyName = "TenSanPham", Width = 200 });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", HeaderText = "Số lượng", DataPropertyName = "SoLuong", Width = 80 });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DonGia",
                    HeaderText = "Đơn giá sản phẩm",
                    DataPropertyName = "DonGia",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
                });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "GiaDichVu",
                    HeaderText = "Giá dịch vụ",
                    DataPropertyName = "GiaDichVu",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight, ForeColor = Color.DarkGreen }
                });
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ThanhTien",
                    HeaderText = "Thành tiền",
                    DataPropertyName = "ThanhTien",
                    Width = 130,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight, ForeColor = Color.Blue }
                });
            }

            if (id != 0)
            {
                var hoaDon = context.HoaDon.Where(r => r.HoaDonId == id).SingleOrDefault();

                if (hoaDon != null)
                {
                    var tenNV = hoaDon.NhanVien?.HoTen;
                    if (!string.IsNullOrEmpty(tenNV))
                        cboNhanVien.Text = tenNV;

                    txtKhachHang.Text = hoaDon.KhachHang?.TenKH;

                    var hdct = context.HoaDonChiTiet.Where(r => r.HoaDonId == id).FirstOrDefault();
                    if (hdct != null)
                        cboDichVu.SelectedValue = hdct.DichVuId;

                    var ct = context.HoaDonChiTiet
                        .Where(r => r.HoaDonId == id)
                        .Select(r => new DanhSachHoaDonChiTiet
                        {
                            HoaDonId = r.HoaDonId,
                            SanPhamID = r.SanPhamId ?? 0,
                            TenSanPham = r.SanPham.TenSanPham,
                            SoLuong = (short)r.SoLuong,
                            DonGia = r.DonGia,
                            GiaDichVu = r.DichVu.Gia, // ← Lấy giá dịch vụ từ DB
                            ThanhTien = r.ThanhTien
                        }).ToList();

                    hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>(ct);
                }
            }

            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoLuongBan.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sanPhamChon = cboSanPham.SelectedItem as SanPham;
            int maSanPham = sanPhamChon.SanPhamId;

            // ← Thành tiền = (Đơn giá SP × Số lượng) + Giá dịch vụ
            decimal thanhTien = (numSoLuongBan.Value * numDonGiaBan.Value) + giaDichVu;

            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

            if (chiTiet != null)
            {
                chiTiet.SoLuong = (short)numSoLuongBan.Value;
                chiTiet.DonGia = numDonGiaBan.Value;
                chiTiet.GiaDichVu = giaDichVu;
                chiTiet.ThanhTien = thanhTien;
                dataGridView.Refresh();
            }
            else
            {
                hoaDonChiTiet.Add(new DanhSachHoaDonChiTiet
                {
                    ID = hoaDonChiTiet.Count + 1,
                    HoaDonId = id,
                    SanPhamID = maSanPham,
                    TenSanPham = cboSanPham.Text,
                    SoLuong = (short)numSoLuongBan.Value,
                    DonGia = numDonGiaBan.Value,
                    GiaDichVu = giaDichVu,       // ← Giá dịch vụ riêng
                    ThanhTien = thanhTien         // ← Tổng cộng
                });
            }

            BatTatChucNang();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value);
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
                hoaDonChiTiet.Remove(chiTiet);

            BatTatChucNang();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboDichVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nhanVien = context.NhanVien
                .FirstOrDefault(nv => nv.HoTen.ToLower() == cboNhanVien.Text.Trim().ToLower());

            if (nhanVien == null)
            {
                nhanVien = new NhanVien
                {
                    HoTen = cboNhanVien.Text.Trim(),
                    DienThoai = "",
                    DiaChi = "",
                    ChuyenMon = ""
                };
                context.NhanVien.Add(nhanVien);
                context.SaveChanges();
            }

            var khachHang = context.KhachHang
                .FirstOrDefault(kh => kh.TenKH.ToLower().Contains(txtKhachHang.Text.Trim().ToLower()));

            if (khachHang == null)
            {
                khachHang = new KhachHang
                {
                    TenKH = txtKhachHang.Text.Trim(),
                    SDT = "",
                    DiaChi = ""
                };
                context.KhachHang.Add(khachHang);
                context.SaveChanges();
            }

            var dichVuChon = cboDichVu.SelectedItem as DichVu;
            int maDichVu = dichVuChon?.DichVuId ?? 0;

            if (maDichVu == 0)
            {
                MessageBox.Show("Dịch vụ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

            try
            {
                if (id != 0)
                {
                    var hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienId = nhanVien.NhanVienId;
                        hd.KhachHangId = khachHang.KhachHangId;
                        hd.TongTien = tongTien;
                        context.HoaDon.Update(hd);

                        var old = context.HoaDonChiTiet.Where(r => r.HoaDonId == id).ToList();
                        context.HoaDonChiTiet.RemoveRange(old);

                        foreach (var item in hoaDonChiTiet)
                        {
                            context.HoaDonChiTiet.Add(new HoaDonChiTiet
                            {
                                HoaDonId = id,
                                DichVuId = maDichVu,
                                SanPhamId = item.SanPhamID,
                                SoLuong = item.SoLuong,
                                DonGia = item.DonGia,
                                ThanhTien = item.ThanhTien
                            });
                        }
                    }
                }
                else
                {
                    var hd = new HoaDon
                    {
                        NhanVienId = nhanVien.NhanVienId,
                        KhachHangId = khachHang.KhachHangId,
                        NgayLap = DateTime.Now,
                        TongTien = tongTien
                    };
                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet)
                    {
                        context.HoaDonChiTiet.Add(new HoaDonChiTiet
                        {
                            HoaDonId = hd.HoaDonId,
                            DichVuId = maDichVu,
                            SanPhamId = item.SanPhamID,
                            SoLuong = item.SoLuong,
                            DonGia = item.DonGia,
                            ThanhTien = item.ThanhTien
                        });
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

            string noiDung = $"========== HÓA ĐƠN ==========\n" +
                             $"NHÂN VIÊN  : {cboNhanVien.Text}\n" +
                             $"KHÁCH HÀNG : {txtKhachHang.Text}\n" +
                             $"DỊCH VỤ    : {cboDichVu.Text}\n" +
                             $"GIÁ DỊCH VỤ: {giaDichVu:N0} VNĐ\n" +
                             $"NGÀY LẬP   : {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                             $"==============================\n";

            foreach (var item in hoaDonChiTiet)
                noiDung += $"• {item.TenSanPham}\n" +
                           $"  SL: {item.SoLuong} x {item.DonGia:N0} + DV: {item.GiaDichVu:N0} = {item.ThanhTien:N0} VNĐ\n";

            noiDung += $"==============================\n" +
                       $"TỔNG TIỀN  : {tongTien:N0} VNĐ";

            MessageBox.Show(noiDung, "Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedItem == null) return;
            var dv = cboDichVu.SelectedItem as DichVu;
            if (dv != null)
            {
                giaDichVu = dv.Gia;
                numGiaDichVu.Value = dv.Gia; // ← Hiển thị lên ô Giá dịch vụ (numGiaDichVu)
            }

        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem == null) return;
            var sp = cboSanPham.SelectedItem as SanPham;
            if (sp != null)
            {
                numDonGiaBan.Value = sp.DonGia;
                numSoLuongBan.Value = 1;
            }
        } 
    }
}
