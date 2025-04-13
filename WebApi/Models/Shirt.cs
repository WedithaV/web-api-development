using System.ComponentModel.DataAnnotations;
using WebApi.Models.Validations;

namespace WebApi.Models
{
    public class Shirt
    {
        [Required]
        public int ShirtId { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Color { get; set; }

        [Shirt_CorrectSizing]
        public int? Size { get; set; }

        [Required]
        public string? Gender { get; set; }

        public double? Prize { get; set; }
    }
}