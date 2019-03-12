using System;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_ASP_NET_Core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();

            escuela.añoFundacion = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            
            return View(escuela);
        }
    }
}