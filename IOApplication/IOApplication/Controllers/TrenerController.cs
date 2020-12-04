﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IOApplication.Models;

namespace IOApplication.Controllers
{
    public class TrenerController : Controller
    {
        private SiłowniaEntities db = new SiłowniaEntities();

        // GET: Trener
        public ActionResult Index()
        {
            var trener = db.Trener.Include(t => t.Zajecia);
            return View(trener.ToList());
        }

        // GET: Trener/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Trener.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // GET: Trener/Create
        public ActionResult Create()
        {
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa");
            return View();
        }

        // POST: Trener/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTrener,Imie,Nazwisko,Adres,Miasto,KodPocztowy,Kraj,Email,Telefon,Pesel,DataUrodzenia,DataZatrudnienia,IdZajecia,NrBankowy")] Trener trener)
        {
            if (ModelState.IsValid)
            {
                db.Trener.Add(trener);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", trener.IdZajecia);
            return View(trener);
        }

        // GET: Trener/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Trener.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", trener.IdZajecia);
            return View(trener);
        }

        // POST: Trener/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTrener,Imie,Nazwisko,Adres,Miasto,KodPocztowy,Kraj,Email,Telefon,Pesel,DataUrodzenia,DataZatrudnienia,IdZajecia,NrBankowy")] Trener trener)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trener).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", trener.IdZajecia);
            return View(trener);
        }

        // GET: Trener/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Trener.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // POST: Trener/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trener trener = db.Trener.Find(id);
            db.Trener.Remove(trener);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}