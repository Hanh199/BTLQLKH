using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("MATHANGs")]
    public class MATHANG
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaMH { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        public float SLton { get; set; }
        public string DVT { get; set; }
        public string Gianhap { get; set; }
        [Required, MaxLength(10)]
        public string MaNCC { get; set; }
        [Required, MaxLength(10)]
        public string MaKho { get; set; }
        public string Ghichu { get; set; }
        public virtual ICollection<DSNK> DSNKs { get; set; }
        public virtual ICollection<DSXK> DSXKs { get; set; }
        public virtual KHOHANG KHOHANGs { get; set; }
    }
}