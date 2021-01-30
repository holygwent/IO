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
        private SiłowniaEntities2 db = new SiłowniaEntities2();

        // GET: Klient
        public ActionResult Index(string searching)
        {
         //   var klient = db.Klient.Include(k => k.Zajecia);
            var collection = from k in db.Klient.Include(k => k.Zajecia).Include(k=>k.Karnet1)
                             orderby k.Nazwisko ascending,k.Imie ascending
                             where k!= null
                             select k
                             ;
            if (!string.IsNullOrEmpty(searching))
            {

                if (searching.Contains(' '))
                {
                    string[] tab = new string[2];
                    string firstName, lastName;
                    tab = searching.Split(' ');
                    if (tab[1] == null)
                    {
                        tab[1] = " ";
                    }
                    else if (tab[0] == null)
                    {
                        tab[0] = " ";
                    }
                    firstName = tab[0];
                    lastName = tab[1];//wyjatek przy wpisaniu 1 słowa

                    collection = from k in db.Klient.Include(k => k.Zajecia).Include(k => k.Karnet1)
                                 orderby k.Nazwisko ascending, k.Imie ascending
                                 where k.Nazwisko == lastName && k.Imie == firstName
                                 select k;
                    if (collection.ToList().Count == 0)
                    {
                        firstName = tab[1];
                        lastName = tab[0];
                        collection = from k in db.Klient.Include(k => k.Zajecia).Include(k => k.Karnet1)
                                     orderby k.Nazwisko ascending, k.Imie ascending
                                     where k.Nazwisko == lastName && k.Imie == firstName
                                     select k;
                    }
                }
                else
                {
                    collection = db.Klient.Include(k => k.Zajecia).Include(k => k.Karnet1).Where(x => x.Imie == searching);
                      if(collection.ToList().Count==0)
                    collection = db.Klient.Include(k => k.Zajecia).Include(k => k.Karnet1).Where(x => x.Nazwisko== searching);
                }
            }
            return View(collection.ToList());
        }
        // GET: Klient
        public ActionResult FiltrLapsed()
        {
            //   var klient = db.Klient.Include(k => k.Zajecia);
            var collection = from k in db.Klient.Include(k => k.Zajecia).Include(k => k.Karnet1)
                             orderby k.Nazwisko ascending, k.Imie ascending
                             where k.DataWygasniecia < DateTime.Now
                             select k
                             ;
            return View(collection.ToList());
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
            ViewBag.Karnet = new SelectList(db.Karnet, "Id", "Dni");
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

                klient.DataDoladowania = DateTime.Now;
                var Listdays = from k in db.Karnet
                                 where k.Id == klient.Karnet
                                 select (double)k.Dni;
                
                
                klient.DataWygasniecia = klient.DataDoladowania.AddDays(Listdays.First());
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", klient.IdZajecia);
            ViewBag.Karnet = new SelectList(db.Karnet, "Id", "Dni", klient.Karnet);//tu
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
            ViewBag.Karnet = new SelectList(db.Karnet, "Id", "Dni", klient.Karnet);
          
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
                var Listdays = from k in db.Karnet
                               where k.Id == klient.Karnet
                               select (double)k.Dni;


                klient.DataWygasniecia = klient.DataDoladowania.AddDays(Listdays.First());

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdZajecia = new SelectList(db.Zajecia, "IdZajecia", "Nazwa", klient.IdZajecia);
            ViewBag.Karnet = new SelectList(db.Karnet, "Id", "Dni", klient.Karnet);
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
