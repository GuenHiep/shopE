using Microsoft.AspNetCore.Mvc;
using shopE.Data;

namespace shopE.Models
{
	public class Search : ViewComponent
	{
		private readonly shopEContext _context;

		public Search(shopEContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
