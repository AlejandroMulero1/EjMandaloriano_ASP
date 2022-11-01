using DAL;
using Entidades;
using EjMandaloriano_ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjMandaloriano_ASP_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            var listaMisiones = clsListaMisiones.obtenerListaMisiones();
            
            var model = new MisionViewModel();
            model.misionSelectList = new List<SelectListItem>();
            foreach(var mision in listaMisiones)
            {
                model.misionSelectList.Add(new SelectListItem { Text = mision.NombreMision, Value = (String)mision.Id });
            } 
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(MisionViewModel model)
        {
            var misionElegida = model.IdMision;
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