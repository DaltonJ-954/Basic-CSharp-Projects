using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonDbContext context;

        public PokemonController(PokemonDbContext context)
        {
            this.context = context;
        }

        // GET: api/pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemons()
        {
            var pokemons = await context.Pokemons
                .Include(p => p.PokemonCategories)
                    .ThenInclude(pc => pc.Category)
                .Include(p => p.PokemonOwners)
                    .ThenInclude(po => po.Owner)
                .Include(p => p.Reviews)
                    .ThenInclude(r => r.Reviewer)
                .ToListAsync();

            return Ok(pokemons);
        }

        // GET: api/pokemon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
            var pokemon = await context.Pokemons
                .Include(p => p.PokemonCategories)
                    .ThenInclude(pc => pc.Category)
                .Include(p => p.PokemonOwners)
                    .ThenInclude(po => po.Owner)
                .Include(p => p.Reviews)
                    .ThenInclude(r => r.Reviewer)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pokemon == null)
                return NotFound();

            return Ok(pokemon);
        }

        // GET: api/pokemon/{id}/rating
        [HttpGet("{id}/rating")]
        public async Task<ActionResult<double>> GetPokemonRating(int id)
        {
            var pokemonExists = await context.Pokemons.AnyAsync(p => p.Id == id);

            if (!pokemonExists)
                return NotFound();

            var rating = await context.Reviews
                .Where(r => r.Pokemon.Id == id)
                .Select(r => r.Rating)
                .DefaultIfEmpty()
                .AverageAsync();

            return Ok(rating);
        }

        // POST: api/pokemon
        [HttpPost]
        public async Task<ActionResult<Pokemon>> CreatePokemon([FromBody] Pokemon pokemon)
        {
            if (pokemon == null)
                return BadRequest();

            context.Pokemons.Add(pokemon);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPokemon), new { id = pokemon.Id }, pokemon);
        }

        // PUT: api/pokemon/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePokemon(int id, [FromBody] Pokemon updatedPokemon)
        {
            if (id != updatedPokemon.Id)
                return BadRequest();

            var exists = await context.Pokemons.AnyAsync(p => p.Id == id);
            if (!exists)
                return NotFound();

            context.Entry(updatedPokemon).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/pokemon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            var pokemon = await context.Pokemons.FindAsync(id);

            if (pokemon == null)
                return NotFound();

            context.Pokemons.Remove(pokemon);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
