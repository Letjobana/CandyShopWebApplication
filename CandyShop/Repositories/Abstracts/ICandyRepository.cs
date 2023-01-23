using CandyShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace CandyShop.Repositories.Abstracts
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy();
        IEnumerable<Candy> GetCandyOnSale();
        Candy GetCandyById(int id);
    }
}
