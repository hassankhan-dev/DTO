using AutoMapper;
using DTO.AutoMapper;
using DTO.DTO;
using DTO.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DTO.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class MainController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public MainController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;

        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            var allCategories = await dbContext.Categories.ToListAsync();
            var allLocations = await dbContext.Locations.ToListAsync();
            var allBreeds = await dbContext.Breeds.ToListAsync();
            var allPets = await dbContext.Pets.ToListAsync();

            
            var responseData = new
            {
                Categories = allCategories,
                Locations = allLocations,
                Breeds = allBreeds,
                Pets = allPets
            };

            return Ok(responseData);
        }

        [HttpPost("location")]

        public async Task<IActionResult> Add(LocationDto locationPayload)
        {
            var location = mapper.Map<Location>(locationPayload);
            dbContext.Locations.Add(location);
            this.dbContext.SaveChanges();
            return Created($"/{location.LID}", location);
        }

        [HttpPost("category")]

        public async Task<IActionResult> Add(CategoryDto CategoryPayload)
        {
            if (CategoryPayload == null)
            {
                return BadRequest("Invalid data");
            }

            var category = mapper.Map<Category>(CategoryPayload);
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();

            return Created($"/{category.CId}", category);
        }

        [HttpPost("Breed")]

        public async Task<IActionResult> Add(BreedDto BreedPayload)
        {
            if (BreedPayload == null)
            {
                return BadRequest("Invalid data");
            }

            var breed = mapper.Map<Breed>(BreedPayload);
            dbContext.Breeds.Add(breed);
            dbContext.SaveChanges();

            return Created($"/{breed.BId}", breed);
        }

        [HttpPost("Pet")]

        public async Task<IActionResult> Add(PetDto PetPayload)
        {
            if (PetPayload == null)
            {
                return BadRequest("Invalid data");
            }

            var pet = mapper.Map<Pet>(PetPayload);
            dbContext.Pets.Add(pet);
            dbContext.SaveChanges();

            return Created($"/{pet.PId}", pet);
        }
    }
}
