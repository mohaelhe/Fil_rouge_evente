using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class AdministrateurController : Controller
    {
        IAdministrateur iadmin = new AdministrateurImpl();
        // GET: Administrateur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajouterAdministrateur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ajouterAdministrateur(Administrateur a)
        {
            iadmin.creationCompteAdmin(a);
            return RedirectToAction("listerAdministrateur");
        }

        public ActionResult listerAdministrateur()
        {
            var res = iadmin.listerComptes();
            return View(res);
        }

        public ActionResult loginAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult loginAdmin(Utilisateur u)
        {
           


            var user = iadmin.connexionCompte(u);
            if(user != null)
            {
                ICollection<Role> resultat = iadmin.getRole(user);
                int res = 0;
                foreach (var p in resultat)
                    res = p.Droit;
                Session["UtilisateurId"] = user.UtilisateurId;
                Session["RoleId"] =res;
                return RedirectToAction("LoggedInAdmin");
            } 
            else
            {
                ModelState.AddModelError("", "Utilisateur ou mot de passe incorrect");
                return View(u);
            }
        }

        public ActionResult loggedInAdmin()
        {
           
            if ((Session["UtilisateurId"] != null) && (Convert.ToInt32(Session["RoleId"]) == 2))
            {
                return View();
            }
            else
            {
                return RedirectToAction("loginAdmin");
            }
        }

        public ActionResult logout()
        {
            Session["UtilisateurId"] = null;
            Session["RoleId"] = null;

            return RedirectToAction("loginAdmin");
        }

       
    }
}