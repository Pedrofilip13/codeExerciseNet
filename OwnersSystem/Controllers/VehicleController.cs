using Microsoft.AspNetCore.Mvc;
using OwnersSystem.Data;
using OwnersSystem.Models;

namespace OwnersSystem.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VehicleController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Vehicle> objVehicleList = _db.Vehicles.ToList();
            return View(objVehicleList);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vehicle obj)
        {
            _db.Vehicles.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
