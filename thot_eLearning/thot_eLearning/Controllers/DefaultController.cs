using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using thot_eLearning.Models;

namespace thot_eLearning.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        private DataClassAdminDataContext context;
        private DataClasses1DataContext contextStudent;
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string user, string pass)
        {

            context = new DataClassAdminDataContext();
            contextStudent = new DataClasses1DataContext();
            IList<Cours> uneListe = new List<Cours>();

            var etudiantQuery = (from x in contextStudent.etudiants where x.Id == user select x.education).Single();
            var query = from c in context.Cours
                        where c.Prerequis == etudiantQuery
                        select c;
            var querryRez = query.ToList();
            foreach (var data in querryRez)
            {
                uneListe.Add(new Cours()
                {
                    Nom = data.Nom,
                    Description = data.Description,
                    Prerequis = data.Prerequis,
                    NbModules = data.NbModules,
                    Content = data.Content
                });
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                if (user != null && user != "")
                {
                    if (pass != null && pass != "")
                    {
                        var res = (from m in db.connections where m.user == user && m.password == pass select m).Count();
                        if (res == 1)
                        {
                            return View("~/Views/Home/CoursStudent.cshtml",uneListe);//"nom de la view");
                            
                        }
                        else
                        {
                            ViewBag.login = "Utilisateur ou mot de passe incorrect";

                        }
                    }
                    else
                    {
                        ViewBag.login = "Password vide";
                    }
                }
                else
                {
                    ViewBag.login = "Login vide";
                }
                return View();
            }
        }
        public ActionResult Inscription()
        {
            Etudiant e = new Etudiant();
            return View(e);
        }
        [HttpPost]
        public ActionResult Inscription(Etudiant e)
        {
            string id = "";
            string pass = "";
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                id += r.Next(0, 9);
            }
            for (int i = 0; i < 16; i++)
            {
                pass += (char)r.Next(33, 125);
            }
            e.Id = e.Nom.Substring(0, 3) + e.Prenom.Substring(0, 3) + id;
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                etudiant etud = new etudiant
                {
                    Id = e.Id,
                    nom = e.Nom,
                    prenom = e.Prenom,
                    email = e.Email,
                    education = e.Education
                };
                connection con = new connection
                {
                    Idetudiant = e.Id,
                    user = e.Id,
                    password = pass
                };
                db.etudiants.InsertOnSubmit(etud);
                db.connections.InsertOnSubmit(con);
                db.SubmitChanges();
            }
            if (!sendMail(e.Email, e.Id, pass))
            {
                ViewBag.email = "erreur veuillez contacter l'administration";
            }




            return View("Index");
        }

        private bool sendMail(string email, string user, string password)
        {
            try
            {
                string MailSender = System.Configuration.ConfigurationManager.AppSettings["MailSender"].ToString();
                string MailPw = System.Configuration.ConfigurationManager.AppSettings["MailPw"].ToString();

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 100000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(MailSender, MailPw);

                MailMessage mailMessage = new MailMessage(MailSender, email, "confirmation inscription", "Votre utilisateur est: " + user + "\nVotre mot de passe est: " + password);
                // mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = System.Text.UTF8Encoding.UTF8;

                smtpClient.Send(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}