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
    public class documentController : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: document
        public ActionResult Index()
        {
            return View(db.documents.ToList());
        }

        // GET: document
        public ActionResult Index1()
        {
            return View(db.documents.ToList());
        }

        // GET: document
        public ActionResult hoziU()
        {
            return View(db.documents.ToList());
        }

        // GET: document/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            document document = db.documents.Find(id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        // GET: document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: document/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "documentID,name,access,accessLabel,accessSort,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] document document)
        {
            if (ModelState.IsValid)
            {
                db.documents.Add(document);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(document);
        }

        // GET: document/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            document document = db.documents.Find(id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        // POST: document/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "documentID,name,access,accessLabel,accessSort,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] document document)
        {
            if (ModelState.IsValid)
            {
                db.Entry(document).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(document);
        }

        // GET: document/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            document document = db.documents.Find(id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        // POST: document/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            document document = db.documents.Find(id);
            db.documents.Remove(document);
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
