using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Curso_ASP_NET_Core.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelas {get; set;}
        public DbSet<Curso> Cursos {get; set;}
        public DbSet<Asignatura> Asignaturas {get; set;}
        public DbSet<Alumno> Alumnos {get; set;}
        public DbSet<Evaluación> Evaluaciones {get; set;}
        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {

        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//haga lo que tiene que hacer 
            
            var escuela = new Escuela();
            escuela.añoFundacion = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Dirección = "cll 142#13-69";
            escuela.Pais ="Colombia";
            escuela.Ciudad = "Bogota"; 

            modelBuilder.Entity<Escuela>().HasData(escuela);


            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura { 
                                 Nombre = "Matematicas",
                                 Id = Guid.NewGuid().ToString()
                               },
                new Asignatura {
                                 Nombre = "Educacion Fisica",
                                 Id = Guid.NewGuid().ToString()
                               },
                new Asignatura { 
                                 Nombre = "Castellano",
                                 Id = Guid.NewGuid().ToString()
                               },
                new Asignatura { 
                                 Nombre = "Ciencias Naturales",
                                 Id = Guid.NewGuid().ToString()
                               },
                new Asignatura { 
                                 Nombre = "Programacion",
                                 Id = Guid.NewGuid().ToString()
                               });   

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());                           
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = {"Cristhian","Julian","Fabio","Andres","Javier","Carlos","Camilo"};
            string[] Apellido1 = {"Gomez","Prada","Lizcanoe","Ortiz","Silva","Toledo","Herrera"};
            string[] nombre2 = {"Julian","Jose","Juan","Osvaldo","Andres","Diomedes","Nicomedes","Teodoro"};

            var listaAlumnos =  from n1 in nombre1 //Esto es un producto cartesiano de los tres arreglos creados
                                from n2 in nombre2
                                from a1 in Apellido1
                                select new Alumno{ 
                                                    Nombre = $"{n1} {n2} {a1}",
                                                    Id = Guid.NewGuid().ToString() 
                                                 };
                                            
            return listaAlumnos.OrderBy( (al) => al.Id ).ToList();            
        }
    }
}
