using Microsoft.AspNetCore.Mvc;
using OwnersSystem.Data;
using OwnersSystem.Models;

namespace OwnersSystem.Controllers
{
	public class ClaimController : Controller
	{
        private readonly ApplicationDbContext _db;

        public ClaimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Claim> objClaimList = _db.Claims.ToList();
            return View(objClaimList);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Claim obj)
        {
            _db.Claims.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
