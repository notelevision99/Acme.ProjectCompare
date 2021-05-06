using Acme.ProjectCompare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.ProjectCompare.Samples
{
    public class BookServices : ApplicationService, IBookServices
    {
        //private readonly IRepository<Book, Guid> _bookRepository;
        //public BookServices(IRepository<Book, Guid> bookRepository)
        //{
        //    _bookRepository = bookRepository;
        //}
        public async Task<List<BookDto>> GetBooks()
        {
            //var books = _bookRepository.Select(p => new BookDto
            //{
            //    BookName = p.BookName,
            //    BookType = p.BookType,
            //    Description = p.Description
            //}).ToList();
            var books = new List<BookDto>() { new BookDto() { BookName = "1234" } };
            return books;
        }
    }
}
