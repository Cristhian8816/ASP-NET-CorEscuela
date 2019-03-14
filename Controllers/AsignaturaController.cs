using System;
using System.Linq;
using System.Collections.Generic;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (string.IsNullOrWhiteSpace(asignaturaId))
            {
                return View("MultiAsignatura", _context.Asignaturas);
            }
            else
            {
                var asignatura = from asig in _context.Asignaturas
                                 where asig.Id == asignaturaId
                                 select asig;

                return View(asignatura.SingleOrDefault());
            }
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