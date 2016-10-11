using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class RoleController : Controller
    {
        IAdministrateur iadmin = new AdministrateurImpl();
        // GET: Role
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterRole(Role r)
        {
            var res = iadmin.ajouterRole(r);
            return RedirectToAction("ListerRoles");
        }

        public ActionResult ListerRoles()
        {
            var res = iadmin.listerRoles();
            return View(res);
        }
    }
}