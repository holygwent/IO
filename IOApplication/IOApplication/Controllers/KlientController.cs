using System;
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
    public class KlientController : Controller
    {
        private SiłowniaEntities db = new SiłowniaEntities();

        // GET: Klient
        public ActionResult Index()
        {
            var klient = db.Klient.Include(k => k.Zajecia);
            return View(klient.ToList());
        }

        // GET: Klient/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klient klient = db.Klient.Find(id);
            if (klient == null)
            {
                return HttpNotFound();
            }
            return View(klient);
        }

        // GET: Klient/Create
        public ActionResult Create()
        {
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa");
            return View();
        }

        // POST: Klient/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdKlienta,Imie,Nazwisko,Adres,Miasto,KodPocztowy,Kraj,Telefon,Email,DataDoladowania,Karnet,DataWygasniecia,IdZajecia,Login,Haslo")] Klient klient)
        {
            if (ModelState.IsValid)
            {
                db.Klient.Add(klient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", klient.IdZajecia);
            return View(klient);
        }

        // GET: Klient/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klient klient = db.Klient.Find(id);
            if (klient == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", klient.IdZajecia);
            return View(klient);
        }

        // POST: Klient/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdKlienta,Imie,Nazwisko,Adres,Miasto,KodPocztowy,Kraj,Telefon,Email,DataDoladowania,Karnet,DataWygasniecia,IdZajecia,Login,Haslo")] Klient klient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(klient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", klient.IdZajecia);
            return View(klient);
        }

        // GET: Klient/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klient klient = db.Klient.Find(id);
            if (klient == null)
            {
                return HttpNotFound();
            }
            return View(klient);
        }

        // POST: Klient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Klient klient = db.Klient.Find(id);
            db.Klient.Remove(klient);
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
