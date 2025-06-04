using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.Modele
{
    public class Absence
    {
        public int IdAbsence { get; set; }
        public int IdPersonnel { get; set; }
        public int IdMotif { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public Absence(int idAbsence, int idPersonnel, int idMotif, DateTime dateDebut, DateTime dateFin)
        {
            IdAbsence = idAbsence;
            IdPersonnel = idPersonnel;
            IdMotif = idMotif;
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
    }
}
