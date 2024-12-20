using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Validators;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            var validator = new ProductValidator();
            var validationResult = validator.Validate(product);
            if(!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProductById),new {id=product.Id},product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id,[FromBody] Product updatedProduct)
        {

            var product = _context.Products.Find(id);
            if(product==null)
            {
                return NotFound();
            }

            var validator = new ProductValidator();
            var validationResult = validator.Validate(updatedProduct);
            if(!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            product.Name = updatedProduct.Name;
            product.Description=updatedProduct.Description;
            product.Stock=updatedProduct.Stock;
            product.Price=updatedProduct.Price;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if(product==null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }

        
    }
}