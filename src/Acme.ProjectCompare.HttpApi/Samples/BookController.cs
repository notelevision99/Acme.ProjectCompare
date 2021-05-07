using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.ProjectCompare.Samples
{
    [RemoteService]
    [Route("api/ProjectCompare/book")]
    public class BookController : ProjectCompareController
    {
        private readonly IBookServices _bookServices;
        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }
        [HttpGet]
        public async Task<JsonResult> GetBooks([FromQuery] int pageSize,int pageNumber, string? searchString)
        {
            var result = await _bookServices.GetBooks(pageSize,pageNumber,searchString);
            return Json(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(Guid id)
        {
            var book = await _bookServices.GetBookById(id);
            if(book == null)
            {
                return null;
            }
            return Ok(book);
        }
       
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookDto bookDto)
        {
            var result = await _bookServices.CreateBook(bookDto);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(Guid id, [FromBody] BookDto bookDto)
        {
            var result = await _bookServices.UpdateBook(id, bookDto);
            return Ok(result);
        }
    }
}
