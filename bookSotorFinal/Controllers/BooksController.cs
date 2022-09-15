using bookSotorFinal.BookRepo;
using bookSotorFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookSotorFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookRepo _BookRepo;

        public  BooksController(IBookRepo booksRepo)
        {
            _BookRepo = booksRepo;
        }
        [HttpGet("")]
            public async Task<IActionResult> GetAllBooksSunc()
        {
            var books =await _BookRepo.GetAllBooksSunc();
            return Ok(books);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBooksByIdSunc(int Id)
        {
            var book = await _BookRepo.GetBooksByIdSunc(Id);
            return Ok(book);
        }
        

        

        [HttpPost("")]
        public async Task<IActionResult> AddBookSync([FromBody] BookModel bookModel)
        {
            var book = await _BookRepo.AddBookSync(bookModel);
            return Ok(book);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteBookSync(int Id)
        {
            await _BookRepo.DeleteBookSync(Id);
            return Ok();
        }


    }
}
