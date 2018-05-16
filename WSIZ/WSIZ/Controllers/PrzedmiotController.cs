using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WSIZ.DAL;
using WSIZ.Models;

namespace WSIZ.Controllers
{
    public class PrzedmiotController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: Przedmiot
        public ActionResult Index()
        {
            return View(db.Przedmiot.ToList());
        }

        // GET: Przedmiot/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przedmiot przedmiot = db.Przedmiot.Find(id);
            if (przedmiot == null)
            {
                return HttpNotFound();
            }
            return View(przedmiot);
        }

        // GET: Przedmiot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Przedmiot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PrzedmiotID,KategoriaID,NazwaPrzedmiotu,ProducentPrzedmiotu,DataDodania,OpisPrzedmiotu,CenaPrzedmiotu")] Przedmiot przedmiot)
        {
            if (ModelState.IsValid)
            {
                db.Przedmiot.Add(przedmiot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(przedmiot);
        }

        // GET: Przedmiot/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przedmiot przedmiot = db.Przedmiot.Find(id);
            if (przedmiot == null)
            {
                return HttpNotFound();
            }
            return View(przedmiot);
        }

        // POST: Przedmiot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PrzedmiotID,KategoriaID,NazwaPrzedmiotu,ProducentPrzedmiotu,DataDodania,OpisPrzedmiotu,CenaPrzedmiotu")] Przedmiot przedmiot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(przedmiot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(przedmiot);
        }

        // GET: Przedmiot/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przedmiot przedmiot = db.Przedmiot.Find(id);
            if (przedmiot == null)
            {
                return HttpNotFound();
            }
            return View(przedmiot);
        }

        // POST: Przedmiot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Przedmiot przedmiot = db.Przedmiot.Find(id);
            db.Przedmiot.Remove(przedmiot);
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
