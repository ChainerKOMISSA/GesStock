using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsDepense
    {
        private MyContext db = new MyContext();
        private Depense D;

        public bool AjouterDepense(string Libelle,string Montant,DateTime DateDepense)
        {
            D = new Depense();
            D.Libelle_Depense = Libelle;
            D.Montant_Depense = int.Parse(Montant);
            D.Date_Depense = DateDepense;
            if(db.Depenses.SingleOrDefault(s => s.Libelle_Depense == Libelle) == null)
            {
                db.Depenses.Add(D);
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
