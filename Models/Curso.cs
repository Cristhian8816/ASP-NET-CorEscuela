using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Curso_ASP_NET_Core.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        [StringLength(5)]
        public override string Nombre {get; set;}
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        [Display(Prompt="Direccion Correspondencia", Name="Address")]
        [Required(ErrorMessage = "Se requiere Incluir una direccion")]
        [MinLength(10, ErrorMessage = "Direccion Invalida")]
        public string Dirección { get; set; }   

        public string EscuelaId { get; set; } 
        public Escuela Escuela {get; set; }    
    }
}