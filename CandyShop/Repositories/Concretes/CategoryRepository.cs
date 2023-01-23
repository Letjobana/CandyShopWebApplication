using CandyShop.Models;
using CandyShop.Repositories.Abstracts;
using System.Collections.Generic;

namespace CandyShop.Repositories.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository()
        {

        }
        public IEnumerable<Category> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}
