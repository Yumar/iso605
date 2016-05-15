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
    public class EmpleadosController : ApiController
    {
        private ISO605Entities db = new ISO605Entities();

        // GET: api/Empleados
        public IQueryable<empleado> Getempleadoes()
        {
            return db.empleadoes;
        }

        // GET: api/Empleados/5
        [ResponseType(typeof(empleado))]
        public async Task<IHttpActionResult> Getempleado(Guid id)
        {
            empleado empleado = await db.empleadoes.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            return Ok(empleado);
        }

        // PUT: api/Empleados/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putempleado(Guid id, empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empleado.empleado_id)
            {
                return BadRequest();
            }

            db.Entry(empleado).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!empleadoExists(id))
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

        // POST: api/Empleados
        [ResponseType(typeof(empleado))]
        public async Task<IHttpActionResult> Postempleado(empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.empleadoes.Add(empleado);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (empleadoExists(empleado.empleado_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = empleado.empleado_id }, empleado);
        }

        // DELETE: api/Empleados/5
        [ResponseType(typeof(empleado))]
        public async Task<IHttpActionResult> Deleteempleado(Guid id)
        {
            empleado empleado = await db.empleadoes.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            db.empleadoes.Remove(empleado);
            await db.SaveChangesAsync();

            return Ok(empleado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool empleadoExists(Guid id)
        {
            return db.empleadoes.Count(e => e.empleado_id == id) > 0;
        }
    }
}