using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsBrasserie
    {
        private MyContext db = new MyContext();
        private Brasserie B;

        public bool AjouterBrasserie(string Nom)
        {
            B = new Brasserie();
            B.Nom_Brasserie = Nom;
            if (db.Brasseries.SingleOrDefault(s => s.Nom_Brasserie == Nom) == null)
            {
                db.Brasseries.Add(B);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifierBrasserie(string Nom)
        {
            B = new Brasserie();
            B = db.Brasseries.SingleOrDefault(s => s.Nom_Brasserie == Nom);
            if (B != null)
            {
                B.Nom_Brasserie = Nom;
                db.SaveChanges();
            }

        }

        public void SupprimerBrasserie()
        {
            B = new Brasserie();
            db.Brasseries.Remove(B);
            db.SaveChanges();
        }
    }
}
