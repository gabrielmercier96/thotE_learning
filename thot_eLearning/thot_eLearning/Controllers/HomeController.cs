using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace thot_eLearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public ActionResult About()
=======
=======
>>>>>>> parent of 3125e6f... Admin v.3
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
                    Prerequis = data.Prerequis
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
            Cours model = new Cours();
            return View(model);
        }
        [HttpPost]
        public ActionResult Insert(Cours model)
>>>>>>> parent of 3125e6f... Admin v.3
        {
            ViewBag.Message = "Your application description page.";

<<<<<<< HEAD
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
=======
                Cour insertion = new Cour
                {
                    Nom = model.Nom,
                    Description = model.Description,
                    Prerequis = model.Prerequis
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
       
        
<<<<<<< HEAD
>>>>>>> parent of 3125e6f... Admin v.3
=======
>>>>>>> parent of 3125e6f... Admin v.3
    }
}