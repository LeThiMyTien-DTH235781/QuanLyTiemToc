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
            txtMaKH.Enabled = false; // ID tự động
            txtTenKH.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            cbDichVu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
        }

        private void LoadDichVu()
        {
            var list = context.DichVu.ToList();

            list.Insert(0, new DichVu
            {
                DichVuId = 0,
                TenDichVu = "-- Chọn dịch vụ --"
            });

            cbDichVu.DataSource = list;
            cbDichVu.DisplayMember = "TenDichVu";
            cbDichVu.ValueMember = "DichVuId";
            cbDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDichVu.SelectedIndex = 0;
        }

        private void LoadKhachHang()
        {
            var data = context.KhachHang
                .Include(k => k.DichVu)
                .Select(k => new
                {
                    MaKhachHang = k.KhachHangId,
                    TenKhachHang = k.HoTen,
                    SoDienThoai = k.DienThoai,
                    DichVu = k.DichVu != null ? k.DichVu.TenDichVu : ""
                })
                .ToList();

            dtKhachHang.DataSource = data;
        }






        private void btnThem_Click(object sender, EventArgs e)
        {
          
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaKH.Text = "(Tự động)";
            txtTenKH.Clear();
            txtSDT.Clear();
            cbDichVu.SelectedIndex = -1;

            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0) return;

            var kh = context.KhachHang.Find(id);
            if (kh != null)
            {
                if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    LoadKhachHang();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                return;
            }

            if (cbDichVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ");
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    var kh = new KhachHang
                    {
                        HoTen = txtTenKH.Text.Trim(),
                        DienThoai = txtSDT.Text.Trim(),
                        DichVuId = (int)cbDichVu.SelectedValue
                    };

                    context.KhachHang.Add(kh);
                    context.SaveChanges(); // PHẢI SAVE TRƯỚC

                    txtMaKH.Text = kh.KhachHangId.ToString(); // LÚC NÀY ID MỚI CÓ
                }
                else
                {
                    var kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoTen = txtTenKH.Text.Trim();
                        kh.DienThoai = txtSDT.Text.Trim();
                        kh.DichVuId = (int)cbDichVu.SelectedValue;
                    }
                }

                context.SaveChanges();
                LoadKhachHang();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = Convert.ToInt32(dtKhachHang.Rows[e.RowIndex].Cells["MaKhachHang"].Value);

            txtMaKH.Text = id.ToString();
            txtTenKH.Text = dtKhachHang.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
            txtSDT.Text = dtKhachHang.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();

            var kh = context.KhachHang.Find(id);
            if (kh != null)
                cbDichVu.SelectedValue = kh.DichVuId;
        }
        

        private void frmKhachHang_Load_1(object sender, EventArgs e)
        {
            LoadDichVu();     
            LoadKhachHang();
            BatTatChucNang(false);
        }
    }
}
