﻿using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class AbonnementController : Controller
    {
        IAdministrateur iadmin = new AdministrateurImpl();
        // GET: Abonnement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajouterAbonnement()
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                return View();
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult ajouterAbonnement(Abonnement a)
        {
            if (ModelState.IsValid)
            {
                iadmin.creerAbonnement(a);
                return RedirectToAction("listerTousAbonnement");
            }
            else
            {
                return View(a);
            }
        }

        public ActionResult listerTousAbonnement()
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                var res = iadmin.listerTousAbonnements();
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult supprimerAbonnement(int id)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                iadmin.supprimerAbonnement(id);
                return RedirectToAction("listerTousAbonnement");
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult modifierAbonnement(int id)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                Abonnement res = iadmin.afficherAbonnement(id);
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }

        }

        [HttpPost]
        public ActionResult modifierAbonnement(Abonnement a)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                iadmin.modifierAbonnement(a);
                return RedirectToAction("listerTousAbonnement");
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }
    }
}