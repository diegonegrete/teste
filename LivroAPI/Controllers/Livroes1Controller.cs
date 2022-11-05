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
using LivroAPI.Data;
using LivroAPI.Models;

namespace LivroAPI.Controllers
{
    public class Livroes1Controller : ApiController
    {
        private LivroAPIdbContext db = new LivroAPIdbContext();

        // GET: api/Livroes1
        public IQueryable<Livro> GetLivroes()
        {
            return db.Livroes;
        }

        // GET: api/Livroes1/5
        [ResponseType(typeof(Livro))]
        public IHttpActionResult GetLivro(int id)
        {
            Livro livro = db.Livroes.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }

        // PUT: api/Livroes1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLivro(int id, Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != livro.Id)
            {
                return BadRequest();
            }

            db.Entry(livro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroExists(id))
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

        // POST: api/Livroes1
        [ResponseType(typeof(Livro))]
        public IHttpActionResult PostLivro(Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Livroes.Add(livro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = livro.Id }, livro);
        }

        // DELETE: api/Livroes1/5
        [ResponseType(typeof(Livro))]
        public IHttpActionResult DeleteLivro(int id)
        {
            Livro livro = db.Livroes.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            db.Livroes.Remove(livro);
            db.SaveChanges();

            return Ok(livro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LivroExists(int id)
        {
            return db.Livroes.Count(e => e.Id == id) > 0;
        }
    }
}