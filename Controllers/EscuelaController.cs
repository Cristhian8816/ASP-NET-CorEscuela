using System;
using Curso_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Curso_ASP_NET_Core.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            /*var escuela = new Escuela();

            escuela.añoFundacion = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Dirección = "cll 142#13-69";
            escuela.Pais ="Colombia";
            escuela.Ciudad = "Bogota"; */

            ViewBag.CosaDinamica = "Cristhian is the best";

            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}