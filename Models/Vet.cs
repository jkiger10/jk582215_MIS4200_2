using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jk582215_MIS4200_2.Models
{
    public class Vet
    {
      
        public int vetId { get; set; }
        public string vetFirstName { get; set; }
        public string vetLastName { get; set; }
        public ICollection<Pets> Pets { get; set; }
    }
}