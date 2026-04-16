using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemToc.Forms
{
    public partial class frmDangNhap : Form
    {
        // Tài khoản và mật khẩu cố định
        private const string TENDANGNHAP_HOPLELH = "admin";
        private const string MATKHAU_HOPLE = "123";

        // Giới hạn số lần đăng nhập sai
        private int soLanSai = 0;
        private const int SO_LAN_SAI_TOI_DA = 3;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra để trống
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tài khoản và mật khẩu
            if (tenDangNhap == TENDANGNHAP_HOPLELH && matKhau == MATKHAU_HOPLE)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                soLanSai++;
                int conLai = SO_LAN_SAI_TOI_DA - soLanSai;

                if (soLanSai >= SO_LAN_SAI_TOI_DA)
                {
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần. Chương trình sẽ đóng!",
                        "Khóa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Tên đăng nhập hoặc mật khẩu không đúng!\nBạn còn {conLai} lần thử.",
                        "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
    }
}
