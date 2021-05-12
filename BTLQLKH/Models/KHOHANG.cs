using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("KHOHANGs")]
    public class KHOHANG
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaKho { get; set; }
        [Required, MaxLength(50)]
        public string Tenkho { get; set; }
        public int SDT { get; set; }
        [Required, MaxLength(100)]
        public string Diachi { get; set; }
        [Required, MaxLength(50)]
        public string Thukho { get; set; }
        public virtual ICollection<MATHANG> MATHANGSs { get; set; }
        public virtual ICollection<DSNK> DSNKs { get; set; }
        public virtual ICollection<DSXK> DSXKs { get; set; }


    }
}