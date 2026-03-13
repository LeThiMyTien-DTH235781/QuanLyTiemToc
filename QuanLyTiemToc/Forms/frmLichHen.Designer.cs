namespace QuanLyTiemToc.Forms
{
    partial class frmLichHen
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
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtKhachHang = new TextBox();
            dateThoiGian = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboDichVu = new ComboBox();
            cboTrangThai = new ComboBox();
            TrangThai = new DataGridViewTextBoxColumn();
            ThoiGianHen = new DataGridViewTextBoxColumn();
            DichVu = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1224, 263);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách lịch hẹn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenNhanVien, TenKhachHang, DichVu, ThoiGianHen, TrangThai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1218, 237);
            dataGridView.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(1067, 217);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(141, 32);
            btnThoat.TabIndex = 81;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.Location = new Point(856, 217);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(141, 32);
            btnHuy.TabIndex = 80;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(646, 217);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(141, 31);
            btnLuu.TabIndex = 79;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(238, 216);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 32);
            btnSua.TabIndex = 78;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.OrangeRed;
            btnXoa.Location = new Point(441, 215);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 32);
            btnXoa.TabIndex = 77;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Location = new Point(31, 216);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 30);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(cboTrangThai);
            groupBox2.Controls.Add(cboDichVu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dateThoiGian);
            groupBox2.Controls.Add(txtKhachHang);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1221, 182);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin dịch vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(176, 34);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(269, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 126);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Thời gian hẹn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 81);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng:";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(175, 79);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(270, 27);
            txtKhachHang.TabIndex = 3;
            // 
            // dateThoiGian
            // 
            dateThoiGian.Format = DateTimePickerFormat.Short;
            dateThoiGian.Location = new Point(175, 126);
            dateThoiGian.Name = "dateThoiGian";
            dateThoiGian.Size = new Size(267, 27);
            dateThoiGian.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 42);
            label4.Name = "label4";
            label4.Size = new Size(13, 20);
            label4.TabIndex = 0;
            label4.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(688, 42);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "Dịch vụ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(688, 99);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái:";
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(819, 40);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(254, 28);
            cboDichVu.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(819, 96);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(254, 28);
            cboTrangThai.TabIndex = 6;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // ThoiGianHen
            // 
            ThoiGianHen.DataPropertyName = "ThoiGianHen";
            ThoiGianHen.HeaderText = "Thời gian hẹn";
            ThoiGianHen.MinimumWidth = 6;
            ThoiGianHen.Name = "ThoiGianHen";
            // 
            // DichVu
            // 
            DichVu.DataPropertyName = "DichVu";
            DichVu.HeaderText = "Dịch vụ";
            DichVu.MinimumWidth = 6;
            DichVu.Name = "DichVu";
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 530);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLichHen";
            Text = "frmLichHen";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView;
        private TextBox txtKhachHang;
        private DateTimePicker dateThoiGian;
        private ComboBox cboTrangThai;
        private ComboBox cboDichVu;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn DichVu;
        private DataGridViewTextBoxColumn ThoiGianHen;
        private DataGridViewTextBoxColumn TrangThai;
    }
}