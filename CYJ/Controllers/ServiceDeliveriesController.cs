using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CYJ.Models;

namespace CYJ.Controllers
{
    public class ServiceDeliveriesController : Controller
    {
        private cyjEntities db = new cyjEntities();

        // GET: ServiceDeliveries
        public ActionResult Index()
        {
            return View(db.ServiceDeliveries.ToList());
        }

        // GET: ServiceDeliveries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceDelivery serviceDelivery = db.ServiceDeliveries.Find(id);
            if (serviceDelivery == null)
            {
                return HttpNotFound();
            }
            return View(serviceDelivery);
        }

        // GET: ServiceDeliveries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceDeliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,teamName,workstreamName,categoryName,subcategoryName,goalName,goalValue")] ServiceDelivery serviceDelivery)
        {
            if (ModelState.IsValid)
            {
                db.ServiceDeliveries.Add(serviceDelivery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceDelivery);
        }

        // GET: ServiceDeliveries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceDelivery serviceDelivery = db.ServiceDeliveries.Find(id);
            if (serviceDelivery == null)
            {
                return HttpNotFound();
            }
            return View(serviceDelivery);
        }

        // POST: ServiceDeliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,teamName,workstreamName,categoryName,subcategoryName,goalName,goalValue")] ServiceDelivery serviceDelivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceDelivery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceDelivery);
        }

        // GET: ServiceDeliveries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceDelivery serviceDelivery = db.ServiceDeliveries.Find(id);
            if (serviceDelivery == null)
            {
                return HttpNotFound();
            }
            return View(serviceDelivery);
        }

        // POST: ServiceDeliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceDelivery serviceDelivery = db.ServiceDeliveries.Find(id);
            db.ServiceDeliveries.Remove(serviceDelivery);
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
