using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_codefirst.Models
{
    public class Person
    {
        [Key]
        public int id_person { get; set; }
        public int id_object { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
    }
}
