namespace QuanLyTiemToc.Forms
{
    partial class frmSanPham
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
            label8 = new Label();
            cbDonVi = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            txtDonGia = new TextBox();
            label6 = new Label();
            txtSoLuong = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtMaSanPham = new TextBox();
            label2 = new Label();
            dtSanPham = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            btnTim = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            cbLoai = new ComboBox();
            txtTenSanPham = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtSanPham).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SlateGray;
            label8.Location = new Point(69, 38);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 27);
            label8.TabIndex = 71;
            label8.Text = "Thông Tin";
            // 
            // cbDonVi
            // 
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Items.AddRange(new object[] { "Chai", "Hộp", "Tuýp", "Gói" });
            cbDonVi.Location = new Point(600, 173);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(151, 28);
            cbDonVi.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label7.Location = new Point(464, 182);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 63;
            label7.Text = "Đơn vị:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 175);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 62;
            label4.Text = "Loại:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(600, 128);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(235, 27);
            txtDonGia.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label6.Location = new Point(464, 132);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 61;
            label6.Text = "Đơn giá:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(156, 128);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(235, 27);
            txtSoLuong.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label3.Location = new Point(32, 129);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 64;
            label3.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label5.Location = new Point(464, 87);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 60;
            label5.Text = "Tên sản phẩm";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(156, 86);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(235, 27);
            txtMaSanPham.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label2.Location = new Point(32, 87);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 59;
            label2.Text = "Mã sản phẩm:";
            // 
            // dtSanPham
            // 
            dtSanPham.AllowUserToAddRows = false;
            dtSanPham.AllowUserToDeleteRows = false;
            dtSanPham.AllowUserToResizeRows = false;
            dtSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, Loai, SoLuong, DonGia, DonVi });
            dtSanPham.Location = new Point(32, 243);
            dtSanPham.MultiSelect = false;
            dtSanPham.Name = "dtSanPham";
            dtSanPham.RowHeadersWidth = 51;
            dtSanPham.Size = new Size(1258, 373);
            dtSanPham.TabIndex = 58;
            dtSanPham.CellClick += dtSanPham_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // Loai
            // 
            Loai.DataPropertyName = "Loai";
            Loai.HeaderText = "Loại";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(1035, 169);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 38);
            btnThoat.TabIndex = 57;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnHuy.Location = new Point(1035, 113);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 38);
            btnHuy.TabIndex = 56;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(1035, 63);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 36);
            btnLuu.TabIndex = 55;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnSua.Location = new Point(875, 113);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 38);
            btnSua.TabIndex = 54;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.OrangeRed;
            btnXoa.Location = new Point(875, 169);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 38);
            btnXoa.TabIndex = 53;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnThem.Location = new Point(875, 64);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 35);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(476, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 38);
            label1.TabIndex = 51;
            label1.Text = "Tiệm tóc nam Mable🍁";
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnTim.Location = new Point(1196, 61);
            btnTim.Margin = new Padding(4, 3, 4, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(125, 36);
            btnTim.TabIndex = 55;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnNhap.Location = new Point(1196, 111);
            btnNhap.Margin = new Padding(4, 3, 4, 3);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(125, 38);
            btnNhap.TabIndex = 56;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Cambria", 9F, FontStyle.Bold);
            btnXuat.Location = new Point(1196, 167);
            btnXuat.Margin = new Padding(4, 3, 4, 3);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(125, 38);
            btnXuat.TabIndex = 57;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Items.AddRange(new object[] { "Dầu gội", "", "", "Thuốc nhuộm", "", "", "Kem uốn", "", "", "Hấp phục hồi", "", "" });
            cbLoai.Location = new Point(156, 179);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(202, 28);
            cbLoai.TabIndex = 72;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(602, 82);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(233, 27);
            txtTenSanPham.TabIndex = 73;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 643);
            Controls.Add(txtTenSanPham);
            Controls.Add(cbLoai);
            Controls.Add(label8);
            Controls.Add(cbDonVi);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtDonGia);
            Controls.Add(label6);
            Controls.Add(txtSoLuong);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtMaSanPham);
            Controls.Add(label2);
            Controls.Add(dtSanPham);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnNhap);
            Controls.Add(btnTim);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dtSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox cbDonVi;
        private Label label7;
        private Label label4;
        private TextBox txtDonGia;
        private Label label6;
        private TextBox txtSoLuong;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label5;
        private TextBox txtMaSanPham;
        private Label label2;
        private DataGridView dtSanPham;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
        private Button btnTim;
        private Button btnNhap;
        private Button btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn DonVi;
        private ComboBox cbLoai;
        private TextBox txtTenSanPham;
    }
}