using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
    {
        public class NhanVien
        {
            [Key]
            public int NhanVienId { get; set; }

            [Required]
            public string HoTen { get; set; }

            public string DienThoai { get; set; }

            public string DiaChi { get; set; }

            [Required]
            public string TenDangNhap { get; set; }

            [Required]
            public string MatKhau { get; set; }

            public string ChuyenMon { get; set; }
        }
    }

