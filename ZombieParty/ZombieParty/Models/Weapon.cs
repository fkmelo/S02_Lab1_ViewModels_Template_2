using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class Weapon
    {
        [StringLength(250, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(2500,MinimumLength = 0)]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Range(minimum:0, maximum:500)]
        public decimal Force { get; set; }

        [DataType(DataType.Currency)]
        [Range(minimum:0, maximum:100000,ErrorMessage = "The {0} has to be between {1} and {2}")]
        public decimal Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.ImageUrl)]
        public string? Image { get; set; }
        public int Qty { get; set; }

        [Display(Name = "Qyt Bought")]
        public int QtyBought { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var item = validationContext.ObjectInstance as Weapon;
            if (item == null) yield break;
            if (string.IsNullOrWhiteSpace(item.Description)) yield break;
            if (item.Description.Split(" ").Length <= 3)
                yield return new ValidationResult("Description needs to have more than 3 words please.", new[] { "Description" });
        }

    }

}
