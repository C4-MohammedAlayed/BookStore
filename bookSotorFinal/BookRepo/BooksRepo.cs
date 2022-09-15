using bookSotorFinal.Data;
using bookSotorFinal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookSotorFinal.BookRepo
{
    public class BooksRepo : IBookRepo
    {
        private readonly DataBase _Db;
        public BooksRepo(DataBase DB)
        {
            _Db = DB;
        }


        public async Task<List<BookModel>> GetAllBooksSunc()
        {
            var records = await _Db.Books.Select(x => new BookModel()
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                Price = x.Price
            }

            ).ToListAsync();
            return records;
        }

        public async Task<BookModel> GetBooksByIdSunc(int bookId)
        {
            var record = await _Db.Books.Where(x => x.Id == bookId).Select(x => new BookModel()
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                Price = x.Price
            }).FirstOrDefaultAsync();


            return record;
        }



        public async Task<Books> AddBookSync(BookModel bookModel)
        {
            var Book = new Books()
            {
                Title = bookModel.Title,
                Description = bookModel.Description,
                Price = bookModel.Price,
            };
            _Db.Books.Add(Book);
            await _Db.SaveChangesAsync();
            return Book;
        }

        public async Task<string> DeleteBookSync(int bookId)
        {
            var book = _Db.Books.Where(x => x.Id == bookId).FirstOrDefault();
            _Db.Books.Remove(book);

            await _Db.SaveChangesAsync();
            return $"Delete Book with Id ={bookId}";
        }
    }
    }
