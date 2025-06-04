using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.Modele
{
    public class Personnel
    {
        public int IdPersonnel { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdService { get; set; }

        public Personnel(int idPersonnel, string nom, string prenom, int idService)
        {
            IdPersonnel = idPersonnel;
            Nom = nom;
            Prenom = prenom;
            IdService = idService;
        }
    }
}

