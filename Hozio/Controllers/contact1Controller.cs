using Hozio.data;
using Hozio.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
//
using System;                   // String


namespace Hozio.Controllers
{
    public class contact1Controller : Controller
    {
        private hdalContext db = new hdalContext();

        // GET: contact1
        public ViewResult Index(string sortOrder, string searchString)
        { 
            ViewBag.sortName = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";
        
            var contact1s = from s in db.contact1s
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contact1s = contact1s.Where(s => s.lastName.Contains(searchString)
                                              || s.firstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                default:
                contact1s = contact1s.OrderBy(s => s.lastName).ThenBy(s => s.firstName);
                break;

                case "name":
                contact1s = contact1s.OrderBy(s => s.lastName).ThenBy(s => s.firstName);
                break;

                case "nameDesc":
                contact1s = contact1s.OrderByDescending(s => s.lastName).ThenByDescending(s => s.firstName);
                break;
            }
            return View(contact1s);
        }

        // GET: contact1/Details/5
        public ActionResult Details(int? id)
{
    if (id == null)
    {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    }
    contact1 contact1 = db.contact1s.Find(id);
    if (contact1 == null)
    {
        return HttpNotFound();
    }
    return View(contact1);
}

// GET: contact1/Create
public ActionResult Create()
{
    return View();
}

// POST: contact1/Create
// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
[ValidateAntiForgeryToken]
//                                                         address                                                                                                                                                          email                                                                 name                                    phone                                                                                    website                                                                                                                             

public ActionResult Create([Bind(Include = "contact1ID,aka,addressStreetNumber,addressStreetName,addressStreetDesignator,addressStreet2,addressTownCity,addressState,addressZipCode,addressCounty,addressCountry,addressURL,email,emailLabel,email1,email1Label,email2,email2Label,domain,domain1,firstName,lastName,middleName,phoneLabel,phoneLabel,phoneAreaCode,phonePrefix,phoneLine,phoneExtension,phoneGatekeeper,phoneNote,phoneSort,website,websiteLabel,website1,website1Label,website2,website2Label,doh,dos,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] contact1 contact1)
{
    if (ModelState.IsValid)
    {
        db.contact1s.Add(contact1);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(contact1);
}

// GET: contact1/Edit/5
public ActionResult Edit(int? id)
{
    if (id == null)
    {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    }
    contact1 contact1 = db.contact1s.Find(id);
    if (contact1 == null)
    {
        return HttpNotFound();
    }
    return View(contact1);
}

// POST: contact1/Edit/5
// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
[ValidateAntiForgeryToken]
//                                                       address                                                                                                                                                          email                                                                 name                                    phone                                                                                   website                                                                                                                             
public ActionResult Edit([Bind(Include = "contact1ID,aka,addressStreetNumber,addressStreetName,addressStreetDesignator,addressStreet2,addressTownCity,addressState,addressZipCode,addressCounty,addressCountry,addressURL,email,emailLabel,email1,email1Label,email2,email2Label,domain,domain1,firstName,lastName,middleName,phoneLabel,phoneLabel,phoneAreaCode,phonePrefix,phoneLine,phoneExtension,phoneGatekeeper,phoneNote,phoneSort,website,websiteLabel,website1,website1Label,website2,website2Label,doh,dos,designator,type,type1,category,category1,tier,boolTier,stringTier,rank,stringRank,note,note1,text,text1,sort,sort1,tag,tag1,label,label1,boolFlag,flag,boolFlag1,flag1,select,select1,start,end,dateEnd,inactive,dateInactive,hold,dateHold,recordCreated,recordInactive,dateRecordInactive")] contact1 contact1)
{
    if (ModelState.IsValid)
    {
        db.Entry(contact1).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(contact1);
}

// GET: contact1/Delete/5
public ActionResult Delete(int? id)
{
    if (id == null)
    {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    }
    contact1 contact1 = db.contact1s.Find(id);
    if (contact1 == null)
    {
        return HttpNotFound();
    }
    return View(contact1);
}

// POST: contact1/Delete/5
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public ActionResult DeleteConfirmed(int id)
{
    contact1 contact1 = db.contact1s.Find(id);
    db.contact1s.Remove(contact1);
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
