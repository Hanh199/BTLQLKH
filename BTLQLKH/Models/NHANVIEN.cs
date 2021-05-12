using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("NHANVIENs")]
    public class NHANVIEN
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaNV { get; set; }
        [Required, MaxLength(50)]
        public string TenNV { get; set; }
        public string Vitrilamviec { get; set; }
        public string GioiTinh { get; set; }
        [Required, MaxLength(100)]
        public string Diachi { get; set; }
        public int SĐT { get; set; }
        public virtual ICollection<HDNHAP> HDNHAPs { get; set; }
        public virtual ICollection<HDXUAT> HDXUATs { get; set; }
    }
}