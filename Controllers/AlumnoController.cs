using System;
using System.Collections.Generic;
using System.Linq;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            var alumno = _context.Alumnos.FirstOrDefault();
            return View(alumno);
        }
        public IActionResult MultiAlumno()
        {                
            ViewBag.CosaDinamica = "Cristhian is the best";
            ViewBag.Fecha = DateTime.Now;

            var alumnos = _context.Alumnos;
            return View("MultiAlumno",alumnos);
        } 
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}