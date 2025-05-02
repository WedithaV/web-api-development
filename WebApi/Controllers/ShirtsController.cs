using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Repositories;
using WebApi.Filters;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class ShirtsController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok(ShirtRepository.GetShirts());
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        public IActionResult PostShirt([FromBody]Shirt shirt)
        {
            if (shirt == null) return BadRequest();

            var existingShirt = ShirtRepository.GetShirtByProperties(shirt.Brand, shirt.Gender, shirt.Color, shirt.Size);
            if (existingShirt != null) return BadRequest();

            ShirtRepository.AddShirt(shirt);

            return CreatedAtAction(nameof(GetShirtById),
                new { id = shirt.ShirtId},
                shirt);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Delete the shirt id : {id}");
        }

        [HttpPut("{id}")]
        public IActionResult PutShirt(int id) {
            return Ok($"Updated shirt {id}");
        }
    }
}

