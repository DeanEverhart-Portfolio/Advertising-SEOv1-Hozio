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
    public class ahrefController : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: ahref
        public ActionResult Index()
        {
            return View(db.ahrefs.ToList());
        }

        // GET: ahref/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ahref ahref = db.ahrefs.Find(id);
            if (ahref == null)
            {
                return HttpNotFound();
            }
            return View(ahref);
        }

        // GET: ahref/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ahref/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ahrefID,domain,date,value,stringValue,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] ahref ahref)
        {
            if (ModelState.IsValid)
            {
                db.ahrefs.Add(ahref);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ahref);
        }

        // GET: ahref/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ahref ahref = db.ahrefs.Find(id);
            if (ahref == null)
            {
                return HttpNotFound();
            }
            return View(ahref);
        }

        // POST: ahref/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ahrefID,domain,date,value,stringValue,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] ahref ahref)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ahref).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ahref);
        }

        // GET: ahref/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ahref ahref = db.ahrefs.Find(id);
            if (ahref == null)
            {
                return HttpNotFound();
            }
            return View(ahref);
        }

        // POST: ahref/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ahref ahref = db.ahrefs.Find(id);
            db.ahrefs.Remove(ahref);
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
