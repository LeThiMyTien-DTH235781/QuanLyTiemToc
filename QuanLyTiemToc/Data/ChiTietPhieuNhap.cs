using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemToc.Data
{
    public class ChiTietPhieuNhap
    {
        [Key]
        public int ChiTietPhieuNhapId { get; set; }

        [ForeignKey("PhieuNhap")]
        public int PhieuNhapId { get; set; }
        public PhieuNhap PhieuNhap { get; set; }

        [ForeignKey("SanPham")]
        public int SanPhamId { get; set; }
        public SanPham SanPham { get; set; }

        public int SoLuong { get; set; }

        public decimal GiaNhap { get; set; }
    }
}
