using WebApplication.KaniniModel;
using WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Service
{
    public class BookServ:IBookServ<Book>
    {
        private readonly IBookRepo<Book> repo;
        public BookServ(IBookRepo<Book> _repo)
        {
            repo = _repo;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await repo.GetAllBooks();
        }
        public async Task<Book> InsertBook(Book b)
        {
            return await repo.InsertBook(b);


        }
        public async Task<Book> DeleteBook(int id)
        {
            return await repo.DeleteBook(id);

        }
        public async Task<Book> UpdateBook(int id, Book b)
        {
            return await repo.UpdateBook(id, b);

        }
        public async Task<Book> GetById(int id)
        {
            return await repo.GetById(id);
        }

    }
}
