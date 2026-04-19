namespace QuanLyTiemToc.Forms
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 215);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 152);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.Gainsboro;
            txtMatKhau.Location = new Point(232, 208);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(311, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.Gainsboro;
            txtTenDangNhap.Location = new Point(232, 149);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(311, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Gainsboro;
            btnDangNhap.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(116, 325);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(124, 29);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Gainsboro;
            btnHuyBo.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(399, 325);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Mable;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(714, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 480);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMatKhau;
        internal TextBox txtTenDangNhap;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private PictureBox pictureBox1;
    }
}