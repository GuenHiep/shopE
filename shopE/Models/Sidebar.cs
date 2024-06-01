using Microsoft.AspNetCore.Mvc;
using shopE.Data;

namespace shopE.Models
{
	public class Sidebar: ViewComponent
	{
		private readonly shopEContext _context;

		public Sidebar(shopEContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
