using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication.KaniniModel
{
    public partial class Book : IBook<Book>
    {
        public Book(){

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int? Price { get; set; }
        public string Photo { get; set; }
        public string PlotDescription { get; set; }

        private readonly stationaryContext db = new stationaryContext();
        public async Task<List<Book>> GetAllBooks()
        {
            return await db.Books.ToListAsync();
        }
        public async Task<Book> InsertBook(Book b)
        {
            db.Books.Add(b);
            await db.SaveChangesAsync();
            return (b);

        }
        public async Task<Book> DeleteBook(int id)
        {
            Book e = db.Books.Find(id);
            db.Books.Remove(e);
            await db.SaveChangesAsync();
            return (e);

        }
        public async Task<Book> UpdateBook(int id, Book b)
        {
            db.Entry(b).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return (await db.Books.FindAsync(id));

        }
        public async Task<Book> GetById(int id)
        {
            return await (db.Books.FindAsync(id));
        }

    }

}
