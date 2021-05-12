using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("DSXKs")]
    public class DSXK
    {
        [Key]
        public string Sophieuxuat { get; set; }
        [Required, MaxLength(10)]
        public string MaHDX { get; set; }
        [Required, MaxLength(10)]
        public string MaKho { get; set; }
        public string TenMH { get; set; }
        [Required]
        public string TenKH { get; set; }
        public float Soluongban { get; set; }
        public float Giaban { get; set; }
        public string Ngayxuat { get; set; }
        [Required, MaxLength(50)]
        public string Nhanvienxuat { get; set; }
        public virtual MATHANG MATHANGs { get; set; }
        public virtual KHOHANG KHOHANGs { get; set; }
        public virtual HDXUAT HDXUATs { get; set; }

    }
}