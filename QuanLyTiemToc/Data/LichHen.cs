using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemToc.Data
{
    public class LichHen
    {
        [Key]
        public int LichHenId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenNhanVien { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKhachHang { get; set; }

        [Required]
        [MaxLength(100)]
        public string DichVu { get; set; }

        public DateTime ThoiGianHen { get; set; }

        [MaxLength(50)]
        public string TrangThai { get; set; }

       
    }
}
