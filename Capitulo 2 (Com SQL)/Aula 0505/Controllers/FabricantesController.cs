﻿using Aula_0505.Context;
using Aula_0505.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula_0505.Controllers
{
    public class FabricantesController : Controller
    {
        public EFContext context = new EFContext();

        
        private static IList<Fabricante> fabricantes = new List<Fabricante>()
        {
            new Fabricante() { FabricanteId = 1, Nome = "LG"},
            new Fabricante() { FabricanteId = 2, Nome = "Microsoft"},
        };
        

        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(
                //fabricantes
                context.Fabricantes.OrderBy(c => c.Nome)
                );
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            context.Fabricantes.Add(fabricante);
            context.SaveChanges();

            //fabricantes.Add(fabricante);
            return RedirectToAction("Index");
        }

        // GET: Fabricantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = context.Fabricantes.Find(id);
            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();
            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        // POST: Fabricantes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                /* fabricantes.Remove(
                    fabricantes.Where(c => c.FabricanteId == fabricante.FabricanteId).First());
                fabricantes.Add(fabricante); */

                context.Entry(fabricante).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fabricante);
        }

        // GET: Fabricantes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = context.Fabricantes.Find(id);
            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();

            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        // GET: Fabricantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = context.Fabricantes.Find(id);

            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();
            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        // POST: Fabricantes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Fabricante fabricante = context.Fabricantes.Find(id);
            context.Fabricantes.Remove(fabricante);
            context.SaveChanges();

            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();
            //fabricantes.Remove(fabricante);
            return RedirectToAction("Index");
        }
    }
}