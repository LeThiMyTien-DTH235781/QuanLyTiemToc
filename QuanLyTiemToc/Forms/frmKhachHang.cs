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
        int id = 0;
        bool them = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private string TaoMaKH()
        {
            int maxId = 0;

            if (context.KhachHang.Any())
            {
                maxId = context.KhachHang.Max(x => x.KhachHangId);
            }

            return "KH" + (maxId + 1).ToString("D3");
        }
        private void LoadData()
        {
            dtKhachHang.DataSource = context.KhachHang
                .OrderBy(x => x.KhachHangId)
                .ToList();

            dtKhachHang.Columns["KhachHangId"].HeaderText = "Mã KH";
            dtKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dtKhachHang.Columns["SDT"].HeaderText = "SĐT";
            dtKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";

            dtKhachHang.Columns["HoaDons"].Visible = false;

            dtKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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


            them = true;
            BatTatChucNang(true);

            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMaKH.Text = TaoMaKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Chọn khách hàng!");
                return;
            }

            var kh = context.KhachHang.Find(id);
            if (kh != null)
            {
                context.KhachHang.Remove(kh);
                context.SaveChanges();
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Chọn khách hàng!");
                return;
            }

            them = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Nhập tên!");
                return;
            }

            if (them)
            {
                context.KhachHang.Add(new KhachHang
                {
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text
                });
            }
            else
            {
                var kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.TenKH = txtTenKH.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                }
            }

            context.SaveChanges();
            LoadData();
            BatTatChucNang(false);
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            BatTatChucNang(false);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void frmKhachHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
            BatTatChucNang(false);
        }

        private void dtKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dtKhachHang.Rows[e.RowIndex];

            
            id = Convert.ToInt32(r.Cells["KhachHangId"].Value);
            txtMaKH.Text = "KH" + id.ToString("D3");
            txtTenKH.Text = r.Cells["TenKH"].Value?.ToString();
            txtSDT.Text = r.Cells["SDT"].Value?.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value?.ToString();
        }
       
    }
}

