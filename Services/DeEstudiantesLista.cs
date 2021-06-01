using pruebaParaPrimeStone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaParaPrimeStone.Services
{
    public class DeEstudiantesLista
    {
        public List<Estudiantes> ObtieneEstudiantes()
        {
            using (var db = new MyDbContext())
            {
                return db.estudiantes.ToList();
            }
        }

        internal void Crear(Estudiantes model)
        {
            using (var db = new MyDbContext())
            {
                db.estudiantes.Add(model);
                db.SaveChanges();
            }

        }
    }
}