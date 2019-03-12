using System;
using System.Collections.Generic;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View(new Asignatura { 
                                Nombre = "Programacion",
                                UniqueId = Guid.NewGuid().ToString()
                               }
                        );
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>()
            {
                new Asignatura { 
                                 Nombre = "Matematicas",
                                 UniqueId = Guid.NewGuid().ToString()
                               },
                new Asignatura {
                                 Nombre = "Educacion Fisica",
                                 UniqueId = Guid.NewGuid().ToString()
                               },
                new Asignatura { 
                                 Nombre = "Castellano",
                                 UniqueId = Guid.NewGuid().ToString()
                               },
                new Asignatura { 
                                 Nombre = "Ciencias Naturales",
                                 UniqueId = Guid.NewGuid().ToString()
                               },
                new Asignatura { 
                                 Nombre = "Programacion",
                                 UniqueId = Guid.NewGuid().ToString()
                               },
            };        

            ViewBag.CosaDinamica = "Cristhian is the best";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura",listaAsignaturas);
        }
    }
}