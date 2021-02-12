using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMusic.Data;
using MvcMusic.Models;

namespace MvcMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicAPI : ControllerBase
    {
        private readonly MvcMusicContext _context;

        public MusicAPI(MvcMusicContext context)
        {
            _context = context;
        }

        // GET: api/MusicAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Music>>> GetMusic()
        {
            return await _context.Music.ToListAsync();
        }
        // GET: api/MusicAPI
        [HttpGet("validation")]
        public async Task<ActionResult<IEnumerable<Music>>> GetMusicValidation()
        {
            return await _context.Music.Where(m => m.Validation == "1").ToListAsync();
        }

        // GET: api/MusicAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Music>> GetMusic(int id)
        {
            var music = await _context.Music.FindAsync(id);

            if (music == null)
            {
                return NotFound();
            }

            return music;
        }

        // PUT: api/MusicAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusic(int id, Music music)
        {
            if (id != music.Id)
            {
                return BadRequest("L'ID doit être fourni");
            }
            if (!String.IsNullOrEmpty(music.Validation))
            {
                return BadRequest("Que cherchez vous ?");
            }

            _context.Entry(music).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MusicAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Music>> PostMusic(Music music)
        {
            if(music.Validation != "0")
            {
                music.Validation = "0";
            }
            else
            {
                music.Validation = "0";
            }
            _context.Music.Add(music);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMusic), new { id = music.Id }, music);
        }

        // DELETE: api/MusicAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int id)
        {
            var music = await _context.Music.FindAsync(id);
            if (music == null)
            {
                return NotFound();
            }

            _context.Music.Remove(music);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicExists(int id)
        {
            return _context.Music.Any(e => e.Id == id);
        }
    }
}
