using BookStore.Domain.Interfaces.Repository;
using BookStore.Domain.Interfaces.Service;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<Book> Add(Book book)
        {
            if (_bookRepository.Search(b => b.Name == book.Name).Result.Any())
                return null;

            await _bookRepository.Add(book);
            return book;
        }

        public void Dispose()
        {
            _bookRepository.Dispose();
        }

        public Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Search(string bookName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> SearchBookWithCategory(string searchedValue)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
