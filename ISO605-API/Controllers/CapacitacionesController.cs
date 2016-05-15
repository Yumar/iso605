using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ISO605_API.Models;

namespace ISO605_API.Controllers
{
    public class CapacitacionesController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Capacitaciones
        public IQueryable<capacitacion> Getcapacitacions()
        {
            return db.capacitacions;
        }

        // GET: api/Capacitaciones/5
        [ResponseType(typeof(capacitacion))]
        public async Task<IHttpActionResult> Getcapacitacion(Guid id)
        {
            capacitacion capacitacion = await db.capacitacions.FindAsync(id);
            if (capacitacion == null)
            {
                return NotFound();
            }

            return Ok(capacitacion);
        }

        // PUT: api/Capacitaciones/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcapacitacion(Guid id, capacitacion capacitacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != capacitacion.capacitaciones_id)
            {
                return BadRequest();
            }

            db.Entry(capacitacion).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!capacitacionExists(id))
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

        // POST: api/Capacitaciones
        [ResponseType(typeof(capacitacion))]
        public async Task<IHttpActionResult> Postcapacitacion(capacitacion capacitacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.capacitacions.Add(capacitacion);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (capacitacionExists(capacitacion.capacitaciones_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = capacitacion.capacitaciones_id }, capacitacion);
        }

        // DELETE: api/Capacitaciones/5
        [ResponseType(typeof(capacitacion))]
        public async Task<IHttpActionResult> Deletecapacitacion(Guid id)
        {
            capacitacion capacitacion = await db.capacitacions.FindAsync(id);
            if (capacitacion == null)
            {
                return NotFound();
            }

            db.capacitacions.Remove(capacitacion);
            await db.SaveChangesAsync();

            return Ok(capacitacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool capacitacionExists(Guid id)
        {
            return db.capacitacions.Count(e => e.capacitaciones_id == id) > 0;
        }
    }
}