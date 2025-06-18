using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hozio.Models;
using Hozio.data;

namespace Hozio.Controllers
{
    public class contactController : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: contact
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.sortLastName = String.IsNullOrEmpty(sortOrder) ? "nameLastDesc" : "";
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";

            var contacts = from s in db.contacts.Include(c => c.client1s).Include(c => c.contact1s)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.contact1s.lastName.Contains(searchString)
                                              || s.contact1s.firstName.Contains(searchString)
                                              || s.client1s.name.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameLast":
                    contacts = contacts.OrderBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameLastDesc":
                    contacts = contacts.OrderByDescending(s => s.contact1s.lastName).ThenByDescending(s => s.contact1s.firstName);
                    break;

                case "name":
                    contacts = contacts.OrderBy(s => s.client1s.name).ThenBy(s => s.client1s.name);
                    break;

                case "nameDesc":
                    contacts = contacts.OrderByDescending(s => s.client1s.name).ThenByDescending(s => s.client1s.name);
                    break;
            }
            return View(contacts);
        }

        public ActionResult Index1(string sortOrder, string searchString)
        {
            ViewBag.sortLastName = String.IsNullOrEmpty(sortOrder) ? "nameLastDesc" : "";
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";

            var contacts = from s in db.contacts.Include(c => c.client1s).Include(c => c.contact1s)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.contact1s.lastName.Contains(searchString)
                                              || s.contact1s.firstName.Contains(searchString)
                                              || s.client1s.name.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameLast":
                    contacts = contacts.OrderBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameLastDesc":
                    contacts = contacts.OrderByDescending(s => s.contact1s.lastName).ThenByDescending(s => s.contact1s.firstName);
                    break;

                case "name":
                    contacts = contacts.OrderBy(s => s.client1s.name).ThenBy(s => s.client1s.name);
                    break;

                case "nameDesc":
                    contacts = contacts.OrderByDescending(s => s.client1s.name).ThenByDescending(s => s.client1s.name);
                    break;
            }
            return View(contacts);
        }
            //{
            //    //var contacts = db.contacts.Include(c => c.client1s).Include(c => c.contact1s);
            //    //return View(contacts.ToList());
            //}

            // GET: client
            public ActionResult client(string sortOrder, string searchString)
        {
            ViewBag.sortNameContact = String.IsNullOrEmpty(sortOrder) ? "nameContact" : "";
            ViewBag.sortNameContactDesc = String.IsNullOrEmpty(sortOrder) ? "nameContactDesc" : "";

            var contacts = from s in db.contacts.Include(c => c.client1s).Include(c => c.contact1s)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.contact1s.lastName.Contains(searchString)
                                            || s.contact1s.firstName.Contains(searchString)
                                            || s.client1s.name.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.client1s.name).ThenBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameContact":
                    contacts = contacts.OrderBy(s => s.client1s.name).ThenBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameContactDesc":
                    contacts = contacts.OrderByDescending(s => s.client1s.name).ThenByDescending(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;
            }
            return View(contacts);
        }

        //{
        //    var contacts = db.contacts.Include(c => c.client1s).Include(c => c.contact1s);
        //    return View(contacts.ToList());
        //}


        // GET: client1
        public ActionResult client1(string sortOrder, string searchString)
        {
            ViewBag.sortLastName = String.IsNullOrEmpty(sortOrder) ? "nameLastDesc" : "";
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";

            var contacts = from s in db.contacts.Include(c => c.client1s).Include(c => c.contact1s)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.contact1s.lastName.Contains(searchString)
                                            || s.contact1s.firstName.Contains(searchString)
                                            || s.client1s.name.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameLast":
                    contacts = contacts.OrderBy(s => s.contact1s.lastName).ThenBy(s => s.contact1s.firstName);
                    break;

                case "nameLastDesc":
                    contacts = contacts.OrderByDescending(s => s.contact1s.lastName).ThenByDescending(s => s.contact1s.firstName);
                    break;

                case "name":
                    contacts = contacts.OrderBy(s => s.client1s.name).ThenBy(s => s.client1s.name);
                    break;

                case "nameDesc":
                    contacts = contacts.OrderByDescending(s => s.client1s.name).ThenByDescending(s => s.client1s.name);
                    break;
            }
            return View(contacts);
        }

        // GET: contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: contact/Create
        public ActionResult Create()
        {
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name");
            ViewBag.contact1ID = new SelectList(db.contact1s, "contact1ID", "firstName");
            return View();
        }

        // POST: contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "contactID,contact1ID,client1ID")] contact contact)
        {
            if (ModelState.IsValid)
            {
                db.contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", contact.client1ID);
            ViewBag.contact1ID = new SelectList(db.contact1s, "contact1ID", "firstName", contact.contact1ID);
            return View(contact);
        }

        // GET: contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", contact.client1ID);
            ViewBag.contact1ID = new SelectList(db.contact1s, "contact1ID", "firstName", "lastName", contact.contact1ID);
            return View(contact);
        }

        // POST: contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "contactID,contact1ID,client1ID")] contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", contact.client1ID);
            ViewBag.contact1ID = new SelectList(db.contact1s, "contact1ID", "firstName", contact.contact1ID);
            return View(contact);
        }

        // GET: contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contact contact = db.contacts.Find(id);
            db.contacts.Remove(contact);
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
