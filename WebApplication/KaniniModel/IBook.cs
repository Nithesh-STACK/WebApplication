using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.KaniniModel
{
    public interface IBook<Book>

    {
        public  Task<List<Book>> GetAllBooks();
        public Task<Book> InsertBook(Book b);
        public Task<Book> DeleteBook(int id);
        public Task<Book> UpdateBook(int id, Book b);
        public Task<Book> GetById(int id);




    }
}
