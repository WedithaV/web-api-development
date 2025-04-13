
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
    }
}