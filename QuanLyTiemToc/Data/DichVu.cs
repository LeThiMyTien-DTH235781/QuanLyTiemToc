using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
{
    public class DichVu
    {

        [Key]
        public int DichVuId { get; set; }

        [Required]
        public string TenDichVu { get; set; }

        [Required]
        public decimal Gia { get; set; }

        public int ThoiGian { get; set; }


    }
}
