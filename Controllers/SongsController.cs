using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Data;
using MusicLibraryAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs.ToList();
            return StatusCode(200, songs);
        }

        // GET api/Songs/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            return StatusCode(200, song);
        }

        // POST api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);
        }

        //// PUT api/Songs/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            var update = _context.Songs.Find(id);

            update.Title = song.Title;
            update.Artist = song.Artist;
            update.Album = song.Album;
            update.ReleaseDate = song.ReleaseDate;
            update.Genre = song.Genre;

            return StatusCode(200, song);
        }

        //// DELETE api/Songs/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            _context.Songs.Remove(song);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

