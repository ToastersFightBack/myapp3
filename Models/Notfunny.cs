using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace myapp.Models
{
    public class Notfunny
    {
        public int ID { get; set; }
        
        public int Price { get; set; }
       
        public string CableType { get; set; }
        


        public string Phone { get; set; }
    }
}