using CandyShop.Models;
using CandyShop.Repositories.Abstracts;
using System.Collections.Generic;

namespace CandyShop.Repositories.Concretes
{
    public class CandyRepository : ICandyRepository
    {
        public CandyRepository()
        {

        }
        public IEnumerable<Candy> GetAllCandy()
        {
            throw new System.NotImplementedException();
        }

        public Candy GetCandyById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Candy> GetCandyOnSale()
        {
            throw new System.NotImplementedException();
        }
    }
}
