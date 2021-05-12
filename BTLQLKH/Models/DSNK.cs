using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("DSNKs")]
    public class DSNK
    {
        [Key]
        public string Sophieunhap { get; set; }
        [Required, MaxLength(10)]
        public string MaHDN { get; set; }
        [Required, MaxLength(10)]
        public string MaKho { get; set; }
        public string TenMH { get; set; }
        [Required]
        public string TenNCC { get; set; }
        public float Soluongnhap { get; set; }
        public float Gianhap { get; set; }
        public string Ngaynhap { get; set; }
        [Required, MaxLength(50)]
        public string Nhanviennhap { get; set; }

        public virtual MATHANG MATHANGs { get; set; }
        public virtual KHOHANG KHOHANGs { get; set; }
        public virtual HDNHAP HDNHAPs { get; set; }

    }
}