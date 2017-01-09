using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using emiliAppraisal.DAL;
using emiliAppraisal.Models;
using emiliAppraisal.Services;

namespace emiliAppraisal.Controllers
{
    public class ReferralsController : ApiController
    {
        private emiliDB db = new emiliDB();
        private UnitOfWork unit = new UnitOfWork();

        // GET: api/Referrals
       // [Route("Inventory")]
        public IEnumerable<Referral> GetReferrals()
        {

            IEnumerable<Referral> inventory = unit.ReferralRepository.Get().OrderBy(a => a.APIDSTMP);


            return inventory;
        }

        // GET: api/Referrals/5
        [ResponseType(typeof(Referral))]
        public IHttpActionResult GetReferral(int id)
        {
            Referral referral = db.Referrals.Find(id);
            if (referral == null)
            {
                return NotFound();
            }

            return Ok(referral);
        }

        // PUT: api/Referrals/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReferral(int id, Referral referral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != referral.CMHCNO)
            {
                return BadRequest();
            }

            db.Entry(referral).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReferralExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Referrals
        [ResponseType(typeof(Referral))]
        public IHttpActionResult PostReferral(Referral referral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Referrals.Add(referral);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ReferralExists(referral.CMHCNO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = referral.CMHCNO }, referral);
        }

        // DELETE: api/Referrals/5
        [ResponseType(typeof(Referral))]
        public IHttpActionResult DeleteReferral(int id)
        {
            Referral referral = db.Referrals.Find(id);
            if (referral == null)
            {
                return NotFound();
            }

            db.Referrals.Remove(referral);
            db.SaveChanges();

            return Ok(referral);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReferralExists(int id)
        {
            return db.Referrals.Count(e => e.CMHCNO == id) > 0;
        }
    }
}