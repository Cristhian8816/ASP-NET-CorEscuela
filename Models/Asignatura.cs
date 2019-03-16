using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Curso_ASP_NET_Core.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        [StringLength(15)]
        public override string Nombre {get; set;}
        public string CursoId {get; set; }
        public Curso Curso {get; set; }

        public List<Evaluación> Evaluaciones { get; set; }
    }
}