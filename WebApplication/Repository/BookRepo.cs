using WebApplication.KaniniModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Repository
{
    public class BookRepo : IBookRepo<Book>
    {
        private readonly IBook<Book> obj;
        public BookRepo(IBook<Book> _obj)
        {
            obj = _obj;
        }
        public async Task<List<Book>> GetAllBooks()
        {
            return await obj.GetAllBooks();
        }
        public async Task<Book> InsertBook(Book b)
        {
            return await obj.InsertBook(b);


        }
        public async Task<Book> DeleteBook(int id)
        {
            return await obj.DeleteBook(id);

        }

        public async Task<Book> UpdateBook(int id,Book b)
        {
            return await obj.UpdateBook(id,b);

        }
        public async Task<Book> GetById(int id)
        {
            return await obj.GetById(id);
        }

    }
}
