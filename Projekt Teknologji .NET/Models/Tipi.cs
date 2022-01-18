using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_Teknologji.NET.Models
{
    public class Tipi
    {
        [Required]
        public int ID{ get; set; }

        [Required]
        [Display(Name = "Emri")]
        public string Emri { get; set; }
        [Required]
        [Display(Name = "Ikona")]
        public string Ikona { get; set; }
    }
}