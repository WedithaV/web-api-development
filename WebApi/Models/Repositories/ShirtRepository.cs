
namespace WebApi.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>() {
            new Shirt {ShirtId = 1, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
            new Shirt {ShirtId = 2, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
            new Shirt {ShirtId = 3, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
            new Shirt {ShirtId = 4, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
        };

        public static List<Shirt> GetShirts()
        {
            return shirts;
        }

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x =>  x.ShirtId == id);
        }

        public static Shirt? GetShirtByProperties(string? brand, string? gender, string? color, int? size)
        {
            return shirts.FirstOrDefault(x => 
            !string.IsNullOrEmpty(brand) &&
            !string.IsNullOrWhiteSpace(x.Brand) &&
            x.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrEmpty(gender) &&
            !string.IsNullOrWhiteSpace(x.Gender) &&
            x.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrEmpty(color) &&
            !string.IsNullOrWhiteSpace(x.Color) &&
            x.Color.Equals(color, StringComparison.OrdinalIgnoreCase) &&
            size.HasValue &&
            x.Size.HasValue &&
            size.Value == x.Size.Value
            );
        }

        public static void AddShirt(Shirt shirt)
        {
            int maxId = shirts.Max(x => x.ShirtId);
            shirt.ShirtId = maxId + 1;

            shirts.Add(shirt);
        }
    }
}