using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thot_eLearning.Models;

namespace thot_eLearning.Controllers
{
    public class eleveController : Controller
    {

        private DataClassAdminDataContext context;

        public eleveController()
        {
            context = new DataClassAdminDataContext();
        }

        // GET: eleve
        public ActionResult Eleve()
        {
            IList<Cours> uneListe = new List<Cours>();
            var query = from c in context.Cours
                select c;
            var querryRez = query.ToList();
            foreach (var data in querryRez)
            {
                uneListe.Add(new Cours()
                {
                    Nom = data.Nom,
                    Description = data.Description,
                    Prerequis = data.Prerequis,
                    NbModules = data.NbModules
                });
            }
            return View(uneListe);
        }
    }
}