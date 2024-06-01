using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopE.Data;
using shopE.Models;
using System.Diagnostics;

namespace shopE.Controllers
{
    public class HomeController : Controller
    {
		private readonly shopEContext _context;

		public HomeController(shopEContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View(_context.Product.Include(p => p.Category).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
