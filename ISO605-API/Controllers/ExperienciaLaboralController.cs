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
    public class ExperienciaLaboralController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/ExperienciaLaboral
        public IQueryable<experiencia_laboral> Getexperiencia_laboral()
        {
            return db.experiencia_laboral;
        }

        // GET: api/ExperienciaLaboral/5
        [ResponseType(typeof(experiencia_laboral))]
        public async Task<IHttpActionResult> Getexperiencia_laboral(Guid id)
        {
            experiencia_laboral experiencia_laboral = await db.experiencia_laboral.FindAsync(id);
            if (experiencia_laboral == null)
            {
                return NotFound();
            }

            return Ok(experiencia_laboral);
        }

        // PUT: api/ExperienciaLaboral/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putexperiencia_laboral(Guid id, experiencia_laboral experiencia_laboral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != experiencia_laboral.experiencia_laboral_id)
            {
                return BadRequest();
            }

            db.Entry(experiencia_laboral).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!experiencia_laboralExists(id))
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

        // POST: api/ExperienciaLaboral
        [ResponseType(typeof(experiencia_laboral))]
        public async Task<IHttpActionResult> Postexperiencia_laboral(experiencia_laboral experiencia_laboral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.experiencia_laboral.Add(experiencia_laboral);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (experiencia_laboralExists(experiencia_laboral.experiencia_laboral_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = experiencia_laboral.experiencia_laboral_id }, experiencia_laboral);
        }

        // DELETE: api/ExperienciaLaboral/5
        [ResponseType(typeof(experiencia_laboral))]
        public async Task<IHttpActionResult> Deleteexperiencia_laboral(Guid id)
        {
            experiencia_laboral experiencia_laboral = await db.experiencia_laboral.FindAsync(id);
            if (experiencia_laboral == null)
            {
                return NotFound();
            }

            db.experiencia_laboral.Remove(experiencia_laboral);
            await db.SaveChangesAsync();

            return Ok(experiencia_laboral);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool experiencia_laboralExists(Guid id)
        {
            return db.experiencia_laboral.Count(e => e.experiencia_laboral_id == id) > 0;
        }
    }
}