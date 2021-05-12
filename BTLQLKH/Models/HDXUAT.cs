using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("HDXUATs")]
    public class HDXUAT
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaHDX { get; set; }
        [Required, MaxLength(50)]
        public string TenHDX { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        [Required, MaxLength(10)]
        public string TenKH { get; set; }
        public float Soluongxuat { get; set; }
        public float Giaban { get; set; }
        public string Ngayxuat { get; set; }
        [Required, MaxLength(50)]
        public string Nhanvienxuat { get; set; }
        public virtual KHACHHANG KHACHHANGs { get; set; }
        public virtual NHANVIEN NHANVIENs { get; set; }
        public virtual ICollection<DSXK> DSXKs { get; set; }
    }
}