using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemBackend.DTOs;
using LibrarySystemBackend.Models;
using LibrarySystemBackend.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystemBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _unitOfWork.books.GetAllAsync();
            return Ok(books);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookCreateDto bookDTo)
        {
            var book  = new Book{
                Title=bookDTo.Title,
                PublishedDate = bookDTo.PublishedDate,
                IsAvailable=true,
            };
            await _unitOfWork.books.AddAsync(book);
            await _unitOfWork.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBooks),new {id=book.Id},book);
        }
    }
}