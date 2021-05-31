using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab2.Models;

namespace Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsFilmsController : ControllerBase
    {
        private readonly Lab2CinemaContext _context;

        public DirectorsFilmsController(Lab2CinemaContext context)
        {
            _context = context;
        }

        // GET: api/DirectorsFilms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DirectorsFilms>>> GetDirectorsFilms()
        {
            return await _context.DirectorsFilms.ToListAsync();
        }

        // GET: api/DirectorsFilms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DirectorsFilms>> GetDirectorsFilms(int id)
        {
            var directorsFilms = await _context.DirectorsFilms.FindAsync(id);

            if (directorsFilms == null)
            {
                return NotFound();
            }

            return directorsFilms;
        }

        // PUT: api/DirectorsFilms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDirectorsFilms(int id, DirectorsFilms directorsFilms)
        {
            if (id != directorsFilms.Id)
            {
                return BadRequest();
            }

            _context.Entry(directorsFilms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectorsFilmsExists(id))
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

        // POST: api/DirectorsFilms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DirectorsFilms>> PostDirectorsFilms(DirectorsFilms directorsFilms)
        {
            _context.DirectorsFilms.Add(directorsFilms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDirectorsFilms", new { id = directorsFilms.Id }, directorsFilms);
        }

        // DELETE: api/DirectorsFilms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDirectorsFilms(int id)
        {
            var directorsFilms = await _context.DirectorsFilms.FindAsync(id);
            if (directorsFilms == null)
            {
                return NotFound();
            }

            _context.DirectorsFilms.Remove(directorsFilms);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DirectorsFilmsExists(int id)
        {
            return _context.DirectorsFilms.Any(e => e.Id == id);
        }
    }
}
