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
        public async Task<IActionResult> GetBooks()
        {
            var result = await _bookServices.GetBooks();
            return Ok(result);
        }
    }
}
