using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPOnew.Entities;

namespace MPOnew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Post_HeadersController : ControllerBase
    {
        private readonly MPODbContext _context;

        public Post_HeadersController(MPODbContext context)
        {
            _context = context;
        }

        // GET: api/Post_Headers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post_Header>>> GetPost_Headers()
        {
            return await _context.Post_Headers.ToListAsync();
        }

        // GET: api/Post_Headers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post_Header>> GetPost_Header(int id)
        {
            var post_Header = await _context.Post_Headers.FindAsync(id);

            if (post_Header == null)
            {
                return NotFound();
            }

            return post_Header;
        }

        // PUT: api/Post_Headers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost_Header(int id, Post_Header post_Header)
        {
            if (id != post_Header.ID)
            {
                return BadRequest();
            }

            _context.Entry(post_Header).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Post_HeaderExists(id))
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

        // POST: api/Post_Headers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post_Header>> PostPost_Header(Post_Header post_Header)
        {
            _context.Post_Headers.Add(post_Header);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost_Header", new { id = post_Header.ID }, post_Header);
        }

        // DELETE: api/Post_Headers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost_Header(int id)
        {
            var post_Header = await _context.Post_Headers.FindAsync(id);
            if (post_Header == null)
            {
                return NotFound();
            }

            _context.Post_Headers.Remove(post_Header);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Post_HeaderExists(int id)
        {
            return _context.Post_Headers.Any(e => e.ID == id);
        }
    }
}
