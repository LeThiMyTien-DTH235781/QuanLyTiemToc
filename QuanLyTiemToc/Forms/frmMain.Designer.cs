namespace QuanLyTiemToc.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuDichVu = new ToolStripMenuItem();
            mnuLichHen = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            mnuThongKeDichVu = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            mnuThongTinPhamMen = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, báoCáoToolStripMenuItem, mnuHuongDanSuDung });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(185, 26);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(185, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(185, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu ";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(185, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuKhachHang, mnuNhanVien, mnuSanPham, mnuDichVu, mnuLichHen, mnuHoaDon });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(77, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý ";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(169, 26);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(169, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(169, 26);
            mnuSanPham.Text = "Sản phẩm";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuDichVu
            // 
            mnuDichVu.Name = "mnuDichVu";
            mnuDichVu.Size = new Size(169, 26);
            mnuDichVu.Text = "Dịch vụ";
            mnuDichVu.Click += mnuDichVu_Click;
            // 
            // mnuLichHen
            // 
            mnuLichHen.Name = "mnuLichHen";
            mnuLichHen.Size = new Size(169, 26);
            mnuLichHen.Text = "Lịch hẹn";
            mnuLichHen.Click += mnuLichHen_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(169, 26);
            mnuHoaDon.Text = "Hóa đơn";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeDichVu, mnuThongKeDoanhThu });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(152, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo - Thống kê";
            // 
            // mnuThongKeDichVu
            // 
            mnuThongKeDichVu.Name = "mnuThongKeDichVu";
            mnuThongKeDichVu.Size = new Size(228, 26);
            mnuThongKeDichVu.Text = "Thống kê dịch vụ";
            mnuThongKeDichVu.Click += mnuThongKeDichVu_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(228, 26);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu ";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, mnuThongTinPhamMen });
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.Size = new Size(78, 24);
            mnuHuongDanSuDung.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(228, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng ";
            hướngDẫnSửDụngToolStripMenuItem.Click += hướngDẫnSửDụngToolStripMenuItem_Click;
            // 
            // mnuThongTinPhamMen
            // 
            mnuThongTinPhamMen.Name = "mnuThongTinPhamMen";
            mnuThongTinPhamMen.Size = new Size(228, 26);
            mnuThongTinPhamMen.Text = "Thông tin phần mền";
            mnuThongTinPhamMen.Click += mnuThongTinPhamMen_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 461);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(829, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.ForeColor = SystemColors.WindowText;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 20);
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(697, 20);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "                                                                                    ";
            // 
            // lblLienKet
            // 
            lblLienKet.ForeColor = Color.DodgerBlue;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(78, 20);
            lblLienKet.Text = "@2026 FIT";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(829, 487);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuDichVu;
        private ToolStripMenuItem mnuLichHen;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongKeDichVu;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem mnuThongTinPhamMen;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripStatusLabel lblTrangThai;
    }
}