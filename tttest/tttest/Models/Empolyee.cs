using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tttest.Models
{
    public class Empolyee
    {
        [Key]
        public int id { get; set; }
        public string Employname { get; set; }
        public string EmployAdress { get; set; }
        public string department { get; set; }
        public bool status { get; set; }
        public DateTime dateofb { get; set; }
    }
}
