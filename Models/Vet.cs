using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jk582215_MIS4200_2.Models
{
    public class Vet
    {
      [Key]
        public int vetId { get; set; }
        
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Vet first name is required")]
        [StringLength(20)]
        public string vetFirstName { get; set; }
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Vet last name is required")]
        [StringLength(20)]
        public string vetLastName { get; set; }
        public ICollection<Pets> Pets { get; set; }
    }
}