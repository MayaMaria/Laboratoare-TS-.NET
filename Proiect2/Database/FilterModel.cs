
using System.Collections.Generic;

namespace Database
{
    public class FilterModel
    {
        public string Type { get; set; }
        public string Event { get; set; }
        public string Landscape { get; set; }
        public string Country { get; set; }
        public int? Year { get; set; }
        public List<string> Persons { get; set; }
    }
}
