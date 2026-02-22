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
        public decimal GiaDichVu { get; set; }
        public decimal ThanhTien { get; set; }
    }
    public class DanhSachHoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonId { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public short SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal GiaDichVu { get; set; }
    }
}
