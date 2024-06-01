using Microsoft.AspNetCore.Mvc;
using shopE.Data;

namespace shopE.Models
{
	public class Navbar:ViewComponent
	{
		private readonly shopEContext _context;

		public Navbar(shopEContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
    }
}
