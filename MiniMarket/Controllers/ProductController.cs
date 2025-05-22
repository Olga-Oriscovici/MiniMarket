using Microsoft.AspNetCore.Mvc;
using MiniMarket.Data;

namespace MiniMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController (ApplicationDbContext _context)
        {
            _context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
