using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_Teknologji.NET.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Required(ErrorMessage = "Ju lutem plotesoni fushen!")]
        public string Emri { get; set; }
        [Required(ErrorMessage = "Ju lutem plotesoni fushen!")]
        public string Email { get; set; }
        public string Subjekti { get; set; }
        [Required(ErrorMessage = "Shkruani mesazhin tuaj!")]
        public string Mesazhi { get; set; }
    }
}