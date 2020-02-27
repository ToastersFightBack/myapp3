using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myapp.Models
{
    public class Funny
    {
        public int ID { get; set; }
       
        public string VeryGood { get; set; }
    
        public string Mouse { get; set; }
        public string Headphones { get; set; }

        public int junk3 { get; set; }
    }
}