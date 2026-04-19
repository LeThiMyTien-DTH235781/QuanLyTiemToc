using QuanLyTiemToc.Reports;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string tenNguoiDung = "";
        string tenDangNhap = "";
        frmDangNhap dangNhap = null;
        frmNhanVien nhanVien = null;
        frmKhachHang khachHang = null;
        frmSanPham sanPham = null;
        frmDichVu dichVu = null;
        frmLichHen lichHen = null;
        frmHoaDon hoaDon = null;
        frmHoaDonChiTiet hoaDonChiTiet = null;
        frmThongKeDoanhThu thongKeDoanhThu = null;
        frmThongKeDichVu thongKeDichVu = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }
        private void ChuaDangNhap()
        {
            // Hệ thống
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            // Quản lý
            mnuNhanVien.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuDichVu.Enabled = false;
            mnuLichHen.Enabled = false;
            mnuHoaDon.Enabled = false;


            // Báo cáo – Thống kê
            mnuThongKeDoanhThu.Enabled = false;
            mnuThongKeDichVu.Enabled = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void QuyenQuanLy()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuNhanVien.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuDichVu.Enabled = true;
            mnuLichHen.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeDichVu.Enabled = true;

            lblTrangThai.Text = "Quản lý: " + tenNguoiDung;
        }

        private void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuNhanVien.Enabled = false;
            mnuKhachHang.Enabled = true;
            mnuSanPham.Enabled = false;
            mnuDichVu.Enabled = false;
            mnuLichHen.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeDichVu.Enabled = true;

            lblTrangThai.Text = "Nhân viên: " + tenNguoiDung;
        }

        private void DangNhap()
        {
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDN = dangNhap.txtTenDangNhap.Text.Trim().ToLower();
                if (tenDN == "admin")
                {
                    tenNguoiDung = "Administrator";
                    QuyenQuanLy();
                }
                else
                {
                    tenNguoiDung = dangNhap.txtTenDangNhap.Text.Trim();
                    QuyenNhanVien();
                }
            }
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form child in MdiChildren)
                    child.Close();

                tenNguoiDung = "";
                tenDangNhap = "";
                ChuaDangNhap();
            }
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Đổi mật khẩu";
            frm.Size = new Size(320, 220);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;

            var lblCu = new Label { Text = "Mật khẩu cũ:", Left = 20, Top = 20, Width = 100 };
            var lblMoi = new Label { Text = "Mật khẩu mới:", Left = 20, Top = 60, Width = 100 };
            var lblXN = new Label { Text = "Xác nhận:", Left = 20, Top = 100, Width = 100 };

            var txtCu = new TextBox { Left = 130, Top = 17, Width = 150, UseSystemPasswordChar = true };
            var txtMoi = new TextBox { Left = 130, Top = 57, Width = 150, UseSystemPasswordChar = true };
            var txtXN = new TextBox { Left = 130, Top = 97, Width = 150, UseSystemPasswordChar = true };

            var btnLuu = new Button { Text = "Lưu", Left = 80, Top = 140, Width = 80 };
            var btnHuy = new Button { Text = "Hủy", Left = 170, Top = 140, Width = 80 };

            btnHuy.Click += (s, ev) => frm.Close();

            btnLuu.Click += (s, ev) =>
            {
                if (string.IsNullOrEmpty(txtCu.Text) ||
                    string.IsNullOrEmpty(txtMoi.Text) ||
                    string.IsNullOrEmpty(txtXN.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtCu.Text.Trim() != frmDangNhap.MatKhauHienTai)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCu.Clear();
                    txtCu.Focus();
                    return;
                }

                if (txtMoi.Text != txtXN.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXN.Clear();
                    txtXN.Focus();
                    return;
                }

                if (txtMoi.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Mật khẩu mới phải có ít nhất 3 ký tự.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmDangNhap.MatKhauHienTai = txtMoi.Text.Trim();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.Close();
            };

            frm.Controls.AddRange(new Control[] { lblCu, lblMoi, lblXN, txtCu, txtMoi, txtXN, btnLuu, btnHuy });
            frm.ShowDialog(this);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuDichVu_Click(object sender, EventArgs e)
        {
            if (dichVu == null || dichVu.IsDisposed)
            {
                dichVu = new frmDichVu();
                dichVu.MdiParent = this;
                dichVu.Show();
            }
            else
                dichVu.Activate();
        }

        private void mnuLichHen_Click(object sender, EventArgs e)
        {
            if (lichHen == null || lichHen.IsDisposed)
            {
                lichHen = new frmLichHen();
                lichHen.MdiParent = this;
                lichHen.Show();
            }
            else
                lichHen.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {

            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "HƯỚNG DẪN SỬ DỤNG\n\n" +
        "1. Đăng nhập bằng tài khoản được cấp.\n" +
        "2. Quản lý → Nhân viên / Khách hàng / Sản phẩm / Dịch vụ:\n" +
        "   thêm, sửa, xóa dữ liệu.\n" +
        "3. Quản lý → Lịch hẹn: đặt và theo dõi lịch hẹn.\n" +
        "4. Quản lý → Hóa đơn: lập, in và xuất hóa đơn.\n" +
        "5. Báo cáo – Thống kê: xem doanh thu và dịch vụ.",
        "Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Information
    );
        }

        private void mnuThongTinPhamMen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "QUẢN LÝ TIỆM TÓC v1.0\n" +
                "© 2024 FIT – AGU\n\n" +
                "Phần mềm quản lý tiệm tóc:\n" +
                "Nhân viên · Khách hàng · Sản phẩm\n" +
                "Dịch vụ · Lịch hẹn · Hóa đơn",
                "Thông tin phần mềm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThongKeDichVu_Click(object sender, EventArgs e)
        {
            if (thongKeDichVu == null || thongKeDichVu.IsDisposed)
            {
                thongKeDichVu = new frmThongKeDichVu();
                thongKeDichVu.MdiParent = this;
                thongKeDichVu.Show();
            }
            else
                thongKeDichVu.Activate();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
        }
    }
}
