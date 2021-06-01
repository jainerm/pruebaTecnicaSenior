using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pruebaParaPrimeStone.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext()
            :base("DefaultConnection")
        {

        }

        public DbSet<cursoestudiantes> cursoestudiantes { get; set; }
        public DbSet<cursos> cursos { get; set; }
        public DbSet<direccionestudiantes> direccionestudiantes { get; set; }
        public DbSet<Estudiantes> estudiantes { get; set; }

    }
}