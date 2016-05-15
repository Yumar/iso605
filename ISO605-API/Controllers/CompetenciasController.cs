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
    public class CompetenciasController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Competencias
        public IQueryable<competencia> Getcompetencias()
        {
            return db.competencias;
        }

        // GET: api/Competencias/5
        [ResponseType(typeof(competencia))]
        public async Task<IHttpActionResult> Getcompetencia(Guid id)
        {
            competencia competencia = await db.competencias.FindAsync(id);
            if (competencia == null)
            {
                return NotFound();
            }

            return Ok(competencia);
        }

        // PUT: api/Competencias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcompetencia(Guid id, competencia competencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != competencia.competencia_id)
            {
                return BadRequest();
            }

            db.Entry(competencia).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!competenciaExists(id))
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

        // POST: api/Competencias
        [ResponseType(typeof(competencia))]
        public async Task<IHttpActionResult> Postcompetencia(competencia competencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.competencias.Add(competencia);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (competenciaExists(competencia.competencia_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = competencia.competencia_id }, competencia);
        }

        // DELETE: api/Competencias/5
        [ResponseType(typeof(competencia))]
        public async Task<IHttpActionResult> Deletecompetencia(Guid id)
        {
            competencia competencia = await db.competencias.FindAsync(id);
            if (competencia == null)
            {
                return NotFound();
            }

            db.competencias.Remove(competencia);
            await db.SaveChangesAsync();

            return Ok(competencia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool competenciaExists(Guid id)
        {
            return db.competencias.Count(e => e.competencia_id == id) > 0;
        }
    }
}