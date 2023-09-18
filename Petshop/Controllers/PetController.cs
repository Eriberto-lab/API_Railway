using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Petshop.Models;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        public static List<Pet> pets = new List<Pet>();

        [HttpPost]
        public IActionResult AddPet([FromBody] Pet pet)
        {
            pets.Add(pet);

            return Created("pets", pet);
        }

        [HttpGet]
        public IActionResult GetPets()
        {
            return Ok(pets);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Pet pet = pets.FirstOrDefault(element => element.Id == id);
            if (pet == null)
            {
                return NotFound("Id não encontrado");
            }

            return Ok(pet);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            Pet pet = pets.FirstOrDefault(element => element.Id == id);
            if (pet == null)
            {
                return NotFound("Id não encontrado");
            }

            bool isRemoved = pets.Remove(pet);

            if (isRemoved)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}