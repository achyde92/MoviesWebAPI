using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/Movies
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/Movies
        [HttpGet]
        public IActionResult Get()
        {
            var movie = _context.Movies.ToList();
            return StatusCode(200, movie);
        }

        // GET: api/Movies/4
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return StatusCode(200, movie);
        }

        //POST: api/Movies
        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return StatusCode(201, movie);
        }

        //Put: api/Movies/5
        //[HttpPut("{id")]
        //public IActionResult Put(int id, [FromBody] Movie movie)
        //{
        //    var movie = _context.Movies.Update(id);
        //    return StatusCode(200, movie);
        //}
    }
}
