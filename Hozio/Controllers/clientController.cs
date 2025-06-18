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
    public class clientController : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: client
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.sortNameRun = String.IsNullOrEmpty(sortOrder) ? "nameRun" : "";
            ViewBag.sortNameRunDesc = String.IsNullOrEmpty(sortOrder) ? "nameRunDesc" : "";

            var clients = from s in db.clients.Include(c => c.client1s).Include(c => c.hog2s)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                clients = clients.Where(s => s.client1s.name.Contains(searchString)
                                              || s.client1s.domain.Contains(searchString)
                                              || s.hog2s.stringRun.Contains(searchString)
                                              || s.hog2s.stringKeyword.Contains(searchString)
                                              || s.hog2s.location.Contains(searchString)
                                              || s.hog2s.stringContent.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    clients = clients.OrderBy(s => s.client1s.name).ThenBy(s => s.hog2s.run);
                    break;

                case "nameRun":
                    clients = clients.OrderBy(s => s.client1s.name).ThenBy(s => s.hog2s.run);
                    break;

                case "nameRunDesc":
                    clients = clients.OrderByDescending(s => s.client1s.name).ThenByDescending(s => s.hog2s.run);
                    break;
            }
            return View(clients);
        }



        //{
        //    var clients = db.clients.Include(c => c.client1s).Include(c => c.hog2s);
        //    return View(clients.ToList());
        //}

        // GET: client
        public ActionResult Index1()
        {
            var clients = db.clients.Include(c => c.client1s).Include(c => c.hog2s);
            return View(clients.ToList());
        }

        // GET: client/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client client = db.clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: client/Create
        public ActionResult Create()
        {
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name");
            ViewBag.hog2ID = new SelectList(db.hog2s, "hog2ID", "stringRun");
            return View();
        }

        // POST: client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "clientID,client1ID,hog2ID")] client client)
        {
            if (ModelState.IsValid)
            {
                db.clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", client.client1ID);
            ViewBag.hog2ID = new SelectList(db.hog2s, "hog2ID", "stringRun", client.hog2ID);
            return View(client);
        }

        // GET: client/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client client = db.clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", client.client1ID);
            ViewBag.hog2ID = new SelectList(db.hog2s, "hog2ID", "stringRun", client.hog2ID);
            return View(client);
        }

        // POST: client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "clientID,client1ID,hog2ID")] client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", client.client1ID);
            ViewBag.hog2ID = new SelectList(db.hog2s, "hog2ID", "stringRun", client.hog2ID);
            return View(client);
        }

        // GET: client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client client = db.clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            client client = db.clients.Find(id);
            db.clients.Remove(client);
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
