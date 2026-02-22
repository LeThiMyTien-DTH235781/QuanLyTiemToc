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
    }
}
