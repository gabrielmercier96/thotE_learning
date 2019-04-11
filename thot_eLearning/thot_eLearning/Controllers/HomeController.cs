using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thot_eLearning.Models;

namespace thot_eLearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Admin()
        {
            DataClassAdminDataContext bd = new DataClassAdminDataContext();

            var cours = from c in bd.Cours
                        select c;

            ViewBag.title = "Admin";
            ViewBag.message = "Voici la liste des cours";

            return View(cours);
        }

        
    }
}