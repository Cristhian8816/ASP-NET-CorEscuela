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
            return View(new Alumno { 
                                Nombre = "Cristhian Gómez",
                                UniqueId = Guid.NewGuid().ToString()
                               }
                        );
        }
        public IActionResult MultiAlumno()
        {
            var listaAlumno = GenerarAlumnosAlAzar();       

            ViewBag.CosaDinamica = "Cristhian is the best";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno",listaAlumno);
        }
        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = {"Cristhian","Julian","Fabio","Andres","Javier","Carlos","Camilo"};
            string[] Apellido1 = {"Gomez","Prada","Lizcanoe","Ortiz","Silva","Toledo","Herrera"};
            string[] nombre2 = {"Julian","Jose","Juan","Osvaldo","Andres","Diomedes","Nicomedes","Teodoro"};

            var listaAlumnos =  from n1 in nombre1 //Esto es un producto cartesiano de los tres arreglos creados
                                from n2 in nombre2
                                from a1 in Apellido1
                                select new Alumno{ 
                                                    Nombre = $"{n1} {n2} {a1}",
                                                    UniqueId = Guid.NewGuid().ToString() 
                                                 };
                                            
            return listaAlumnos.OrderBy( (al) => al.UniqueId ).ToList();            
        }
    }
}