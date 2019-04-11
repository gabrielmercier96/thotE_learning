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
        [HttpPost]
        public ActionResult Admin(string Nom, string Description, string Prerequis)
        {
            DataClassAdminDataContext bd = new DataClassAdminDataContext();
            var cmd = Request["cmd"].ToString();
            if (cmd == "1")
            {
                Cour insertion = new Cour
                {
                    Nom = Request["nom"].ToString(),
                    Description = Request["description"].ToString(),
                    Prerequis = Request["prerequis"].ToString()
                };
                bd.Cours.InsertOnSubmit(insertion);
                try
                {
                    bd.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    bd.SubmitChanges();
                }
            }
            return View();
        }
       
        
    }
}