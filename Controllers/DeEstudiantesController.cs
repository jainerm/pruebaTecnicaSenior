using pruebaParaPrimeStone.Models;
using pruebaParaPrimeStone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebaParaPrimeStone.Controllers
{
    public class DeEstudiantesController : Controller
    {
        private DeEstudiantesLista _repo;
        
        public DeEstudiantesController()
        {
            _repo = new DeEstudiantesLista();
        }
        // GET: Prueba
        public ActionResult Index()
        {
            var model = _repo.ObtieneEstudiantes();
            return View(model);
        }

        // GET: Prueba/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prueba/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Prueba/Create
        [HttpPost]
        public ActionResult Create(Estudiantes model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repo.Crear(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // Log de errores ex...
            }
            return View();
        }

        // GET: Prueba/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prueba/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prueba/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prueba/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
