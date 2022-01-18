using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_Teknologji.NET.Models
{
    public class Makinat
    {
        [Required]
        [Display(Name = "IdMakine")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Modeli")]
        public string Modeli { get; set; }
        [Display(Name = "Pershkrimi")]
        public string Pershkrimi { get; set; }
        [Required]
        [Display(Name = "Viti i prodhimit")]
        public int Vit_Prodhimi { get; set; }
        [Required]
        [Display(Name = "Kostoja per 1 dite")]
        public decimal Kosto1Dite { get; set; }
        [Required]
        [Display(Name = "Imazhi 1")]
        public string IMG1 { get; set; }
        [Display(Name = "Imazhi 2")]
        public string IMG2 { get; set; }
        [Display(Name = "Imazhi 3")]
        public string IMG3 { get; set; }

        public int? TipiID { get; set; }
        public virtual Tipi Tipi { get; set; }

    }
}