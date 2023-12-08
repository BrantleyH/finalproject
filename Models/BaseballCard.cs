using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class BaseballCard
    {
        public int BaseballCardID {get; set;} //Primary Key

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name {get; set;} = string.Empty;

        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string CardPackage {get; set;} = string.Empty;

        [StringLength(30)]
        [Required]
        public string CardType {get; set;} = string.Empty;

        [StringLength(5)]
        [Required]
        public string CardNumber {get; set;} = string.Empty;

        [StringLength(5)]
        [Required]
        public string CardCondition {get; set;} = string.Empty;

        [Range(1,100)]
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price {get; set;}

        public List<Owner> Owners {get; set;} = new List<Owner>();

    }
}