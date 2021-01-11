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
    public class KarnetController : Controller
    {
        private SiłowniaEntities2 db = new SiłowniaEntities2();

        // GET: Karnet
        public ActionResult Index()
        {
            return View(db.Karnet.ToList());
        }

        // GET: Karnet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karnet karnet = db.Karnet.Find(id);
            if (karnet == null)
            {
                return HttpNotFound();
            }
            return View(karnet);
        }

        // GET: Karnet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Karnet/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Dni,Koszt")] Karnet karnet)
        {
            if (ModelState.IsValid)
            {
                db.Karnet.Add(karnet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(karnet);
        }

        // GET: Karnet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karnet karnet = db.Karnet.Find(id);
            if (karnet == null)
            {
                return HttpNotFound();
            }
            return View(karnet);
        }

        // POST: Karnet/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Dni,Koszt")] Karnet karnet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(karnet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(karnet);
        }

        // GET: Karnet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karnet karnet = db.Karnet.Find(id);
            if (karnet == null)
            {
                return HttpNotFound();
            }
            return View(karnet);
        }

        // POST: Karnet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Karnet karnet = db.Karnet.Find(id);
            db.Karnet.Remove(karnet);
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
