using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsCategorie
    {
        private MyContext db = new MyContext();
        private Categorie Cat;

        public bool AjouterCategorie(string Nom,string Description)
        {
            Cat = new Categorie();
            Cat.Libelle_Categorie = Nom;
            Cat.Description_Categorie = Description;
            if (db.Categories.SingleOrDefault(s => s.Libelle_Categorie == Nom) == null)
            {
                db.Categories.Add(Cat);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifierCategorie(string Nom,string Description)
        {
            Cat = new Categorie();
            Cat = db.Categories.SingleOrDefault(s => s.Libelle_Categorie == Nom);
            if(Cat!= null)
            {
                Cat.Libelle_Categorie = Nom;
                Cat.Description_Categorie = Description;
                db.SaveChanges();
            }

        }
    }
}
