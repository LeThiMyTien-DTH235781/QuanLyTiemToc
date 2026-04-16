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
            dtNhanVien = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label7 = new Label();
            cbChuyenMon = new ComboBox();
            cboHoTen = new ComboBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            NhanVienId = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            ChuyenMon = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Teal;
            btnThoat.Location = new Point(981, 218);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(141, 38);
            btnThoat.TabIndex = 43;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.Teal;
            btnHuy.Location = new Point(786, 218);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(141, 38);
            btnHuy.TabIndex = 42;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Teal;
            btnLuu.Location = new Point(592, 219);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(141, 36);
            btnLuu.TabIndex = 41;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.Teal;
            btnSua.Location = new Point(406, 218);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 38);
            btnSua.TabIndex = 40;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Firebrick;
            btnXoa.Location = new Point(220, 218);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 38);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.Teal;
            btnThem.Location = new Point(38, 220);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 35);
            btnThem.TabIndex = 38;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtNhanVien
            // 
            dtNhanVien.AllowUserToAddRows = false;
            dtNhanVien.AllowUserToDeleteRows = false;
            dtNhanVien.AllowUserToResizeRows = false;
            dtNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtNhanVien.BackgroundColor = Color.Gainsboro;
            dtNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtNhanVien.Columns.AddRange(new DataGridViewColumn[] { NhanVienId, HoTen, DienThoai, DiaChi, ChuyenMon });
            dtNhanVien.Location = new Point(14, 272);
            dtNhanVien.MultiSelect = false;
            dtNhanVien.Name = "dtNhanVien";
            dtNhanVien.RowHeadersWidth = 51;
            dtNhanVien.Size = new Size(1146, 267);
            dtNhanVien.TabIndex = 46;
            dtNhanVien.CellClick += dtNhanVien_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label2.Location = new Point(53, 46);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 47;
            label2.Text = "Họ và Tên: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label3.Location = new Point(55, 101);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 47;
            label3.Text = "Điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            txtSDT.Location = new Point(179, 98);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(264, 25);
            txtSDT.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label4.Location = new Point(558, 46);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 47;
            label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            txtDiaChi.Location = new Point(735, 47);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(264, 25);
            txtDiaChi.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label7.Location = new Point(558, 101);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 47;
            label7.Text = "Chuyên môn:";
            // 
            // cbChuyenMon
            // 
            cbChuyenMon.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            cbChuyenMon.FormattingEnabled = true;
            cbChuyenMon.Items.AddRange(new object[] { "Thợ chính", "Thợ phụ" });
            cbChuyenMon.Location = new Point(735, 93);
            cbChuyenMon.Name = "cbChuyenMon";
            cbChuyenMon.Size = new Size(223, 28);
            cbChuyenMon.TabIndex = 49;
            // 
            // cboHoTen
            // 
            cboHoTen.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            cboHoTen.FormattingEnabled = true;
            cboHoTen.Location = new Point(179, 43);
            cboHoTen.Name = "cboHoTen";
            cboHoTen.Size = new Size(262, 28);
            cboHoTen.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(cboHoTen);
            groupBox1.Controls.Add(cbChuyenMon);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1146, 148);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(406, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 33);
            label1.TabIndex = 52;
            label1.Text = "Tiệm tóc nam Mable🍁";
            // 
            // NhanVienId
            // 
            NhanVienId.DataPropertyName = "NhanVienId";
            NhanVienId.HeaderText = "ID";
            NhanVienId.MinimumWidth = 6;
            NhanVienId.Name = "NhanVienId";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // ChuyenMon
            // 
            ChuyenMon.DataPropertyName = "ChuyenMon";
            ChuyenMon.HeaderText = "Chuyên môn";
            ChuyenMon.MinimumWidth = 6;
            ChuyenMon.Name = "ChuyenMon";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1195, 564);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dtNhanVien);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dtNhanVien;
        private Label label2;
        private Label label3;
        private TextBox txtSDT;
        private Label label4;
        private Label label7;
        private ComboBox cbChuyenMon;
        private ComboBox cboHoTen;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridViewTextBoxColumn NhanVienId;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn ChuyenMon;
    }
}