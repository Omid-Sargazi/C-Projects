using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemSwaggers.Exceptions;
using LibrarySystemSwaggers.Models;
using LibrarySystemSwaggers.Persistence;
using LibrarySystemSwaggers.Validators;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystemSwaggers.Controllers
{
   [ApiController]
[Route("api/[controller]")]
public class BorrowingsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public BorrowingsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    public async Task<IActionResult> BorrowBook([FromBody] BorrowBookDto borrowDto)
    {
        var validator = new BorrowBookDtoValidator();
        var validationResult = await validator.ValidateAsync(borrowDto);
        if (!validationResult.IsValid)
        {
            throw new Exception("Validation failed");
        }

        var book = await _unitOfWork.Books.GetByIdAsync(borrowDto.BookId);
        if (book == null)
        {
            throw new EntityNotFoundException("Book", borrowDto.BookId);
        }

        if (!book.IsAvailable)
            throw new BusinessLogicException("The book is currently not available for borrowing.");

        var borrowRecord = new BorrowRecord
        {
            MemberId = borrowDto.MemberId,
            BookId = borrowDto.BookId,
            BorrowDate = DateTime.Now,
            DueDate = borrowDto.DueDate,
            IsReturned = false
        };

        book.IsAvailable = false;

        await _unitOfWork.BorrowRecords.AddAsync(borrowRecord);
        await _unitOfWork.SaveChangesAsync();
        return Ok(borrowRecord);
    }
}

}