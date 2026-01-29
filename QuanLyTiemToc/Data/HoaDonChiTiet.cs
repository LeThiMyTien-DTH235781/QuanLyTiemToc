using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
{
    public class HoaDonChiTiet
    {
        [Key] 
        public int HoaDonChiTietId { get; set; }

        public int HoaDonId { get; set; }
        public HoaDon HoaDon { get; set; }

        public int? DichVuId { get; set; }
        public DichVu DichVu { get; set; }

        public int? SanPhamId { get; set; }
        public SanPham SanPham { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;
    }
}
