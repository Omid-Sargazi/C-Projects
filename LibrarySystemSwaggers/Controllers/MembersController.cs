using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemSwaggers.Models;
using LibrarySystemSwaggers.Persistence;
using LibrarySystemSwaggers.Validators;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystemSwaggers.Controllers
{
   [ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public MembersController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMember([FromBody] MemberCreateDto memberDto)
    {
        var validator = new MemberCreateDtoValidator();
        var validationResult = await validator.ValidateAsync(memberDto);
        if (!validationResult.IsValid)
        {
            throw new Exception("Validation failed");
        }

        var member = new Member
        {
            Name = memberDto.Name,
            Email = memberDto.Email,
        };

        await _unitOfWork.Members.AddAsync(member);
        await _unitOfWork.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMembers), new { id = member.Id }, member);
    }

    [HttpGet]
    public async Task<IActionResult> GetMembers()
    {
        var members = await _unitOfWork.Members.GetAllAsync();
        return Ok(members);
    }
}

}