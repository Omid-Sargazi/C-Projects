using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem02.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IBookRepository _bookRepository;
        public UnitOfWork(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IBookRepository bookRepository =>_bookRepository;

        public async Task<int> CompleteAsync()
        {
            return await Task.FromResult(1);
        }

        public void Dispose()
        {
            // Dispose any resources if needed
        }

    }
}