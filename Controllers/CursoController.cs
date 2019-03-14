using System;
using System.Collections.Generic;
using System.Linq;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class CursoController : Controller
    {
        [Route("Curso/Index")]
        [Route("Curso/Index/{cursoId}")]
        public IActionResult Index(string cursoId)
        {
            if (string.IsNullOrWhiteSpace(cursoId))
            {
                return View("MultiCurso", _context.Cursos);
            }
            else
            {
                var curso = from cur in _context.Cursos
                                 where cur.Id == cursoId
                                 select cur;

                return View(curso.SingleOrDefault());
            }
        }

        public IActionResult MultiCurso()
        {                
            ViewBag.CosaDinamica = "Cristhian is the best";
            ViewBag.Fecha = DateTime.Now;

            var cursos = _context.Cursos;
            return View("MultiCurso",cursos);
        } 

        public IActionResult Create()
        {         
            ViewBag.Fecha = DateTime.Now;
            
            return View();
        } 

        [HttpPost]
        public IActionResult Create(Curso curso)
        {         
            ViewBag.Fecha = DateTime.Now;

            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Curso Creado";

                return View("Index",curso);
            }
            else
            {
                return View(curso);
            }

            
        } 

        private EscuelaContext _context;

        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}