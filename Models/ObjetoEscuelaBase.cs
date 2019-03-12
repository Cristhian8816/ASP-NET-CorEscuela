using System;

namespace Curso_ASP_NET_Core.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
           
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}