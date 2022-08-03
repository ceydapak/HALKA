using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _HALKA;
using _HALKA.Data;

namespace _HALKA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public BookCategoriesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/BookCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookCategory>>> GetBookCategories()
        {
          if (_context.BookCategories == null)
          {
              return NotFound();
          }
            return await _context.BookCategories.ToListAsync();
        }

        // GET: api/BookCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookCategory>> GetBookCategory(int id)
        {
          if (_context.BookCategories == null)
          {
              return NotFound();
          }
            var bookCategory = await _context.BookCategories.FindAsync(id);

            if (bookCategory == null)
            {
                return NotFound();
            }

            return bookCategory;
        }

        // PUT: api/BookCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookCategory(int id, BookCategory bookCategory)
        {
            if (id != bookCategory.BookCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(bookCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookCategoryExists(id))
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

        // POST: api/BookCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookCategory>> PostBookCategory(BookCategory bookCategory)
        {
          if (_context.BookCategories == null)
          {
              return Problem("Entity set 'DataContext.BookCategories'  is null.");
          }
            _context.BookCategories.Add(bookCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookCategory", new { id = bookCategory.BookCategoryId }, bookCategory);
        }

        // DELETE: api/BookCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookCategory(int id)
        {
            if (_context.BookCategories == null)
            {
                return NotFound();
            }
            var bookCategory = await _context.BookCategories.FindAsync(id);
            if (bookCategory == null)
            {
                return NotFound();
            }

            _context.BookCategories.Remove(bookCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookCategoryExists(int id)
        {
            return (_context.BookCategories?.Any(e => e.BookCategoryId == id)).GetValueOrDefault();
        }
    }
}
