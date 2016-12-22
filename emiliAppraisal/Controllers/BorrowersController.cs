using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using emiliAppraisal.DAL;
using emiliAppraisal.Models;
using System.Data.Entity.Core.Objects;

namespace emiliAppraisal.Controllers
{
    public class BorrowersController : Controller
    {
        private emiliDB db = new emiliDB();

        // GET: Borrowers
        public ActionResult Index()
        {
            var bb = from b in  db.Borrowers
                     select b;

            //bb.ToList();

            var merchant = db.Borrowers
                          .Include("qualifying")
                          .Include("currentAddress")
                          .Take(2);

            emiliEntities zz = new emiliEntities();
            int jj = 0;
            int qq =0;
            int nextcmhcno = zz.GetNextCMHCNo(qq, jj);

            //var aa = merchant.currentAddress.postalCode;

            //foreach (Borrower b in bb )
            //{
            //    //db.Entry(b).Reference(a => a.currentAddress).Load();
            //    //db.Entry(b).Reference(a => a.qualifying).Load();
            //    //Console.Write(b.currentAddress.municipality + b.qualifying.genericScore);

            //}

            return View(bb.ToList());
        }

        // GET: Borrowers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrower borrower = db.Borrowers.Find(id);
            if (borrower == null)
            {
                return HttpNotFound();
            }
            return View(borrower);
        }

        // GET: Borrowers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Borrowers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uid,sin,firstName,lastName,DOB,phoneNo,marriedStatus")] Borrower borrower)
        {
            if (ModelState.IsValid)
            {
                Qualifying qq = new Qualifying { qualifyingId = 4, creditNo = "777777777", GDS = 22.3, TDS = 30.6, genericScore = 490, monthAtBank = 30, monthAtEmployer = 40 };

                Address add = new Address { addressId = 6, municipality = "Toronro", postalCode = "k3t2n6", province = "ON", streetName = "Mark", streetNo = "33", unitNo = 1 };

                borrower.currentAddress = add;
                borrower.qualifying = qq;

                string message;

                if (borrower.qualifying.GDS > 10 ) {
                    message = emiliConstants.TestMsg[03];
                }
                
                db.Borrowers.Add(borrower);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(borrower);
        }

        // GET: Borrowers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrower borrower = db.Borrowers.Find(id);
            if (borrower == null)
            {
                return HttpNotFound();
            }
            return View(borrower);
        }

        // POST: Borrowers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uid,sin,firstName,lastName,DOB,phoneNo,marriedStatus")] Borrower borrower)
        {
            if (ModelState.IsValid)
            {
                db.Entry(borrower).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(borrower);
        }

        // GET: Borrowers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrower borrower = db.Borrowers.Find(id);
            if (borrower == null)
            {
                return HttpNotFound();
            }
            return View(borrower);
        }

        // POST: Borrowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Borrower borrower = db.Borrowers.Find(id);
            db.Borrowers.Remove(borrower);
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
