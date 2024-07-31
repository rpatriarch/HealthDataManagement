using Microsoft.AspNetCore.Mvc;
using HealthDataManagement.Data;
using HealthDataManagement.Models;

namespace HealthDataManagement.Controllers
{
    public class SomeEntityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SomeEntityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Примерен метод за работа с данни
        public IActionResult Index()
        {
            var entities = _context.Appointments.ToList();
            return View(entities);
        }
    }
}
