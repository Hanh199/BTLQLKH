using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLKH.Models
{
    [Table("TRANGCHUs")]
    public class TRANGCHU
    {
        [Key]
        public string MaTT { get; set; }
        [AllowHtml]
        public string Noidung { get; set; }
    }
}