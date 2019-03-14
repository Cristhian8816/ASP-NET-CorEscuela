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

        //Constructor que se requiere por convencion
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
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";            

            //Cargar cursos de la Escuela
            var cursos = CargarCursos(escuela);

            //X Cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            //X Cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos); 

            //llenamos nuestra DB inMemory
            modelBuilder.Entity<Escuela>().HasData(escuela); 
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());       
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray()); 
           
        }

        private static  List<Curso> CargarCursos(Escuela escuela)
        {
            var escCursos = new List<Curso>()
            {
             new Curso()
             {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "101", Jornada = TiposJornada.Mañana},
             new Curso()
             {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "201", Jornada = TiposJornada.Mañana},
             new Curso()
             {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "301", Jornada = TiposJornada.Mañana},
             new Curso()
             {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "401", Jornada = TiposJornada.Tarde},
             new Curso()
             {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "501", Jornada = TiposJornada.Tarde},
            };

            return(escCursos);
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura>{
                  new Asignatura{Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre="Matematicas"},
                  new Asignatura{Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre="Castellano"},
                  new Asignatura{Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre="Educacion Fisica"},
                  new Asignatura{Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre="Ciencias Naturales"},
                  new Asignatura{Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre="Programacion"}
                };
                listaCompleta.AddRange(tmpList);                
            }
            return(listaCompleta);
        }  

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
          var listaAlumnos = new List<Alumno>();
          Random rnd = new Random();
          foreach (var curso in cursos)
          {
              int cantRandom = rnd.Next(5, 20);
              var tmplist = GenerarAlumnosAlAzar(curso,cantRandom);
              listaAlumnos.AddRange(tmplist);
          }
          return(listaAlumnos);
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = {"Cristhian","Fabio","Juan","Javier","Carlos","Juan"};
            string[] Apellido1 = {"Gomez","Prada","Lizcano","Lizcano","Ortiz","Silva"};
            string[] nombre2 = {"Julian","Jose","Andres","Osvaldo","Andres","Camilo"};

            var listaAlumnos =  from n1 in nombre1 //Esto es un producto cartesiano de los tres arreglos creados
                                from n2 in nombre2
                                from a1 in Apellido1
                                select new Alumno{ CursoId = curso.Id,
                                                   Nombre = $"{n1} {n2} {a1}",
                                                   Id = Guid.NewGuid().ToString() 
                                                 };
                                            
            return listaAlumnos.OrderBy( (al) => al.Id ).Take(cantidad).ToList();            
        }
    }
}
