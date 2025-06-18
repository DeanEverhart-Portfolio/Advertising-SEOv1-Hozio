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
    public class siteController : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: site
        public ViewResult Index(string sortOrder, string searchString)
        { 
            ViewBag.sortLastName = String.IsNullOrEmpty(sortOrder)? "nameLastDesc" : "";
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder)? "nameDesc" : "";
        
            var sites = from v in db.sites.Include(c => c.ahrefs).Include(c => c.client1s)
                select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                sites = sites.Where(u => u.client1s.name.Contains(searchString)
                                              || u.client1s.domain.Contains(searchString)
                                              || u.ahrefs.domain.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                sites = sites.OrderBy(u => u.client1s.name).ThenBy(u => u.client1s.domain);
                break;

                case "name":
                sites = sites.OrderBy(u => u.client1s.name).ThenBy(u => u.client1s.name);
                break;

                case "nameDesc":
                sites = sites.OrderByDescending(u => u.client1s.name).ThenByDescending(u => u.client1s.name);
                break;
            }
            return View(sites);
        }

        // Original
        //{
        //    var sites = db.sites.Include(s => s.ahrefs).Include(s => s.client1s);
        //    return View(sites.ToList());
        //}

        public ViewResult Index1(string sortOrder, string searchString)
        {
            ViewBag.sortLastName = String.IsNullOrEmpty(sortOrder) ? "nameLastDesc" : "";
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";

            var sites = from v in db.sites.Include(c => c.ahrefs).Include(c => c.client1s)
                        select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                sites = sites.Where(u => u.client1s.name.Contains(searchString)
                                              || u.client1s.domain.Contains(searchString)
                                              || u.ahrefs.domain.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    sites = sites.OrderBy(u => u.client1s.name).ThenBy(u => u.client1s.domain);
                    break;

                case "name":
                    sites = sites.OrderBy(u => u.client1s.name).ThenBy(u => u.client1s.name);
                    break;

                case "nameDesc":
                    sites = sites.OrderByDescending(u => u.client1s.name).ThenByDescending(u => u.client1s.name);
                    break;
            }
            return View(sites);
        }

        // GET: site/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            site site = db.sites.Find(id);
            if (site == null)
            {
                return HttpNotFound();
            }
            return View(site);
        }

        // GET: site/Create
        public ActionResult Create()
        {
            ViewBag.ahrefID = new SelectList(db.ahrefs, "ahrefID", "domain");
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name");
            return View();
        }

        // POST: site/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "siteID,client1ID,ahrefID")] site site)
        {
            if (ModelState.IsValid)
            {
                db.sites.Add(site);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ahrefID = new SelectList(db.ahrefs, "ahrefID", "domain", site.ahrefID);
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", site.client1ID);
            return View(site);
        }

        // GET: site/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            site site = db.sites.Find(id);
            if (site == null)
            {
                return HttpNotFound();
            }
            ViewBag.ahrefID = new SelectList(db.ahrefs, "ahrefID", "domain", site.ahrefID);
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", site.client1ID);
            return View(site);
        }

        // POST: site/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "siteID,client1ID,ahrefID")] site site)
        {
            if (ModelState.IsValid)
            {
                db.Entry(site).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ahrefID = new SelectList(db.ahrefs, "ahrefID", "domain", site.ahrefID);
            ViewBag.client1ID = new SelectList(db.client1s, "client1ID", "name", site.client1ID);
            return View(site);
        }

        // GET: site/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            site site = db.sites.Find(id);
            if (site == null)
            {
                return HttpNotFound();
            }
            return View(site);
        }

        // POST: site/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            site site = db.sites.Find(id);
            db.sites.Remove(site);
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
