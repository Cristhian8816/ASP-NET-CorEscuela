using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Curso_ASP_NET_Core.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre del Alumno es obligatorio")]
        [StringLength(25)]
        public override string Nombre {get; set;}
        public override string Id {get; set;}
        public List<Evaluación> Evaluaciones { get; set; }

        public string CursoId {get; set; }

        [Display(Prompt="Curso alumno", Name="Curso")]        
        [MaxLength(3, ErrorMessage = "Curso Invalido")]
        public  Curso Curso {get; set; }
        [Display(Prompt="Email alumno", Name="Email")]        
        [DataType(DataType.EmailAddress)] 
        [EmailAddress]
        public string Email {get; set; }        
    }
}