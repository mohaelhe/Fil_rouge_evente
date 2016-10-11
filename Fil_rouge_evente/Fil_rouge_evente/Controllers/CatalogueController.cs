using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class CatalogueController : Controller
    {
        IAdministrateur iadmin = new AdministrateurImpl();
        // GET: Catalogue
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajouterCatalogue()
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
        public ActionResult ajouterCatalogue(Catalogue c)
        {
            iadmin.ajouterCatalogue(c);
            return RedirectToAction("loggedInAdmin","Administrateur");
        }
    }
}