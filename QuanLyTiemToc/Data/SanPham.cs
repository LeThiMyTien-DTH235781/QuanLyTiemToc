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

        [MaxLength(100)]
        public string Loai { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        [MaxLength(50)]
        public string DonVi { get; set; }
    }
}
