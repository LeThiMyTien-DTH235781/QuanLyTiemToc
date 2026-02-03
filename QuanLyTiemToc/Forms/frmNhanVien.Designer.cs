namespace QuanLyTiemToc.Forms
{
    partial class frmNhanVien
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
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            dtNhanVien = new DataGridView();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            txtMK = new TextBox();
            label7 = new Label();
            cbChuyenMon = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtNhanVien).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(1015, 172);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 38);
            btnThoat.TabIndex = 43;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnHuy.Location = new Point(1015, 116);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 38);
            btnHuy.TabIndex = 42;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(1015, 66);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 36);
            btnLuu.TabIndex = 41;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnSua.Location = new Point(855, 116);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 38);
            btnSua.TabIndex = 40;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Brown;
            btnXoa.Location = new Point(855, 172);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 38);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnThem.Location = new Point(855, 67);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 35);
            btnThem.TabIndex = 38;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(456, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 38);
            label1.TabIndex = 28;
            label1.Text = "Tiệm tóc nam Mable🍁";
            // 
            // dtNhanVien
            // 
            dtNhanVien.AllowUserToAddRows = false;
            dtNhanVien.AllowUserToDeleteRows = false;
            dtNhanVien.AllowUserToResizeRows = false;
            dtNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtNhanVien.Location = new Point(12, 246);
            dtNhanVien.MultiSelect = false;
            dtNhanVien.Name = "dtNhanVien";
            dtNhanVien.RowHeadersWidth = 51;
            dtNhanVien.Size = new Size(1258, 373);
            dtNhanVien.TabIndex = 46;
            dtNhanVien.CellClick += dtNhanVien_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label2.Location = new Point(49, 93);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 47;
            label2.Text = "Họ và Tên: ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(136, 89);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(235, 27);
            txtHoTen.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label3.Location = new Point(49, 135);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 47;
            label3.Text = "Điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(136, 131);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(235, 27);
            txtSDT.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label4.Location = new Point(49, 181);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 47;
            label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(136, 177);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(235, 27);
            txtDiaChi.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label5.Location = new Point(444, 90);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 47;
            label5.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(580, 89);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(235, 27);
            txtTenDangNhap.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label6.Location = new Point(444, 135);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 47;
            label6.Text = "Mật khẩu:";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(580, 131);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(235, 27);
            txtMK.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label7.Location = new Point(444, 185);
            label7.Name = "label7";
            label7.Size = new Size(98, 17);
            label7.TabIndex = 47;
            label7.Text = "Chuyên môn:";
            // 
            // cbChuyenMon
            // 
            cbChuyenMon.FormattingEnabled = true;
            cbChuyenMon.Items.AddRange(new object[] { "Thợ chính", "Thợ phụ" });
            cbChuyenMon.Location = new Point(580, 176);
            cbChuyenMon.Name = "cbChuyenMon";
            cbChuyenMon.Size = new Size(151, 28);
            cbChuyenMon.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SlateGray;
            label8.Location = new Point(49, 41);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 27);
            label8.TabIndex = 50;
            label8.Text = "Thông Tin";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 631);
            Controls.Add(label8);
            Controls.Add(cbChuyenMon);
            Controls.Add(txtDiaChi);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtMK);
            Controls.Add(label6);
            Controls.Add(txtSDT);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(dtNhanVien);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtDiaChi;
        private Label label1;
        private DataGridView dtNhanVien;
        private Label label2;
        private TextBox txtHoTen;
        private Label label3;
        private TextBox txtSDT;
        private Label label4;
       // private TextBox txtDiaChi;
        private Label label5;
        private TextBox txtTenDangNhap;
        private Label label6;
        private TextBox txtMK;
        private Label label7;
        private ComboBox cbChuyenMon;
        private Label label8;
    }
}