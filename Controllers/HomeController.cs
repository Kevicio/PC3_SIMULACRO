using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3_SIMULACRO.Models;
using PC3_SIMULACRO.Data;

namespace PC3_SIMULACRO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Data.AdopcionContext _context;

        public HomeController(ILogger<HomeController> logger, Data.AdopcionContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var solicitudes= _context.SolicitudesAdopcion.ToList();

            return View(solicitudes);
        }


        public IActionResult SolicitudAdopcion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SolicitudAdopcion(SolicitudAdopcion sa)
        {   
            if(ModelState.IsValid){
                // guardará al objeto sa en la BD
                _context.Add(sa);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(sa);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
