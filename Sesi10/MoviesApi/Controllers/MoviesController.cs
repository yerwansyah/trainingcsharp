using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApi.Data;
using MoviesApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MoviesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MoviesController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _context.Movies.ToListAsync();

            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMovie", new { data.Id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieData movie)
        {
            if (id != movie.Id)
                return BadRequest();

            var existMovie = await _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);

            if (existMovie == null)
                return NotFound();

            existMovie.Name = movie.Name;
            existMovie.Genre = movie.Genre;
            existMovie.Duration = movie.Duration;
            existMovie.ReleaseDate = movie.ReleaseDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existMovie = await _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);

            if (existMovie == null)
                return NotFound();

            _context.Movies.Remove(existMovie);
            await _context.SaveChangesAsync();

            return Ok(existMovie);
        }
    }
}