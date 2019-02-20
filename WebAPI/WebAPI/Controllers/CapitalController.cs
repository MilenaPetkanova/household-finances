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
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CapitalController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Capital
        public IQueryable<Capital> GetCapitals()
        {
            return db.Capitals;
        }

        // PUT: api/Capital/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCapital(int id, Capital capital)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != capital.Id)
            {
                return BadRequest();
            }

            db.Entry(capital).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapitalExists(id))
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

        // POST: api/Capital
        [ResponseType(typeof(Capital))]
        public IHttpActionResult PostCapital(Capital capital)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Capitals.Add(capital);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = capital.Id }, capital);
        }

        // DELETE: api/Capital/5
        [ResponseType(typeof(Capital))]
        public IHttpActionResult DeleteCapital(int id)
        {
            Capital capital = db.Capitals.Find(id);
            if (capital == null)
            {
                return NotFound();
            }

            db.Capitals.Remove(capital);
            db.SaveChanges();

            return Ok(capital);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CapitalExists(int id)
        {
            return db.Capitals.Count(e => e.Id == id) > 0;
        }
    }
}