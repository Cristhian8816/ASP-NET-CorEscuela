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
            return View("MultiAlumno", alumnos);
        }

        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Alumno alumno)
        {
            ViewBag.Fecha = DateTime.Now;

            if (ModelState.IsValid)
            {
                var curso = _context.Cursos.FirstOrDefault();

                alumno.CursoId = curso.Id;                
                _context.Alumnos.Add(alumno);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Alumno Creado";

                return View("Index", alumno);
            }
            else
            {
                return View(alumno);
            }
        }

        [Route("Alumno/Update")]
        [Route("Alumno/Update/{alumnoId}")]
        public IActionResult Update(string alumnoId)
        {
            var alumnoSelect = from alumno in _context.Alumnos
                                   where alumno.Id == alumnoId
                                   select alumno;

            // validation: alumnoId is available
            if (string.IsNullOrWhiteSpace(alumnoId))
            {
                return MultiAlumno();
            }
            else
            {
                return View(alumnoSelect.SingleOrDefault());//tengo dudas
            }
        }

        [Route("Alumno/Update/{alumnoId}")]
        [HttpPost]
        public IActionResult Update(string alumnoId, Alumno alumnoForm)
        {
            var alumno = _context.Alumnos.Find(alumnoId);//tengo dudas

            // validating all required data
            if (!ModelState.IsValid)
            {
                return View("Update", alumno);
            }
            // search and extract the asignature to be updated from db
            var alumnoSelect = _context.Alumnos.SingleOrDefault(c => c.Id == alumnoId);//tengo dudas

            // in case curso does not exist
            if (alumnoSelect == null)
            {
                return MultiAlumno();
            }
            else
            {
                // updating fields
                alumnoSelect.Nombre = alumnoForm.Nombre;
                alumnoSelect.Curso = alumnoForm.Curso;

                // saving updated data
                _context.SaveChanges();

                ViewBag.MensajeExtra = "Alumno Actualizado con éxito!";

                // return to individual view(Note: Not method Index,
                // Index view instead)
                // add the course searched
                return View("Index", alumno);
            }
        }
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}