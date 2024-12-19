using Microsoft.AspNetCore.Mvc;
using ReadNDeals.Data;

namespace ReadNDeals.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db) 
        {
            _db = db;
        } 

        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
