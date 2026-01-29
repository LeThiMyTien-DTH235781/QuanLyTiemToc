using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
{
    public class SanPham
    {
        [Key] 
        public int SanPhamId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenSanPham { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuongTon { get; set; }

        [MaxLength(200)]
        public string MoTa { get; set; }
    }
}
