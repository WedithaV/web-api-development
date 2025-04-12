namespace WebApi.Models
{
    public class Shirt
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public double Prize { get; set; }
    }
}