using Microsoft.AspNetCore.Mvc;
using MiniMarket.Data;
using MiniMarket.Models;


namespace MiniMarket.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController (ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public  IActionResult SelectRole(string role)
        {
            if (role == "seller")
            {
                return RedirectToAction("CreateSeller");
            }
            else if (role == "buyer")
            {
                return RedirectToAction("CreateBuyer");
            }
            return RedirectToAction("Index");
        }

        public  IActionResult CreateSeller()
        {
            return View();
        }

        public  IActionResult CreateBuyer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult CreateBuyer(Buyer buyer)
        {
            if (ModelState.IsValid)
            { 
              _context.buyers.Add(buyer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buyer);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSeller(Seller seller)
        {
            if (ModelState.IsValid)
            {
                _context.sellers.Add(seller);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seller);

        }
    }
    
}
