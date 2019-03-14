using System;
using System.Collections.Generic;
using System.Linq;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class AlumnoController : Controller
    {
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{alumnoId}")]
        public IActionResult Index(string alumnoId)
        {
            if (string.IsNullOrWhiteSpace(alumnoId))
            {
                return View("MultiAlumno", _context.Alumnos);
            }
            else
            {
                var alumno = from alumn in _context.Alumnos
                                 where alumn.Id == alumnoId
                                 select alumn;

                return View(alumno.SingleOrDefault());
            }
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