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
    public class IdiomasController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Idiomas
        public IQueryable<idioma> Getidiomas()
        {
            return db.idiomas;
        }

        // GET: api/Idiomas/5
        [ResponseType(typeof(idioma))]
        public async Task<IHttpActionResult> Getidioma(Guid id)
        {
            idioma idioma = await db.idiomas.FindAsync(id);
            if (idioma == null)
            {
                return NotFound();
            }

            return Ok(idioma);
        }

        // PUT: api/Idiomas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putidioma(Guid id, idioma idioma)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != idioma.idioma_id)
            {
                return BadRequest();
            }

            db.Entry(idioma).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!idiomaExists(id))
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

        // POST: api/Idiomas
        [ResponseType(typeof(idioma))]
        public async Task<IHttpActionResult> Postidioma(idioma idioma)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.idiomas.Add(idioma);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (idiomaExists(idioma.idioma_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = idioma.idioma_id }, idioma);
        }

        // DELETE: api/Idiomas/5
        [ResponseType(typeof(idioma))]
        public async Task<IHttpActionResult> Deleteidioma(Guid id)
        {
            idioma idioma = await db.idiomas.FindAsync(id);
            if (idioma == null)
            {
                return NotFound();
            }

            db.idiomas.Remove(idioma);
            await db.SaveChangesAsync();

            return Ok(idioma);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool idiomaExists(Guid id)
        {
            return db.idiomas.Count(e => e.idioma_id == id) > 0;
        }
    }
}