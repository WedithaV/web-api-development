using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Repositories;
using WebApi.Filters;
using WebApi.Filters.ActionFilters;
using WebApi.Filters.ExceptionFilters;

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
        [Shirt_ValidateCreateShirtFilter]
        public IActionResult PostShirt([FromBody]Shirt shirt)
        {
            ShirtRepository.AddShirt(shirt);

            return CreatedAtAction(nameof(GetShirtById),
                new { id = shirt.ShirtId},
                shirt);
        }


        [HttpDelete("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult DeleteShirt(int id)
        {
            var shirt = ShirtRepository.GetShirtById(id);
            ShirtRepository.DeleteShirt(id);

            return Ok(shirt);
        }

        [HttpPut("{id}")]
        [Shirt_ValidateShirtIdFilter]
        [Shirt_ValidateUpdateShirtFilter]
        [Shirt_UpdateExceptionFilter]
        public IActionResult PutShirt(int id, Shirt shirt) {

                ShirtRepository.UpdateShirt(shirt);
            
            return NoContent();
        }
    }
}

