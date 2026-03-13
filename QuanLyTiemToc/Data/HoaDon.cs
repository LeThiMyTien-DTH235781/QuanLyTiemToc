using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
{
    public class HoaDon
    {
        [Key] 
        public int HoaDonId { get; set; }

        public DateTime NgayLap { get; set; }

        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }

        public decimal TongTien { get; set; }

        // Navigation
        public ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
<<<<<<< HEAD
    }
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public string HoVaTenNhanVien { get; set; }
        public string HoVaTenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
=======
>>>>>>> 0fc5df7a333d3d51b76e14b01f90ba3a6771178a
    }
}
