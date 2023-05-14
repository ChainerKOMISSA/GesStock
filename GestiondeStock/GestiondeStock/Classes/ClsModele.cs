using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsModele
    {
        private MyContext db = new MyContext();
        private Modele M;

        public bool AjouterModele(string Libelle)
        {
            M = new Modele();
            M.Libelle_Modele = Libelle;
            if (db.Modeles.SingleOrDefault(s => s.Libelle_Modele == Libelle) == null)
            {
                db.Modeles.Add(M);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifierModele(string Libelle)
        {
            M = new Modele();
            M = db.Modeles.SingleOrDefault(s => s.Libelle_Modele == Libelle);
            if (M != null)
            {
                M.Libelle_Modele = Libelle;
                db.SaveChanges();
            }

        }
    }
}
