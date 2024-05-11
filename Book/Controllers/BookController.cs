using Book.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookDbContext _context;
        public BookController(BookDbContext context) 
        {
            _context = context;
        }
        [HttpPost]
        [Route("sortedByPublisher")]
        public async Task<IActionResult> GetBooksSortedByPublisher()
        {
            try
            {

                List<BookDetails> rsData = await _context.GetBooksByPublisher();

                return Ok(rsData);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("sortedByAuthor")]
        public async Task<IActionResult> GetBooksSortedByAuthor()
        {
            try
            {

                List<BookDetails> rsData = await _context.GetBooksByAuthor();

                return Ok(rsData);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("TotalPrice")]
        public async Task<IActionResult> TotalPrice()
        {
            try
            {
                decimal totalPrice = 0.0m;
                List<BookDetails> rsData = await _context.GetBooksByAuthor();
                if(rsData.Count>0)
                {
                    foreach(var item in rsData)
                    {
                        totalPrice = totalPrice + item.Price;
                    }
                }
                return Ok(totalPrice);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
