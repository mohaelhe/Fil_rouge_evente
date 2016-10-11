using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class FideliteController : Controller
    {
        IAdministrateur iadmin = new AdministrateurImpl();
        // GET: Fidelite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajouterFidelite()
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                return View();
            }
            else
            {
                return RedirectToAction("loginAdmin");
            }
        }

        [HttpPost]
        public ActionResult ajouterFidelite(Fidelite f)
        {
            return RedirectToAction("listerFidelite");
        }

        public ActionResult listerFidelite()
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                var res = iadmin.listerFidelite();
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin");
            }
        }

        public ActionResult supprimerFidelite(int FideliteId)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                iadmin.supprimerFidelite(FideliteId);
                return RedirectToAction("listerFidelite");
            }
            else
            {
                return RedirectToAction("loginAdmin");
            }
        }

        public ActionResult afficherFidelite(int FideliteId)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                var res = iadmin.afficherFidelite(FideliteId);
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin");
            }
        }

        public ActionResult modifierFidelite(int FideliteId)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                var res = iadmin.afficherFidelite(FideliteId);
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin");
            }
        }

        [HttpPost]
        public ActionResult modifierFidelite(Fidelite f)
        {
            iadmin.modifierFidelite(f);
            return RedirectToAction("listerFidelite");
        }
    }
}