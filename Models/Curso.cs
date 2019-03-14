using System;
using System.Collections.Generic;

namespace Curso_ASP_NET_Core.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }   

        public string EscuelaId { get; set; } 
        public Escuela Escuela {get; set; }    
    }
}