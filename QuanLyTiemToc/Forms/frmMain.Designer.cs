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
            đangNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            khachHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            dịchVụToolStripMenuItem = new ToolStripMenuItem();
            lỊCHHẸToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đangNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đangNhậpToolStripMenuItem
            // 
            đangNhậpToolStripMenuItem.Name = "đangNhậpToolStripMenuItem";
            đangNhậpToolStripMenuItem.Size = new Size(185, 26);
            đangNhậpToolStripMenuItem.Text = "Đang nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(185, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(185, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu ";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(185, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khachHàngToolStripMenuItem, nhânViênToolStripMenuItem, sảnPhẩmToolStripMenuItem, dịchVụToolStripMenuItem, lỊCHHẸToolStripMenuItem, hóaĐơnToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(77, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý ";
            // 
            // khachHàngToolStripMenuItem
            // 
            khachHàngToolStripMenuItem.Name = "khachHàngToolStripMenuItem";
            khachHàngToolStripMenuItem.Size = new Size(224, 26);
            khachHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(224, 26);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // dịchVụToolStripMenuItem
            // 
            dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            dịchVụToolStripMenuItem.Size = new Size(224, 26);
            dịchVụToolStripMenuItem.Text = "Dịch vụ";
            // 
            // lỊCHHẸToolStripMenuItem
            // 
            lỊCHHẸToolStripMenuItem.Name = "lỊCHHẸToolStripMenuItem";
            lỊCHHẸToolStripMenuItem.Size = new Size(224, 26);
            lỊCHHẸToolStripMenuItem.Text = "Lịch hẹn";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 480);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đangNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem khachHàngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem dịchVụToolStripMenuItem;
        private ToolStripMenuItem lỊCHHẸToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
    }
}