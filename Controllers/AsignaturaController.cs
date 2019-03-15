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

            return View("MultiAsignatura", asignaturas);
        }
        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Asignatura asignatura)
        {
            ViewBag.Fecha = DateTime.Now;

            if (ModelState.IsValid)
            {
                var curso = _context.Cursos.FirstOrDefault();

                asignatura.CursoId = curso.Id;
                _context.Asignaturas.Add(asignatura);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Asignatura Creada";

                return View("Index", asignatura);
            }
            else
            {
                return View(asignatura);
            }
        }

        [Route("Asignatura/Update")]
        [Route("Asignatura/Update/{asignaturaId}")]
        public IActionResult Update(string asignaturaId)
        {
            var asignaturaSelect = from asignatura in _context.Asignaturas
                              where asignatura.Id == asignaturaId
                              select asignatura;

            // validation: asignaturaId is available
            if (string.IsNullOrWhiteSpace(asignaturaId))
            {
                return MultiAsignatura();
            }
            else
            {
                return View(asignaturaSelect.SingleOrDefault());//devuelve la asignatura encontrada por el query
            }
        }

        [Route("Asignatura/Update/{asignaturaId}")]
        [HttpPost]
        public IActionResult Update(string asignaturaId, Asignatura asignaturaForm)
        {
            var asignatura = _context.Asignaturas.Find(asignaturaId);//tengo dudas

            // validating all required data
            if (!ModelState.IsValid)
            {
                return View("Update", asignatura);
            }
            // search and extract the asignature to be updated from db
            var asignaturaSelect = _context.Asignaturas.SingleOrDefault(c => c.Id == asignaturaId);//tengo dudas

            // in case curso does not exist
            if (asignaturaSelect == null)
            {
                return MultiAsignatura();
            }
            else
            {
                // updating fields
                asignaturaSelect.Nombre = asignaturaForm.Nombre;               

                // saving updated data
                _context.SaveChanges();

                ViewBag.MensajeExtra = "Asignatura Actualizada con éxito!";

                // return to individual view(Note: Not method Index,
                // Index view instead)
                // add the course searched
                return View("Index", asignatura);
            }
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}