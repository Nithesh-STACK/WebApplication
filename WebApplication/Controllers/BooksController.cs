using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.KaniniModel;
using WebApplication.Service;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookServ<Book> serv;

        public BooksController(IBookServ<Book> _serv)
        {
            serv = _serv;
        }
      
        public static stationaryContext db = new stationaryContext();

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {

            return Ok(await serv.GetAllBooks());
        }
        [HttpPost]
        public async  Task<IActionResult> InsertBook(Book b)
        {
            return Ok(await serv.InsertBook(b));
        }
        [HttpPut]
        [Route("{id}")]

        public async Task<ActionResult<Book>> UpdateBook(int id,Book b)
        {
            return await serv.UpdateBook(id, b);

        }
        [HttpDelete]
        [Route("{id}")]

        public async Task<ActionResult<Book>> Delete(int id)
        {
            return await serv.DeleteBook(id);


        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
        
                return await serv.GetById(id);
            
        }


        
    }
}
