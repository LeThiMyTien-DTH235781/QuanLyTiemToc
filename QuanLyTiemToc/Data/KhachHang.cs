using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTiemToc.Data
{
    public class KhachHang
    {
       
            public int KhachHangId { get; set; }
            public string HoTen { get; set; }
            public string DienThoai { get; set; }

            public int DichVuId { get; set; }   
            public DichVu DichVu { get; set; }  
        }

    }


}
