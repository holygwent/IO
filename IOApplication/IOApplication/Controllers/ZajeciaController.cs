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
    public class ZajeciaController : Controller
    {
        private SiłowniaEntities db = new SiłowniaEntities();

        // GET: Zajecia
        public ActionResult Index()
        {
            return View(db.Zajecia.ToList());
        }

        // GET: Zajecia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zajecia zajecia = db.Zajecia.Find(id);
            if (zajecia == null)
            {
                return HttpNotFound();
            }
            return View(zajecia);
        }

        // GET: Zajecia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zajecia/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdZajecia,Nazwa,Godzina")] Zajecia zajecia)
        {
            if (ModelState.IsValid)
            {
                db.Zajecia.Add(zajecia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zajecia);
        }

        // GET: Zajecia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zajecia zajecia = db.Zajecia.Find(id);
            if (zajecia == null)
            {
                return HttpNotFound();
            }
            return View(zajecia);
        }

        // POST: Zajecia/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdZajecia,Nazwa,Godzina")] Zajecia zajecia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zajecia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zajecia);
        }

        // GET: Zajecia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zajecia zajecia = db.Zajecia.Find(id);
            if (zajecia == null)
            {
                return HttpNotFound();
            }
            return View(zajecia);
        }

        // POST: Zajecia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zajecia zajecia = db.Zajecia.Find(id);
            db.Zajecia.Remove(zajecia);
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
