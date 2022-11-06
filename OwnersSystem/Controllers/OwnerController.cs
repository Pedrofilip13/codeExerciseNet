using Microsoft.AspNetCore.Mvc;
using OwnersSystem.Data;
using OwnersSystem.Models;

namespace OwnersSystem.Controllers
{
    public class OwnerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OwnerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Owner> objOwnerList = _db.Owners.ToList();
            return View(objOwnerList);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Owner obj)
        {
            _db.Owners.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
