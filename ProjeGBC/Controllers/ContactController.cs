using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using ProjeGBC.Models;
namespace ProjeGBC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        mvcblogDB db = new mvcblogDB();

        public ActionResult Index()
        {
            return View(db.Mesajs.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Mesaj mesaj)
        {
            if (ModelState.IsValid)
            {


                db.Mesajs.Add(mesaj);
                db.SaveChanges(); 
                return RedirectToAction("Index", "Home");

            }
            return View(mesaj);
        }
        public ActionResult MesajGoster()
        {
   
          
            return View(db.Mesajs.ToList());

        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesaj mesaj = db.Mesajs.Find(id);
            if (mesaj == null)
            {
                return HttpNotFound();
            }
            return View(mesaj);
        }

        // POST: AdminYorum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mesaj mesaj = db.Mesajs.Find(id);
            db.Mesajs.Remove(mesaj);
            db.SaveChanges();
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
