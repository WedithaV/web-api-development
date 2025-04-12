using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class ShirtsController : ControllerBase
    {
        private List<Shirt> shirts = new List<Shirt>() {
            new Shirt {ShirtId = 1, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
            new Shirt {ShirtId = 2, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
            new Shirt {ShirtId = 3, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
            new Shirt {ShirtId = 4, Brand = "My Brand", Color = "black",Gender = "Men",Prize = 34.23, Size = 9},
        };

        [HttpGet]
        public string GetShirts()
        {
            return "Read all shirts";
        }

        [HttpGet("{id}")]
        public IActionResult GetShirtById(int id)
        {
            if(id < 0)
            {
                return BadRequest();
            }

            var shirt = shirts.FirstOrDefault(x => x.ShirtId == id);
            if(shirt == null)
            {
                return NotFound();
            }
            return Ok(shirt);
        }

        [HttpPost]
        public string PostShirt([FromBody]Shirt shirt)
        {
            return "Created a shirt";
        }


        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleted shirt {id}";
        }

        [HttpPut("{id}")]
        public string PutShirt(int id) {
            return $"Updated shirt {id}";
        }
    }
}

