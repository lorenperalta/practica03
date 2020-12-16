using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica03.Data;
using practica03.Models;

namespace practica03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            DateTime fecha = DateTime.Today;
            fecha = fecha.AddDays(+1);
            DateTime ayer = fecha.AddDays(-7);
            var registro = _context.Registrar.Where(x => x.date>=ayer && x.date<=fecha).ToList();
            return View(registro);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ingresar(Producto p)
        {
            if (ModelState.IsValid)
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("Registrar", p);
        }

        [HttpPost]
        public IActionResult Eliminar(int id) {
            var contacto = _context.Registrar.FirstOrDefault(x => x.id == id);
            _context.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
