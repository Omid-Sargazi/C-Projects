using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemSwaggers.DTOs;
using LibrarySystemSwaggers.Exceptions;
using LibrarySystemSwaggers.Models;
using LibrarySystemSwaggers.Persistence;
using LibrarySystemSwaggers.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LibrarySystemSwaggers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookCreateDto createDto)
        {
            var book = new Book{
                Title=createDto.Title,
                PublishedDate=createDto.PublishedDate,
                IsAvailable=true,
            };

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBooks),new {Id=book.Id},book);
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _unitOfWork.Books.GetAllAsync();
            return Ok(books);
        }

        

        // [HttpPost]
        // public async Task<IActionResult> BorrowBook([FromBody] BorrowBookDto borrowDto)
        // {
        //     var validator = new BorrowBookDtoValidator();
        //     var validationResult = await validator.ValidateAsync(borrowDto);
        //     if(!validationResult.IsValid)
        //     {
        //         // throw new ValidationException(string.Join(",",validationResult.Errors.Select(e=>e.ErrorMessage)));
        //         throw new Exception();
        //     }

        //     var book = await _unitOfWork.Books.GetByIdAsync(borrowDto.BookId);
        //     if(book==null)
        //     {
        //         throw new EntityNotFoundException("Book", borrowDto.BookId);
        //     }

        //     if(!book.IsAvailable)
        //         throw new BusinessLogicException("The book is currently not available for borrowing.");

        //     var borrowRecord = new BorrowRecord
        //         {
        //     MemberId = borrowDto.MemberId,
        //     BookId = borrowDto.BookId,
        //     BorrowDate = DateTime.Now,
        //     DueDate = borrowDto.DueDate,
        //     IsReturned = false
        //          };

        //     book.IsAvailable = false;

        //     await _unitOfWork.BorrowRecords.AddAsync(borrowRecord);
        //     await _unitOfWork.SaveChangesAsync();
        //     return Ok(borrowRecord);
        // }
    }
}