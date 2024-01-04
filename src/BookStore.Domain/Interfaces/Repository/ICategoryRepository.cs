using BookStore.Domain.Interfaces.BaseRepository;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Interfaces.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
