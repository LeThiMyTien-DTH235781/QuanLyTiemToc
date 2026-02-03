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
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dtKhachHang
            // 
            dtKhachHang.AllowUserToAddRows = false;
            dtKhachHang.AllowUserToDeleteRows = false;
            dtKhachHang.AllowUserToOrderColumns = true;
            dtKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtKhachHang.Location = new Point(29, 258);
            dtKhachHang.Margin = new Padding(4, 3, 4, 3);
            dtKhachHang.Name = "dtKhachHang";
            dtKhachHang.RowHeadersWidth = 51;
            dtKhachHang.Size = new Size(1397, 356);
            dtKhachHang.TabIndex = 28;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1222, 190);
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
            btnHuy.Location = new Point(976, 190);
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
            btnLuu.Location = new Point(743, 190);
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
            btnSua.Location = new Point(493, 190);
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
            btnXoa.Location = new Point(273, 190);
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
            btnThem.Location = new Point(29, 190);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 44);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(186, 133);
            txtSDT.Margin = new Padding(4, 3, 4, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(254, 27);
            txtSDT.TabIndex = 17;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(924, 79);
            txtTenKH.Margin = new Padding(4, 3, 4, 3);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(364, 27);
            txtTenKH.TabIndex = 16;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(183, 81);
            txtMaKH.Margin = new Padding(4, 3, 4, 3);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(258, 27);
            txtMaKH.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 81);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 12;
            label5.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(52, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 27);
            label2.TabIndex = 10;
            label2.Text = "Thông Tin Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(605, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 31);
            label1.TabIndex = 9;
            label1.Text = "Tiệm tóc nam Mable🍁";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(771, 145);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 13;
            label6.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(924, 139);
            txtDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(254, 27);
            txtDiaChi.TabIndex = 17;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1683, 626);
            Controls.Add(dtKhachHang);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(label6);
            Controls.Add(txtMaKH);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtKhachHang).EndInit();
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
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtDiaChi;
    }
}