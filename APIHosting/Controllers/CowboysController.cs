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
using APIHosting.Models;

namespace APIHosting.Controllers
{
    public class CowboysController : ApiController
    {
        private CowboysEntities db = new CowboysEntities();

        // GET: api/Cowboys
        public IQueryable<Cowboy> GetCowboys()
        {
            return db.Cowboys;
        }

        // GET: api/Cowboys/5
        [ResponseType(typeof(Cowboy))]
        public IHttpActionResult GetCowboy(int id)
        {
            Cowboy cowboy = db.Cowboys.Find(id);
            if (cowboy == null)
            {
                return NotFound();
            }

            return Ok(cowboy);
        }

        // PUT: api/Cowboys/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCowboy(int id, Cowboy cowboy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cowboy.id)
            {
                return BadRequest();
            }

            db.Entry(cowboy).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CowboyExists(id))
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

        // POST: api/Cowboys
        [ResponseType(typeof(Cowboy))]
        public IHttpActionResult PostCowboy(Cowboy cowboy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cowboys.Add(cowboy);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cowboy.id }, cowboy);
        }

        // DELETE: api/Cowboys/5
        [ResponseType(typeof(Cowboy))]
        public IHttpActionResult DeleteCowboy(int id)
        {
            Cowboy cowboy = db.Cowboys.Find(id);
            if (cowboy == null)
            {
                return NotFound();
            }

            db.Cowboys.Remove(cowboy);
            db.SaveChanges();

            return Ok(cowboy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CowboyExists(int id)
        {
            return db.Cowboys.Count(e => e.id == id) > 0;
        }
    }
}