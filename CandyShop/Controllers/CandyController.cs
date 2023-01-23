using CandyShop.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository candyRepository;
        private readonly ICategoryRepository categoryRepository;

        public CandyController(ICandyRepository candyRepository,ICategoryRepository categoryRepository)
        {
            this.candyRepository = candyRepository;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
