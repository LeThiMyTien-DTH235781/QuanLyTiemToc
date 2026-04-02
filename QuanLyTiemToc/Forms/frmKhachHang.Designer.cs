namespace QuanLyTiemToc.Forms
{
    partial class frmKhachHang
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
            dtKhachHang = new DataGridView();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtKhachHang
            // 
            dtKhachHang.AllowUserToAddRows = false;
            dtKhachHang.AllowUserToDeleteRows = false;
            dtKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtKhachHang.Location = new Point(11, 20);
            dtKhachHang.Margin = new Padding(4, 3, 4, 3);
            dtKhachHang.Name = "dtKhachHang";
            dtKhachHang.RowHeadersWidth = 51;
            dtKhachHang.Size = new Size(1354, 243);
            dtKhachHang.TabIndex = 28;
            dtKhachHang.CellClick += dtKhachHang_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Teal;
            btnThoat.Location = new Point(1210, 223);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 44);
            btnThoat.TabIndex = 27;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.Teal;
            btnHuy.Location = new Point(964, 223);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(156, 44);
            btnHuy.TabIndex = 26;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Teal;
            btnLuu.Location = new Point(726, 223);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(156, 44);
            btnLuu.TabIndex = 25;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnSua.ForeColor = Color.Teal;
            btnSua.Location = new Point(491, 223);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(153, 44);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Firebrick;
            btnXoa.Location = new Point(261, 223);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(159, 44);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            btnThem.ForeColor = Color.Teal;
            btnThem.Location = new Point(37, 223);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(148, 44);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            txtSDT.ForeColor = SystemColors.HotTrack;
            txtSDT.Location = new Point(162, 85);
            txtSDT.Margin = new Padding(4, 3, 4, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(254, 25);
            txtSDT.TabIndex = 17;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            txtTenKH.Location = new Point(903, 38);
            txtTenKH.Margin = new Padding(4, 3, 4, 3);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(364, 25);
            txtTenKH.TabIndex = 16;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            txtMaKH.Location = new Point(162, 40);
            txtMaKH.Margin = new Padding(4, 3, 4, 3);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(258, 25);
            txtMaKH.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 92);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label5.Location = new Point(747, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 12;
            label5.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(580, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 33);
            label1.TabIndex = 9;
            label1.Text = "Tiệm tóc nam Mable🍁";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label6.Location = new Point(747, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 13;
            label6.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            txtDiaChi.Location = new Point(903, 85);
            txtDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(254, 25);
            txtDiaChi.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(29, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1338, 131);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtKhachHang);
            groupBox2.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold);
            groupBox2.Location = new Point(11, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1372, 248);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng ";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1434, 579);
            Controls.Add(groupBox2);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtKhachHang;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label6;
        private TextBox txtDiaChi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}