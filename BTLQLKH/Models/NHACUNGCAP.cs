using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLQLKH.Models
{
    [Table("NHACUNGCAPs")]
    public class NHACUNGCAP
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaNCC { get; set; }
        [Required]
        public string TenNCC { get; set; }
        [Required, MaxLength(100)]
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public virtual ICollection<HDNHAP> HDNHAPs { get; set; }

    }
}