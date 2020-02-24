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
        
        [Display (Name= "First name")]
        [Required(ErrorMessage = "Pet first name is required")]
        [StringLength(30)]
        public string ownerFirstName { get; set; }
       
        [Display(Name = "Last name")]
        [Required]
        [StringLength(30)]
        public string ownerLastName { get; set; }
        
        [Display(Name = "Email")]
        [Required]
        [StringLength(100)]
        public string ownerEmail { get; set; }
        
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",ErrorMessage ="Phone number must be in the format (xxx) xxx-xxxx")]
        public string ownerPhone { get; set; }
        public ICollection<Pets> Pets { get; set; }




    }
}