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
using ISO605_API.Models;

namespace ISO605_API.Controllers
{
    public class CandidatosController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Candidatos
        public IQueryable<candidato> Getcandidatoes()
        {
            return db.candidatoes;
        }

        // GET: api/Candidatos/5
        [ResponseType(typeof(candidato))]
        public IHttpActionResult Getcandidato(Guid id)
        {
            candidato candidato = db.candidatoes.Find(id);
            if (candidato == null)
            {
                return NotFound();
            }

            return Ok(candidato);
        }

        // PUT: api/Candidatos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcandidato(Guid id, candidato candidato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != candidato.candidato_id)
            {
                return BadRequest();
            }

            db.Entry(candidato).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!candidatoExists(id))
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

        // POST: api/Candidatos
        [ResponseType(typeof(candidato))]
        public IHttpActionResult Postcandidato(candidato candidato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.candidatoes.Add(candidato);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (candidatoExists(candidato.candidato_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = candidato.candidato_id }, candidato);
        }

        // DELETE: api/Candidatos/5
        [ResponseType(typeof(candidato))]
        public IHttpActionResult Deletecandidato(Guid id)
        {
            candidato candidato = db.candidatoes.Find(id);
            if (candidato == null)
            {
                return NotFound();
            }

            db.candidatoes.Remove(candidato);
            db.SaveChanges();

            return Ok(candidato);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool candidatoExists(Guid id)
        {
            return db.candidatoes.Count(e => e.candidato_id == id) > 0;
        }
    }
}