using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemToc.Data
{
    public class KhuyenMai
    {
        [Key]
        public int KhuyenMaiId { get; set; }

        [Required]
        public string TenKhuyenMai { get; set; }

        public int PhanTramGiam { get; set; }

        public DateTime TuNgay { get; set; }

        public DateTime DenNgay { get; set; }
    }
}
