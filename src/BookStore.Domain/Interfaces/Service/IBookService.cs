﻿using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Interfaces.Service
{
    public interface IBookService : IDisposable
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> GetById(int id);
        Task<Book> Add(Book book);
        Task<Book> Update(Book book);
        Task<bool> Remove(Book book);
        Task<IEnumerable<Book>> GetBooksByCategory(int categoryId);
        Task<IEnumerable<Book>> Search(string bookName);
        Task<IEnumerable<Book>> SearchBookWithCategory(string searchedValue);
    }
}
