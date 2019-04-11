using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace thot_eLearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Admin()
        {

            ViewBag.title = "demo About";
            ViewBag.message = "je suis le message que le controleur voulais vous transmettre dans About";

            return View();
        }

        
    }
}