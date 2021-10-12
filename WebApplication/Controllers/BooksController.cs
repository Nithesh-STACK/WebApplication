using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.KaniniModel;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public static stationaryContext db = new stationaryContext();
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await db.Books.ToListAsync());
        }
        [HttpPost]
        public async  Task<IActionResult> InsertBook(Book b)
        {
            db.Books.Add(b);
            await db.SaveChangesAsync();
            return Ok();

        }
        [HttpPut]
        [Route("{id}")]

        public async Task<ActionResult<Book>> UpdateBook(int id,Book b)
        {
            using (var db = new stationaryContext())
            {
                db.Entry(b).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return Ok(b);
            }
        }
        [HttpDelete]
        [Route("{id}")]

        public async Task<ActionResult<Book>> Delete(int id)
        {
            Book b = db.Books.Find(id);
            db.Books.Remove(b);
            await db.SaveChangesAsync();
            return Ok();

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            Book b = await db.Books.FindAsync(id);
            return Ok(b);
        }


        
    }
}
