using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsIncident
    {
        private MyContext db = new MyContext();
        private Incident I;

        public bool AjouterIncident(string Libelle,DateTime DateIncident)
        {
            I = new Incident();
            I.Libelle_Incid = Libelle;
            I.Date_Incid = DateIncident;
            if(db.Incidents.SingleOrDefault(s => s.Libelle_Incid == Libelle) == null)
            {
                db.Incidents.Add(I);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
