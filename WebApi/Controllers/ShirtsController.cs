﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Read all shirts";
        }

        [HttpGet("{id}")]
        public string GetShirtById(int id)
        {
            return $"Read shirt {id}";
        }

        [HttpPost]
        public string PostShirt()
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

