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
    public class PosicionesController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Posiciones
        public IQueryable<posicion> Getposicions()
        {
            return db.posicions;
        }

        // GET: api/Posiciones/5
        [ResponseType(typeof(posicion))]
        public async Task<IHttpActionResult> Getposicion(Guid id)
        {
            posicion posicion = await db.posicions.FindAsync(id);
            if (posicion == null)
            {
                return NotFound();
            }

            return Ok(posicion);
        }

        // PUT: api/Posiciones/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putposicion(Guid id, posicion posicion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != posicion.posicion_id)
            {
                return BadRequest();
            }

            db.Entry(posicion).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!posicionExists(id))
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

        // POST: api/Posiciones
        [ResponseType(typeof(posicion))]
        public async Task<IHttpActionResult> Postposicion(posicion posicion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.posicions.Add(posicion);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (posicionExists(posicion.posicion_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = posicion.posicion_id }, posicion);
        }

        // DELETE: api/Posiciones/5
        [ResponseType(typeof(posicion))]
        public async Task<IHttpActionResult> Deleteposicion(Guid id)
        {
            posicion posicion = await db.posicions.FindAsync(id);
            if (posicion == null)
            {
                return NotFound();
            }

            db.posicions.Remove(posicion);
            await db.SaveChangesAsync();

            return Ok(posicion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool posicionExists(Guid id)
        {
            return db.posicions.Count(e => e.posicion_id == id) > 0;
        }
    }
}