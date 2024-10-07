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
    public class ParticipantController : Controller
    {
        private CEMS_To_DB_Context db = new CEMS_To_DB_Context();
        // GET: Participant
        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        // GET: Participant/Details/5
        public ActionResult Details(int? id)
        {
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

        // GET: Participant/Register/5
        public ActionResult Register(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventID = @event.EventID;
            ViewBag.EventTitle = @event.Title;
            ViewBag.EventDescription = @event.Description;
            return View();
        }

        // POST: Participant/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "RegistrationID,EventID,FirstName,LastName,Email")] Registration @registration)
        {
            if (ModelState.IsValid)
            {
                db.Registrations.Add(@registration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@registration);
        }
    }
}