using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jk582215_MIS4200_2.Models
{
    public class Pets
    {
        [Key]
        public int petId { get; set; }
        public string petType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime lastVisit { get; set; }
        public PetOwner PetOwner { get; set; }
       
        public Vet Vet { get; set; }

    }
}