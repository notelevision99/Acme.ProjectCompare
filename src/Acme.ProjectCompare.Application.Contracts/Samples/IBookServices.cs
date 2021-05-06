using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.ProjectCompare.Samples
{
    public interface IBookServices : IApplicationService
    {
        Task<List<BookDto>> GetBooks();
    }
}
