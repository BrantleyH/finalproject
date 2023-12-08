using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Owner
    {
         // Primary Key for Review entity class
        public int OwnerID {get; set;}

        [StringLength(30)]
        [Required]
        public string Ownership {get; set;} = string.Empty;

        [Display(Name = "BaseballCard")]
        [Required]
        public int BaseballCardID {get; set;} // Foreign Key linking Review to Movie
        public BaseballCard? BaseballCard {get; set;}// Navigation Property
    }
}