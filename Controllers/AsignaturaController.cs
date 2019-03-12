using System;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura();

            asignatura.UniqueId = Guid.NewGuid().ToString();
            asignatura.Nombre = "Programacion";

            ViewBag.CosaDinamica = "Cristhian is the best";
            ViewBag.Fecha = DateTime.Now;
            
            return View(asignatura);
        }
    }
}