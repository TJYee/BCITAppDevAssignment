// This Controller handles Admin Panel related actions for the Admin User

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BCITAppDevAssignment;

namespace BCITAppDevAssignment.Controllers
{
    public class EventController : Controller
    {
        private CEMS_To_DB_Context db = new CEMS_To_DB_Context();

        // GET: Event
        public ActionResult Index()
        {
            // Requires Admin Login to view Admin Panel
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            return View(db.Events.ToList());
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            Registration registration = db.Registrations.Find(id);
            if (registration == null)
            {
                ViewBag.Registrations = db.Registrations.SqlQuery("SELECT * FROM Registrations WHERE EventID = " + id).ToList();
            }
            return View(@event);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,Title,Description,StartDateTime,EndDateTime,Location")] Event @event)
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventID,Title,Description,StartDateTime,EndDateTime,Location")] Event @event)
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Requires Admin Session to Create new Event
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
