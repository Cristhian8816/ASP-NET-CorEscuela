using System;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Curso_ASP_NET_Core.Controllers
{
    public class EscuelaController : Controller
    {        
        public IActionResult Index()
        {       
            ViewBag.CosaDinamica = "Cristhian is the best";

            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}