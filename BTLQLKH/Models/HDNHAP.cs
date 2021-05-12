using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("HDNHAPs")]
    public class HDNHAP
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaHDN { get; set; }
        [Required, MaxLength(50)]
        public string TenHD { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        [Required]
        public string TenNCC { get; set; }
        public float Soluongnhap { get; set; }
        public float Gianhap { get; set; }
        public string Ngaynhap { get; set; }
        [Required, MaxLength(50)]
        public string Nhanviennhap{ get; set; }
        public virtual NHACUNGCAP NHACUNGCAPs { get; set; }
        public virtual NHANVIEN NHANVIENs { get; set; }
        public virtual ICollection<DSNK> DSNKs { get; set; }

    }
}