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
        
        [Display(Name = "Pet Type")]
        [Required]
        [StringLength(20)]
        public string petType { get; set; }
        
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Pet first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        
        [Display(Name = "Last name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
       
        [Display(Name = "Last visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime lastVisit { get; set; }
        public PetOwner PetOwner { get; set; }
       
        public Vet Vet { get; set; }

    }
}