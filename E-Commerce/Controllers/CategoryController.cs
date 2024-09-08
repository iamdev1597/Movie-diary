using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.ProductCategory.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name and DisplayOrder can not be same!");
            }
            if (obj.Name!=null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Invalid name!");
            }
            if (ModelState.IsValid)
            {
                _db.ProductCategory.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            Category? idFromDb=_db.ProductCategory.FirstOrDefault(x=>x.id==id);
            if (idFromDb == null)
            {
                return NotFound();
            }
            return View(idFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name and DisplayOrder can not be same!");
            }
            if (obj.Name != null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Invalid name!");
            }
            if (ModelState.IsValid)
            {
                _db.ProductCategory.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? idFromDb = _db.ProductCategory.FirstOrDefault(x => x.id == id);
            if (idFromDb == null)
            {
                return NotFound();
            }
            return View(idFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteId(int? id)
        {
           Category? deleteId= _db.ProductCategory.FirstOrDefault(x => x.id == id);
            if(deleteId  == null)
            {
                return NotFound();
            }
            _db.ProductCategory.Remove(deleteId);
            _db.SaveChanges();
            return RedirectToAction("Index");            
        }
    }
}
