using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jk582215_MIS4200_2.Models
{
    public class PetOwner
    {
       
        [Key]
        public int ownerId { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhone { get; set; }
        public ICollection<Pets> Pets { get; set; }




    }
}