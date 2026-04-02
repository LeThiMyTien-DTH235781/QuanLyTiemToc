namespace QuanLyTiemToc.Forms
{
    partial class frmHoaDon
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
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnInHoaDon = new Button();
            btnLapHoaDon = new Button();
            ID = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1369, 332);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenNhanVien, TenKhachHang, NgayLap, TongTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 21);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1363, 308);
            dataGridView.TabIndex = 0;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnXuat.ForeColor = Color.Teal;
            btnXuat.Location = new Point(1208, 378);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(137, 51);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.Teal;
            btnTimKiem.Location = new Point(1041, 378);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(117, 51);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm..";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Teal;
            btnThoat.Location = new Point(858, 378);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 51);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Firebrick;
            btnXoa.Location = new Point(678, 378);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 51);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.Teal;
            btnSua.Location = new Point(489, 378);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 51);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.Teal;
            btnInHoaDon.Location = new Point(293, 378);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(136, 51);
            btnInHoaDon.TabIndex = 7;
            btnInHoaDon.Text = "In hóa đơn..";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.Teal;
            btnLapHoaDon.Location = new Point(35, 378);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(210, 51);
            btnLapHoaDon.TabIndex = 8;
            btnLapHoaDon.Text = "Lập hóa đơn mới..🔍";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1402, 522);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnInHoaDon;
        private Button btnLapHoaDon;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
    }
}