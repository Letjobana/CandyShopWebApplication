using CandyShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace CandyShop.Repositories.Abstracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
