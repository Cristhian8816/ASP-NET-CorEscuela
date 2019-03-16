using System;

namespace Curso_ASP_NET_Core.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public virtual string Id { get; set; }
        public virtual string Nombre { get; set; }        

        public ObjetoEscuelaBase()
        {
           
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}