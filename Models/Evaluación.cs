using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace platzi_asp_net_core.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Asignatura Asignatura  { get; set; }
        public string AsignaturaId { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:n1}")]
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}