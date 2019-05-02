using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thot_eLearning.Models
{
    public class Cours
    {

        public string Nom { get; set; }
        public string Description { get; set; }
        public string Prerequis { get; set; }
        public string NbModules { get; set; }
        public int IdCours { get; set; }
        public string Content { get; set; }
    }
   
}