using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CvEntityCoreMvc.Models.Sinflar
{
    public class Yetenekler
    {
        [Key]
        public int id { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }
    }
}