using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]

    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        [Route("/shirts")]
        public string GetShirts()
        {
            return "Read all shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Read shirt {id}";
        }

        [HttpPost]
        [Route("/shirts")]
        public string PostShirt()
        {
            return "Created a shirt";
        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleted shirt {id}";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string PutShirt(int id) {
            return $"Updated shirt {id}";
        }
    }
}

