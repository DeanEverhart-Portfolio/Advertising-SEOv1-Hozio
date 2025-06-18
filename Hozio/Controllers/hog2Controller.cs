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
    public class hog2Controller : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: hog2
        public ActionResult Index()
        {
            return View(db.hog2s.ToList());
        }

        // GET: hog2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hog2 hog2 = db.hog2s.Find(id);
            if (hog2 == null)
            {
                return HttpNotFound();
            }
            return View(hog2);
        }

        // GET: hog2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hog2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "hog2ID,run,stringRun,template,dateTemplate,location,keyword,stringKeyword,stringKeyword1,content,content1,dateContent,dateContent1,stringContent,html,dateHtml,meta,stringMeta,dateMeta,seo,dateSeo,plugin,datePlugin,hero,hero1,stringHero,dateHero,backup,stringBackup,dateBackup,buildExport,dateBuildExport,stringBuildExport,hog1,dateHog,stringHog,post,stringPost,datePost,site,dateSite,stringSite,dev,hogOld,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] hog2 hog2)
        {
            if (ModelState.IsValid)
            {
                db.hog2s.Add(hog2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hog2);
        }

        // GET: hog2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hog2 hog2 = db.hog2s.Find(id);
            if (hog2 == null)
            {
                return HttpNotFound();
            }
            return View(hog2);
        }

        // POST: hog2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "hog2ID,run,stringRun,template,dateTemplate,location,keyword,stringKeyword,stringKeyword1,content,content1,dateContent,dateContent1,stringContent,html,dateHtml,meta,stringMeta,dateMeta,seo,dateSeo,plugin,datePlugin,hero,hero1,stringHero,dateHero,backup,stringBackup,dateBackup,buildExport,dateBuildExport,stringBuildExport,hog1,dateHog,stringHog,post,stringPost,datePost,site,dateSite,stringSite,dev,hogOld,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] hog2 hog2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hog2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hog2);
        }

        // GET: hog2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hog2 hog2 = db.hog2s.Find(id);
            if (hog2 == null)
            {
                return HttpNotFound();
            }
            return View(hog2);
        }

        // POST: hog2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hog2 hog2 = db.hog2s.Find(id);
            db.hog2s.Remove(hog2);
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
