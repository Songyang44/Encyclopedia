using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly StoreContext _context;
        public PetsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetPets(){
            var pets=await _context.Pet.ToListAsync();
            return pets;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(int id){
            return await _context.Pet.FindAsync(id);
        }

    }
}