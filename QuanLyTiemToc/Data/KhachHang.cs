using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
{
    public class KhachHang
    {

        [Key]  // Thêm [Key] attribute
        public int KhachHangId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKH { get; set; }

        [MaxLength(15)]
        public string SDT { get; set; }

        [MaxLength(200)]
        public string DiaChi { get; set; }
    }

}



