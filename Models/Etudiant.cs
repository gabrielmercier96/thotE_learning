using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetFinal.Models
{
    public class Etudiant
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        private string[] listEducation = { "Primaire","Secondaire","Collegial"};
        public string[] ListEducation
        {
            get { return this.listEducation; }
            set { this.listEducation = value; }
        }
    }
}