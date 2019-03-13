using System;
using System.Linq;
using System.Collections.Generic;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = _context.Asignaturas.FirstOrDefault();
            return View(asignatura);
        }
        public IActionResult MultiAsignatura()
        {                  
            var asignaturas = _context.Asignaturas;
            ViewBag.CosaDinamica = "Cristhian is the best";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura",asignaturas);
        }
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}