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
            cbDonVi = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtMaSanPham = new TextBox();
            label2 = new Label();
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
            cboSanPham = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            dtSanPham = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            SanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtSanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbDonVi
            // 
            cbDonVi.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Items.AddRange(new object[] { "Chai", "Hộp", "Tuýp", "Gói" });
            cbDonVi.Location = new Point(577, 99);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(151, 25);
            cbDonVi.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            label7.Location = new Point(441, 108);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 63;
            label7.Text = "Đơn vị:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            label6.Location = new Point(441, 58);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 61;
            label6.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            label3.Location = new Point(22, 127);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 64;
            label3.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            label5.Location = new Point(22, 27);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 60;
            label5.Text = " Tên sản phẩm:";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            txtMaSanPham.Location = new Point(145, 77);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(235, 23);
            txtMaSanPham.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 59;
            label2.Text = "Mã sản phẩm:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnThoat.Location = new Point(983, 133);
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
            btnHuy.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnHuy.Location = new Point(983, 77);
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
            btnLuu.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(983, 27);
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
            btnSua.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnSua.Location = new Point(823, 77);
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
            btnXoa.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnXoa.ForeColor = Color.OrangeRed;
            btnXoa.Location = new Point(823, 133);
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
            btnThem.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnThem.Location = new Point(823, 28);
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
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(478, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 46);
            label1.TabIndex = 51;
            label1.Text = "Tiệm tóc nam Mable🍁";
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnTim.Location = new Point(1144, 26);
            btnTim.Margin = new Padding(4, 3, 4, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(125, 36);
            btnTim.TabIndex = 55;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnNhap.Location = new Point(1144, 75);
            btnNhap.Margin = new Padding(4, 3, 4, 3);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(125, 38);
            btnNhap.TabIndex = 56;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnXuat.Location = new Point(1144, 131);
            btnXuat.Margin = new Padding(4, 3, 4, 3);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(125, 38);
            btnXuat.TabIndex = 57;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(145, 23);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(233, 25);
            cboSanPham.TabIndex = 73;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // numDonGia
            // 
            numDonGia.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            numDonGia.Location = new Point(577, 50);
            numDonGia.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 23);
            numDonGia.TabIndex = 74;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            numSoLuong.Location = new Point(145, 127);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 23);
            numSoLuong.TabIndex = 75;
            numSoLuong.ThousandsSeparator = true;
            // 
            // dtSanPham
            // 
            dtSanPham.AllowUserToAddRows = false;
            dtSanPham.AllowUserToDeleteRows = false;
            dtSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtSanPham.BackgroundColor = Color.Gainsboro;
            dtSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, SanPham, SoLuong, DonVi, DonGia });
            dtSanPham.Dock = DockStyle.Fill;
            dtSanPham.Location = new Point(3, 21);
            dtSanPham.Name = "dtSanPham";
            dtSanPham.RowHeadersWidth = 51;
            dtSanPham.Size = new Size(1310, 267);
            dtSanPham.TabIndex = 76;
            dtSanPham.SelectionChanged += dtSanPham_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // SanPham
            // 
            SanPham.DataPropertyName = "SanPham";
            SanPham.HeaderText = "Sản phẩm";
            SanPham.MinimumWidth = 6;
            SanPham.Name = "SanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtSanPham);
            groupBox1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1316, 291);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(cbDonVi);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaSanPham);
            groupBox2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1313, 182);
            groupBox2.TabIndex = 78;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1334, 555);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbDonVi;
        private Label label7;
        private Label label6;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label5;
        private TextBox txtMaSanPham;
        private Label label2;
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
        private ComboBox cboSanPham;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private DataGridView dtSanPham;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn DonGia;
        private GroupBox groupBox2;
    }
}