using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projeto_Psi.Context;
using Projeto_Psi.Models;

namespace Projeto_Psi.Controllers
{
    public class CategoriasController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Index Categorias
        public ActionResult Index()
        {
            return View(context.Categorias.OrderBy(c => c.Nome));
        }
        
        // GET: Create Categorias
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create Categorias
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit Categorias
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Edit Categorias
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                context.Entry(categoria).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        // GET: Details Categorias
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // GET: Delete Categorias
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Delete Categorias
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Categoria categoria = context.Categorias.Find(id);
            context.Categorias.Remove(categoria);
            context.SaveChanges();
            TempData["Message"] = "Categoria " + categoria.Nome.ToUpper() + " foi removido";
            return RedirectToAction("Index");
        }
    }
}