using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_codefirst.Models
{
    public class Item
    {
        [Key]
        public int id_object { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string path { get; set; }
        public string event_ { get; set; }
        public string landscape { get; set; }
        public string country { get; set; }
        public DateTime date_created { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
