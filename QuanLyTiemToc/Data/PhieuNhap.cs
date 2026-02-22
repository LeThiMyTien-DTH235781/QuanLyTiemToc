using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemToc.Data
{
    public class PhieuNhap
    {
        [Key]
        public int PhieuNhapId { get; set; }

        public DateTime NgayNhap { get; set; }

        public string GhiChu { get; set; }
    }
}
