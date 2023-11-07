using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> catList=_db.Categories.ToList();
            return View(catList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category cat)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(cat);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category cat)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(cat);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            
              _db.Categories.Remove(category);
              _db.SaveChanges();
              return RedirectToAction(nameof(Index));
        }
    }
}
