using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("KHACHHANGs")]
    public class KHACHHANG
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaKH { get; set; }
        [Required, MaxLength(50)]
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        [Required, MaxLength(100)]
        public string Diachi { get; set; }
        public int SĐT { get; set; }
        public virtual ICollection<HDXUAT> HDXUATs { get; set; }
    }
}