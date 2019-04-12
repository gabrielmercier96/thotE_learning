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
        private DataClassAdminDataContext context;
        /// <summary>
        /// The HomeController() function is used to create a new instance of the Database
        /// context variable is a simple access to its data.
        /// </summary>
        public HomeController()
        {
            context = new DataClassAdminDataContext();
        }


       
        /// <summary>
        /// Main page. You can see all the classes listed in in order in which they were inserted into the Database
        /// Many more options such as editing, updating, deleting and adding.
        /// </summary>
        /// <returns> The return simply returns a list of all the classes</returns>
        public ActionResult Admin()
        {
            IList<Cours> uneListe = new List<Cours>();

            var query = from c in context.Cours
                        select c;
            var publish = query.ToList();
            foreach(var data in publish)
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
        /// <summary>
        /// Initialise the Insert() function
        /// It will simple insert into the context variable which we created earlier.
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Insert()
        {
            Cours cour = new Cours();
            return View(cour);
        }
        [HttpPost]
        public ActionResult Insert(Cours model)
        {

                Cour insertion = new Cour
                {
                    Nom = model.Nom,
                    Description = model.Description,
                    Prerequis = model.Prerequis,
                    NbModules = model.NbModules
                };
                context.Cours.InsertOnSubmit(insertion);
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    context.SubmitChanges();
                }
            
            return View(model);
        }

        /// <summary>
        /// Delete function.
        /// Will simple delete the class as soon as the delete button is clicked.
        /// </summary>
        /// <param name="NomCours"></param>
        /// <returns></returns>
        public ActionResult Delete(string NomCours)
        {
            Cours model = context.Cours.Where(x => x.Nom == NomCours).Select(x =>
            new Cours()
            {
                Nom = x.Nom,
                Description = x.Description,
                Prerequis = x.Prerequis,
                NbModules = x.NbModules
            }).SingleOrDefault();


            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Cours cour)
        {
            try
            {
                Cour unCours = context.Cours.Where(x => x.Nom == cour.Nom).Single<Cour>();
                context.Cours.DeleteOnSubmit(unCours);
                context.SubmitChanges();
                return Redirect("Admin");
            }
            catch
            {
                return View(cour);
            }
    
        }

        /// <summary>
        /// Update function
        /// Will simple update anything as long as the name stays the same.
        /// </summary>
        /// <param name="NomCours"></param>
        /// <returns></returns>
        public ActionResult Update(String NomCours)
        {
            Cours model = context.Cours.Where(x => x.Nom == NomCours).Select(x =>
            new Cours()
            {
                Nom = x.Nom,
                Description = x.Description,
                Prerequis = x.Prerequis,
                NbModules = x.NbModules
            }).SingleOrDefault();


            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Cours model)
        {
            try
            {
                Cour cour = context.Cours.Where(x => x.Nom == model.Nom).Single<Cour>();
                cour.Nom = model.Nom;
                cour.Description = model.Description;
                cour.Prerequis = model.Prerequis;
                cour.NbModules = model.NbModules;
                context.SubmitChanges();
                return RedirectToAction("Admin");
            }
            catch
            {
                return View(model);
            }
        }


    }
}