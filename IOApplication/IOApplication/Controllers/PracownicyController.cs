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
    public class PracownicyController : Controller
    {
        private SiłowniaEntities db = new SiłowniaEntities();

        // GET: Pracownicy
        public ActionResult Index()
        {
            var collection = from p in db.Pracownicy
                             orderby p.Nazwisko ascending, p.Imie ascending
                             select p;
            return View(collection.ToList());
        }

        // GET: Pracownicy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pracownicy pracownicy = db.Pracownicy.Find(id);
            if (pracownicy == null)
            {
                return HttpNotFound();
            }
            return View(pracownicy);
        }

        // GET: Pracownicy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pracownicy/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPracownika,Imie,Nazwisko,Adres,Miasto,KodPocztowy,Kraj,Email,Telefon,Pesel,DataUrodzenia,DataZatrudnienia,NrBankowy,Login,Haslo")] Pracownicy pracownicy)
        {
            if (ModelState.IsValid)
            {
                db.Pracownicy.Add(pracownicy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pracownicy);
        }

        // GET: Pracownicy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pracownicy pracownicy = db.Pracownicy.Find(id);
            if (pracownicy == null)
            {
                return HttpNotFound();
            }
            return View(pracownicy);
        }

        // POST: Pracownicy/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPracownika,Imie,Nazwisko,Adres,Miasto,KodPocztowy,Kraj,Email,Telefon,Pesel,DataUrodzenia,DataZatrudnienia,NrBankowy,Login,Haslo")] Pracownicy pracownicy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pracownicy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pracownicy);
        }

        // GET: Pracownicy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pracownicy pracownicy = db.Pracownicy.Find(id);
            if (pracownicy == null)
            {
                return HttpNotFound();
            }
            return View(pracownicy);
        }

        // POST: Pracownicy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pracownicy pracownicy = db.Pracownicy.Find(id);
            db.Pracownicy.Remove(pracownicy);
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
