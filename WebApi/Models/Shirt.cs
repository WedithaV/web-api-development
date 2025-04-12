namespace WebApi.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Color { get; set; }

        public int? Size { get; set; }

        [Required]
        public string? Gender { get; set; }

        public double? Prize { get; set; }
    }
}