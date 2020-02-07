using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jk582215_MIS4200_2.Models
{
    public class Pets
    {
        public int petId { get; set; }
        public string petType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhone { get; set; }
        public int MyProperty { get; set; }

        public DateTime patientSince { get; set; }


    }
}