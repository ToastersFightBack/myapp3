using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myapp.Models
{
    [Table("Shinbreaker2")]
    public class Shinbreaker
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter the shinbreaker")]
        [StringLength(30, ErrorMessage = "Shinbreaker too long")]
        [Display(Name = "Yes ")]
        public string FunnyLevel { get; set; }
        [StringLength(20, ErrorMessage = "Too long ")]
        [Column("Joke")]
        [Display(Name = "Levelup")]
        public string Joke { get; set; }
        [Column("DateEnrolled")]
        [Display(Name = "Joke")]
        public int Rating { get; set; }

      
    }
}