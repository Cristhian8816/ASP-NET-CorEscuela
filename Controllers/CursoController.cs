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
            ViewBag.Fecha = DateTime.Now;

            var cursos = _context.Cursos;
            return View("MultiCurso", cursos);
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

                return View("Index", curso);
            }
            else
            {
                return View(curso);
            }
        }

        [Route("Curso/Update")]
        [Route("Curso/Update/{cursoId}")]
        public IActionResult Update(string cursoId)
        {
            var cursoSelect = from curso in _context.Cursos
                              where curso.Id == cursoId
                              select curso;

            // validation: cursoId is available
            if (string.IsNullOrWhiteSpace(cursoId))
            {
                return MultiCurso();
            } 
            else
            {
                return View(cursoSelect.SingleOrDefault());//tengo dudas
            }            
        }

        [Route("Curso/Update/{cursoId}")]
        [HttpPost]
        public IActionResult Update(string cursoId, Curso cursoForm)
        {
            var curso = _context.Cursos.Find(cursoId);//tengo dudas

            // validating all required data
            if (!ModelState.IsValid) 
            {
                return View("Update", curso);
            }
            // search and extract the course to be updated from db
            var cursoSelect = _context.Cursos.SingleOrDefault(c => c.Id == cursoId);//tengo dudas

            // in case curso does not exist
            if (cursoSelect == null) 
            {
                return MultiCurso();
            }
            else
            {
                // updating fields
                cursoSelect.Nombre = cursoForm.Nombre;
                cursoSelect.Dirección = cursoForm.Dirección;
                cursoSelect.Jornada = cursoForm.Jornada;

                // saving updated data
                _context.SaveChanges();

                ViewBag.MensajeExtra = "Curso Actualizado con éxito!";

                // return to individual view(Note: Not method Index,
                // Index view instead)
                // add the course searched
                return View("Index", curso);
            }
        }

        private EscuelaContext _context;

        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}