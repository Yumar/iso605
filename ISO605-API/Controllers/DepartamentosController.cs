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
    public class DepartamentosController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Departamentos
        public IQueryable<departamento> Getdepartamentoes()
        {
            return db.departamentoes;
        }

        // GET: api/Departamentos/5
        [ResponseType(typeof(departamento))]
        public async Task<IHttpActionResult> Getdepartamento(Guid id)
        {
            departamento departamento = await db.departamentoes.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }

            return Ok(departamento);
        }

        // PUT: api/Departamentos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putdepartamento(Guid id, departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != departamento.departamento_id)
            {
                return BadRequest();
            }

            db.Entry(departamento).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!departamentoExists(id))
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

        // POST: api/Departamentos
        [ResponseType(typeof(departamento))]
        public async Task<IHttpActionResult> Postdepartamento(departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.departamentoes.Add(departamento);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (departamentoExists(departamento.departamento_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = departamento.departamento_id }, departamento);
        }

        // DELETE: api/Departamentos/5
        [ResponseType(typeof(departamento))]
        public async Task<IHttpActionResult> Deletedepartamento(Guid id)
        {
            departamento departamento = await db.departamentoes.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }

            db.departamentoes.Remove(departamento);
            await db.SaveChangesAsync();

            return Ok(departamento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool departamentoExists(Guid id)
        {
            return db.departamentoes.Count(e => e.departamento_id == id) > 0;
        }
    }
}