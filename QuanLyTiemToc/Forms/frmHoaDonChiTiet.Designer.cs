namespace QuanLyTiemToc.Forms
{
    partial class frmHoaDonChiTiet
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
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            groupBox2 = new GroupBox();
            cboKhachHang = new ComboBox();
            numGiaDichVu = new NumericUpDown();
            cboNhanVien = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            cboDichVu = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            btnXoa = new Button();
            cboSanPham = new ComboBox();
            btnXacNhanBan = new Button();
            numSoLuongBan = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            TenDichVu = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaDichVu).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(864, 475);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 35);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.Teal;
            btnInHoaDon.Location = new Point(589, 475);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(119, 35);
            btnInHoaDon.TabIndex = 5;
            btnInHoaDon.Text = "In hóa đơn..";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.BackColor = SystemColors.ButtonHighlight;
            btnLuuHoaDon.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnLuuHoaDon.ForeColor = Color.RoyalBlue;
            btnLuuHoaDon.Location = new Point(305, 475);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(144, 35);
            btnLuuHoaDon.TabIndex = 6;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(cboKhachHang);
            groupBox2.Controls.Add(numGiaDichVu);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboDichVu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(14, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1270, 124);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(183, 87);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 28);
            cboKhachHang.TabIndex = 7;
            // 
            // numGiaDichVu
            // 
            numGiaDichVu.ForeColor = SystemColors.HotTrack;
            numGiaDichVu.Location = new Point(848, 66);
            numGiaDichVu.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numGiaDichVu.Name = "numGiaDichVu";
            numGiaDichVu.Size = new Size(150, 25);
            numGiaDichVu.TabIndex = 6;
            numGiaDichVu.ThousandsSeparator = true;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(181, 39);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(252, 28);
            cboNhanVien.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(680, 72);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 4;
            label7.Text = "Giá(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(680, 29);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 4;
            label2.Text = "Dịch vụ(*):";
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(848, 26);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(314, 28);
            cboDichVu.TabIndex = 3;
            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 84);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 0;
            label6.Text = "Khách hàng(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 39);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập(*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(cboSanPham);
            groupBox1.Controls.Add(btnXacNhanBan);
            groupBox1.Controls.Add(numSoLuongBan);
            groupBox1.Controls.Add(numDonGiaBan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1270, 312);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenNhanVien, TenKhachHang, TenDichVu, TenSanPham, ThanhTien });
            dataGridView.Location = new Point(16, 99);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1243, 207);
            dataGridView.TabIndex = 5;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(1124, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(14, 55);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(393, 28);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.ForeColor = Color.Teal;
            btnXacNhanBan.Location = new Point(924, 40);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(178, 40);
            btnXacNhanBan.TabIndex = 4;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.ForeColor = SystemColors.HotTrack;
            numSoLuongBan.Location = new Point(686, 53);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(190, 25);
            numSoLuongBan.TabIndex = 3;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.ForeColor = SystemColors.HotTrack;
            numDonGiaBan.Location = new Point(436, 54);
            numDonGiaBan.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(190, 25);
            numDonGiaBan.TabIndex = 3;
            numDonGiaBan.ThousandsSeparator = true;
            numDonGiaBan.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(686, 28);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 0;
            label5.Text = "Số lượng (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 29);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Đơn giá(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 0;
            label3.Text = "Sản phẩm(*):";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // TenDichVu
            // 
            TenDichVu.DataPropertyName = "TenDichVu";
            TenDichVu.HeaderText = "Dịch vụ";
            TenDichVu.MinimumWidth = 6;
            TenDichVu.Name = "TenDichVu";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // frmHoaDonChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1344, 522);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "frmHoaDonChiTiet";
            Load += frmHoaDonChiTiet_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaDichVu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private GroupBox groupBox2;
        private Label label6;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private Button btnXoa;
        private ComboBox cboSanPham;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboDichVu;
        private ComboBox cboNhanVien;
        private NumericUpDown numGiaDichVu;
        private Label label7;
        private ComboBox cboKhachHang;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}