using Microsoft.EntityFrameworkCore;
using QuanLyTiemToc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "NhanVienId";
        }

        private void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "KhachHangId";
            cboKhachHang.SelectedIndex = -1;
        }

        public void LayDichVuVaoComboBox()
        {
            cboDichVu.DataSource = context.DichVu.ToList();
            cboDichVu.DisplayMember = "TenDichVu";
            cboDichVu.ValueMember = "DichVuId";
        }

        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "SanPhamId";
            
        }

        public void BatTatChucNang()
        {
            btnLuuHoaDon.Enabled = hoaDonChiTiet.Count > 0;
            btnXoa.Enabled = hoaDonChiTiet.Count > 0;
        }

        private void SetupDataGridView()
        {
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID",
                Width = 50
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenNhanVien",
                HeaderText = "Tên nhân viên",
                DataPropertyName = "TenNhanVien",
                Width = 130
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SanPhamID",
                DataPropertyName = "SanPhamID",
                Visible = false
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenKhachHang",
                HeaderText = "Tên khách hàng",
                DataPropertyName = "TenKhachHang",
                Width = 130
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSanPham",
                HeaderText = "Sản phẩm",
                DataPropertyName = "TenSanPham",
                Width = 130
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenDichVu",
                HeaderText = "Dịch vụ",
                DataPropertyName = "TenDichVu",
                Width = 120
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số lượng",
                DataPropertyName = "SoLuong",
                Width = 70
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                Width = 90
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GiaDichVu",
                HeaderText = "Giá DV",
                DataPropertyName = "GiaDichVu",
                Width = 90
            });

          
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThanhTien",
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                Width = 100
            });

            dataGridView.DataSource = hoaDonChiTiet;

            dataGridView.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dataGridView.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dataGridView.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["GiaDichVu"].DefaultCellStyle.Format = "N0";
            dataGridView.Columns["GiaDichVu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            // Load dữ liệu vào ComboBox
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LayDichVuVaoComboBox();
            LaySanPhamVaoComboBox();

            SetupDataGridView();

            BatTatChucNang();
        }
        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSanPham.SelectedItem == null) { MessageBox.Show("Chọn sản phẩm!"); return; }
                if (cboDichVu.SelectedItem == null) { MessageBox.Show("Chọn dịch vụ!"); return; }
                if (cboNhanVien.SelectedItem == null) { MessageBox.Show("Chọn nhân viên!"); return; }

                var sp = cboSanPham.SelectedItem as SanPham;
                var dv = cboDichVu.SelectedItem as DichVu;
                var nv = cboNhanVien.SelectedItem as NhanVien;

                decimal donGia = numDonGiaBan.Value;
                int soLuong = (int)numSoLuongBan.Value;
                decimal thanhTien = (donGia * soLuong) + dv.Gia;

                hoaDonChiTiet.Add(new DanhSachHoaDonChiTiet
                {
                    ID = hoaDonChiTiet.Count + 1,
                    TenNhanVien = nv.HoTen,
                    TenKhachHang = cboKhachHang.Text,
                    TenDichVu = dv.TenDichVu,
                    SanPhamID = sp.SanPhamId,
                    TenSanPham = sp.TenSanPham,
                    SoLuong = (short)soLuong,
                    DonGia = donGia,
                    GiaDichVu = dv.Gia,
                    ThanhTien = thanhTien
                });

                BatTatChucNang();
                MessageBox.Show($"Đã thêm! Tổng dòng: {hoaDonChiTiet.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI: " + ex.Message + "\n\n" + ex.StackTrace);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int idSP = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value);
            var item = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == idSP);

            if (item != null) hoaDonChiTiet.Remove(item);

            BatTatChucNang();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedItem == null) { MessageBox.Show("Chọn nhân viên!"); return; }
            if (cboKhachHang.SelectedItem == null) { MessageBox.Show("Chọn khách hàng!"); return; }
            if (cboDichVu.SelectedItem == null) { MessageBox.Show("Chọn dịch vụ!"); return; }
            if (hoaDonChiTiet.Count == 0) { MessageBox.Show("Chưa có sản phẩm nào!"); return; }

            var nv = cboNhanVien.SelectedItem as NhanVien;
            var kh = cboKhachHang.SelectedItem as KhachHang;
            var dv = cboDichVu.SelectedItem as DichVu;

            decimal tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

            if (id == 0)
            {
                var hd = new HoaDon
                {
                    NhanVienId = nv.NhanVienId,
                    KhachHangId = kh.KhachHangId,
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
                        DichVuId = dv.DichVuId,
                        SanPhamId = item.SanPhamID,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        ThanhTien = item.ThanhTien
                    });
                }

                context.SaveChanges();
            }

            MessageBox.Show("Lưu thành công!");
            this.Close();
        }

        
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDonChiTiet.Count == 0) { MessageBox.Show("Chưa có dữ liệu để in!"); return; }

            decimal tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

            string s =
                $"NHÂN VIÊN: {cboNhanVien.Text}\n" +
                $"KHÁCH: {cboKhachHang.Text}\n" +
                $"DỊCH VỤ: {cboDichVu.Text}\n\n";

            foreach (var i in hoaDonChiTiet)
            {
                s += $"{i.TenSanPham} x{i.SoLuong} - {i.ThanhTien:N0}\n";
            }

            s += $"\nTỔNG: {tongTien:N0}";

            MessageBox.Show(s);
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedItem is DichVu dv)
            {
                giaDichVu = dv.Gia;
                numGiaDichVu.Value = dv.Gia;
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is SanPham sp)
            {
                numDonGiaBan.Value = sp.DonGia;
                numSoLuongBan.Value = 1;
            }
        } 
    }
}
