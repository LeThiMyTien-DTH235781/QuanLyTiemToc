using Microsoft.EntityFrameworkCore;
using QuanLyTiemToc.Data;
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
    public partial class frmKhachHang : Form
    {
        QLTiemTocDbContext context = new QLTiemTocDbContext();
        bool xuLyThem = false;
        int id = 0;
       

        public frmKhachHang()
        {
            InitializeComponent();
        }



        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenKH.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            
        }

        

        

        private void btnThem_Click(object sender, EventArgs e)
        {

            xuLyThem = true;
            BatTatChucNang(true);
            txtTenKH.Clear();
            txtSDT.Clear();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtTenKH.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dtKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();

                frmKhachHang_Load_1(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            xuLyThem = false;
            BatTatChucNang(true);
            txtTenKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.TenKH = txtTenKH.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Add(kh);

                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.TenKH = txtTenKH.Text;
                        kh.SDT = txtSDT.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHang.Update(kh);

                        context.SaveChanges();
                    }
                }

                frmKhachHang_Load_1(sender, e);
            }
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load_1(sender, e);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void frmKhachHang_Load_1(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", bindingSource, "TenKH", false, DataSourceUpdateMode.Never);

            // Tương tự cho txtDienThoai và txtDiaChi 

            dtKhachHang.DataSource = bindingSource;
        }
    }
}

