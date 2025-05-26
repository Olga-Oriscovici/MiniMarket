using Microsoft.AspNetCore.Mvc;
using MiniMarket.Data;
using MiniMarket.Models;
using MiniMarket.ViewModels;

namespace MiniMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ViewModel = new ProductPageModel
            {
                Products = _context.products.ToList(),
                NewProduct = new Product(),
             
            };

            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ProductPageModel viewModel)
        {
            if (ModelState.IsValid) 
            { 
              _context.products.Add(viewModel.NewProduct);
                
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            viewModel.Products = _context.products.ToList();
           
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var product =_context.products.Find(id);

            if(product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = _context.products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            else if (product != null)
            {
                return View();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }


    }
}
