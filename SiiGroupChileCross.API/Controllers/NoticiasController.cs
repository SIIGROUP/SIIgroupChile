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
using SiiGroupChileCross.Common.Models;
using SiiGroupChileCross.Domain.Models;

namespace SiiGroupChileCross.API.Controllers
{
    public class NoticiasController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Noticias
        public IQueryable<Noticias> GetNoticias()
        {
            return db.Noticias;
        }

        // GET: api/Noticias/5
        [ResponseType(typeof(Noticias))]
        public async Task<IHttpActionResult> GetNoticias(int id)
        {
            Noticias noticias = await db.Noticias.FindAsync(id);
            if (noticias == null)
            {
                return NotFound();
            }

            return Ok(noticias);
        }

        // PUT: api/Noticias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNoticias(int id, Noticias noticias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != noticias.NoticiaId)
            {
                return BadRequest();
            }

            db.Entry(noticias).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoticiasExists(id))
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

        // POST: api/Noticias
        [ResponseType(typeof(Noticias))]
        public async Task<IHttpActionResult> PostNoticias(Noticias noticias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Noticias.Add(noticias);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = noticias.NoticiaId }, noticias);
        }

        // DELETE: api/Noticias/5
        [ResponseType(typeof(Noticias))]
        public async Task<IHttpActionResult> DeleteNoticias(int id)
        {
            Noticias noticias = await db.Noticias.FindAsync(id);
            if (noticias == null)
            {
                return NotFound();
            }

            db.Noticias.Remove(noticias);
            await db.SaveChangesAsync();

            return Ok(noticias);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NoticiasExists(int id)
        {
            return db.Noticias.Count(e => e.NoticiaId == id) > 0;
        }
    }
}