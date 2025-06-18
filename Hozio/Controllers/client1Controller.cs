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
    public class client1Controller : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: client1
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";

            var client1s = from s in db.client1s
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                client1s = client1s.Where(s => s.name.Contains(searchString)
                                              || s.name.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                    client1s = client1s.OrderBy(s => s.name);
                    break;

                case "name":
                    client1s = client1s.OrderBy(s => s.name);
                    break;

                case "nameDesc":
                    client1s = client1s.OrderByDescending(s => s.name);
                    break;
            }

            return View(client1s);
        }

        // GET: client1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client1 client1 = db.client1s.Find(id);
            if (client1 == null)
            {
                return HttpNotFound();
            }
            return View(client1);
        }

        // GET: client1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: client1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "client1ID,name,domain,domain1,crm,crm1,designator,type,type1,dategory,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] client1 client1)
        {
            if (ModelState.IsValid)
            {
                db.client1s.Add(client1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client1);
        }

        // GET: client1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client1 client1 = db.client1s.Find(id);
            if (client1 == null)
            {
                return HttpNotFound();
            }
            return View(client1);
        }

        // POST: client1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "client1ID,name,domain,domain1,crm,crm1,designator,type,type1,dategory,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] client1 client1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client1);
        }

        // GET: client1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client1 client1 = db.client1s.Find(id);
            if (client1 == null)
            {
                return HttpNotFound();
            }
            return View(client1);
        }

        // POST: client1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            client1 client1 = db.client1s.Find(id);
            db.client1s.Remove(client1);
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
