using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AGTPPE2._1.Models;

namespace AGTPPE2._1.Controllers
{
    public class MATERIELsController : Controller
    {
        private BDDKNEntities db = new BDDKNEntities();

        // GET: MATERIELs
        public ActionResult Index()
        {
            var mATERIEL = db.MATERIEL.Include(m => m.BARRE).Include(m => m.CELLULE).Include(m => m.TYPECONNEXION1).Include(m => m.UTILISATEUR);
            return View(mATERIEL.ToList());
        }

        // GET: MATERIELs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATERIEL mATERIEL = db.MATERIEL.Find(id);
            if (mATERIEL == null)
            {
                return HttpNotFound();
            }
            return View(mATERIEL);
        }

        // GET: MATERIELs/Create
        public ActionResult Create()
        {
            ViewBag.idBarre = new SelectList(db.BARRE, "idBarre", "libelleBarre");
            ViewBag.idCelllule = new SelectList(db.CELLULE, "idCelllule", "libelleCellule");
            ViewBag.typeConnexion = new SelectList(db.TYPECONNEXION, "typeConnexion1", "descriptionConnexion");
            ViewBag.idUtilisateur = new SelectList(db.UTILISATEUR, "idUtilisateur", "nomUtilisateur");
            return View();
        }

        // POST: MATERIELs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "numeroSerieMateriel,emplacementMateriel,modeleMateriel,ipMateriel,typeIpMateriel,numInfologMateriel,celluleMateriel,etatMateriel,numeroChariot,idUtilisateur,typeConnexion,idCelllule,idBarre")] MATERIEL mATERIEL)
        {
            if (ModelState.IsValid)
            {
                db.MATERIEL.Add(mATERIEL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idBarre = new SelectList(db.BARRE, "idBarre", "libelleBarre", mATERIEL.idBarre);
            ViewBag.idCelllule = new SelectList(db.CELLULE, "idCelllule", "libelleCellule", mATERIEL.idCelllule);
            ViewBag.typeConnexion = new SelectList(db.TYPECONNEXION, "typeConnexion1", "descriptionConnexion", mATERIEL.typeConnexion);
            ViewBag.idUtilisateur = new SelectList(db.UTILISATEUR, "idUtilisateur", "nomUtilisateur", mATERIEL.idUtilisateur);
            return View(mATERIEL);
        }

        // GET: MATERIELs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATERIEL mATERIEL = db.MATERIEL.Find(id);
            if (mATERIEL == null)
            {
                return HttpNotFound();
            }
            ViewBag.idBarre = new SelectList(db.BARRE, "idBarre", "libelleBarre", mATERIEL.idBarre);
            ViewBag.idCelllule = new SelectList(db.CELLULE, "idCelllule", "libelleCellule", mATERIEL.idCelllule);
            ViewBag.typeConnexion = new SelectList(db.TYPECONNEXION, "typeConnexion1", "descriptionConnexion", mATERIEL.typeConnexion);
            ViewBag.idUtilisateur = new SelectList(db.UTILISATEUR, "idUtilisateur", "nomUtilisateur", mATERIEL.idUtilisateur);
            return View(mATERIEL);
        }

        // POST: MATERIELs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "numeroSerieMateriel,emplacementMateriel,modeleMateriel,ipMateriel,typeIpMateriel,numInfologMateriel,celluleMateriel,etatMateriel,numeroChariot,idUtilisateur,typeConnexion,idCelllule,idBarre")] MATERIEL mATERIEL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mATERIEL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idBarre = new SelectList(db.BARRE, "idBarre", "libelleBarre", mATERIEL.idBarre);
            ViewBag.idCelllule = new SelectList(db.CELLULE, "idCelllule", "libelleCellule", mATERIEL.idCelllule);
            ViewBag.typeConnexion = new SelectList(db.TYPECONNEXION, "typeConnexion1", "descriptionConnexion", mATERIEL.typeConnexion);
            ViewBag.idUtilisateur = new SelectList(db.UTILISATEUR, "idUtilisateur", "nomUtilisateur", mATERIEL.idUtilisateur);
            return View(mATERIEL);
        }

        // GET: MATERIELs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATERIEL mATERIEL = db.MATERIEL.Find(id);
            if (mATERIEL == null)
            {
                return HttpNotFound();
            }
            return View(mATERIEL);
        }

        // POST: MATERIELs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MATERIEL mATERIEL = db.MATERIEL.Find(id);
            db.MATERIEL.Remove(mATERIEL);
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
