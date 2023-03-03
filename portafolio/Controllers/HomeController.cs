using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using portafolio.Servicios;
using System.Diagnostics;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly ServicioDeLimitado servicioDeLimitado;
        private readonly ServicioTransitorio servicioTransitorio;
        
        private readonly ServicioUnico servicioUnico;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos,
            ServicioDeLimitado servicioDeLimitado,
            ServicioTransitorio servicioTransitorio,
            ServicioUnico servvicioUnico)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.servicioDeLimitado = servicioDeLimitado;
            this.servicioTransitorio = servicioTransitorio;
            this.servicioUnico = servvicioUnico;
            
        }

        public IActionResult Index()
        {
            ViewBag.nombre = "Joan Manuel Solis";
            ViewBag.edad = 25;
            var proyectos = repositorioProyectos.ObtenerProyactos().Take(3).ToList();
            var modelGuid = new EjemploGUIDViewDV()
            {
                Delimitado = servicioDeLimitado.ObtenerGuid,
                Transitorio = servicioTransitorio.ObtenerGuid,
                Unico       = servicioUnico.ObtenerGuid      
            };
            var modelo = new HomeIndexViewModel() { 
                Proyectos = proyectos, 
                EjemploGuid1 = modelGuid};
            return View(modelo);
        }
        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyactos();
            return View(proyectos);
        }

        public IActionResult Menu()
        {
           
            return View();
        }


        public IActionResult Contacto() {
            return View();
        }
        [HttpPost]
        public IActionResult Contacto([Bind("Nombre","Telefono","Comentario")]ContactoviewModel contactoviewModel)
        {
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias() {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}