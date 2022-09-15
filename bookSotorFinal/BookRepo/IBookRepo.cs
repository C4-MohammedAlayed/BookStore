using bookSotorFinal.Data;
using bookSotorFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookSotorFinal.BookRepo
{
  public  interface IBookRepo
    {
        public Task<List<BookModel>> GetAllBooksSunc();
        public Task<BookModel> GetBooksByIdSunc(int bookId);
        public  Task<Books> AddBookSync(BookModel bookModel);
        public Task<string> DeleteBookSync(int bookId);
    }
}
