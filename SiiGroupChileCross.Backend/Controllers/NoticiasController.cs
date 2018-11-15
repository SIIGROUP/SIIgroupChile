using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiiGroupChileCross.Backend.Models;
using SiiGroupChileCross.Common.Models;
using SiiGroupChileCross.Backend.Herlpers;

namespace SiiGroupChileCross.Backend.Controllers
{
    public class NoticiasController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Noticias
        public async Task<ActionResult> Index()
        {
            return View(await db.Noticias.OrderByDescending(n => n.NoticiaId).ToListAsync());
        }

        // GET: Noticias/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticias noticias = await db.Noticias.FindAsync(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        // GET: Noticias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Noticias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(NoticiaView view)
        {
            if (ModelState.IsValid)
            {
                var pic = string.Empty;
                var folder = "~/Content/Noticias";
                var pic1 = string.Empty;
                var pic2 = string.Empty;
                var pic3 = string.Empty;
                var pic4 = string.Empty;
                if (view.ImageFile != null)
                {
                    pic = FileHelper.UploadPhoto(view.ImageFile, folder);
                    pic = $"{folder}/{pic}";
                }

                if (view.ImageFile1 != null)
                {
                    pic1 = FileHelper.UploadPhoto1(view.ImageFile1, folder);
                    pic1 = $"{folder}/{pic1}";
                }

                if (view.ImageFile2 != null)
                {
                    pic2 = FileHelper.UploadPhoto2(view.ImageFile2, folder);
                    pic2 = $"{folder}/{pic2}";
                }
                if (view.ImageFile3 != null)
                {
                    pic3 = FileHelper.UploadPhoto3(view.ImageFile3, folder);
                    pic3 = $"{folder}/{pic3}";
                }
                if (view.ImageFile4 != null)
                {
                    pic4 = FileHelper.UploadPhoto4(view.ImageFile4, folder);
                    pic4 = $"{folder}/{pic4}";
                }
                var noticia = this.ToNoticia(view, pic, pic1, pic2, pic3, pic4);
                this.db.Noticias.Add(noticia);
                await this.db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(view);
        }

        private Noticias ToNoticia(NoticiaView view, string pic, string pic1, string pic2, string pic3, string pic4)
        {
            return new Noticias
            {
                Titulo = view.Titulo,
                ImagePath = pic,
                ImagePath1 = pic1,
                ImagePath2 = pic2,
                ImagePath3 = pic3,
                ImagePath4 = pic4,
                Texto = view.Texto,
                Fecha = view.Fecha,
            };
        }


        // GET: Noticias/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticias noticias = await db.Noticias.FindAsync(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        // POST: Noticias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(NoticiaView view)
        {
            if (ModelState.IsValid)
            {
                var pic = view.ImagePath;
                var pic1 = view.ImagePath1;
                var pic2 = view.ImagePath2;
                var pic3 = view.ImagePath3;
                var pic4 = view.ImagePath4;
                var folder = "~/Content/Noticias";

                if (view.ImageFile != null)
                {
                    pic = FileHelper.UploadPhoto(view.ImageFile, folder);
                    pic = $"{folder}/{pic}";
                }
                if (view.ImageFile1 != null)
                {
                    pic1 = FileHelper.UploadPhoto1(view.ImageFile1, folder);
                    pic1 = $"{folder}/{pic1}";
                }
                if (view.ImageFile2 != null)
                {
                    pic2 = FileHelper.UploadPhoto2(view.ImageFile2, folder);
                    pic2 = $"{folder}/{pic2}";
                }
                if (view.ImageFile3 != null)
                {
                    pic3 = FileHelper.UploadPhoto3(view.ImageFile3, folder);
                    pic3 = $"{folder}/{pic3}";
                }
                if (view.ImageFile4 != null)
                {
                    pic4 = FileHelper.UploadPhoto3(view.ImageFile4, folder);
                    pic4 = $"{folder}/{pic4}";
                }
                var noticia = this.ToNoticia(view, pic, pic1, pic2, pic3, pic4);

                this.db.Entry(noticia).State = EntityState.Modified;
                await this.db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(view);
        }

        // GET: Noticias/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticias noticias = await db.Noticias.FindAsync(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        // POST: Noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Noticias noticias = await db.Noticias.FindAsync(id);
            db.Noticias.Remove(noticias);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
