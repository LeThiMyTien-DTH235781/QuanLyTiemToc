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

        [ForeignKey("KhachHang")]
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }

        [ForeignKey("NhanVien")]
        public int NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }

        [ForeignKey("DichVu")]
        public int DichVuId { get; set; }
        public DichVu DichVu { get; set; }

        public DateTime ThoiGianHen { get; set; }

        public string TrangThai { get; set; }
    }
}
