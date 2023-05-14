using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsProduit
    {
        private MyContext db = new MyContext();
        private Produit P;

        public bool AjouterProduit(string Nom,int Prix,int Brasserie, int Categorie, int Modele, int QuantiteP)
        {
            P = new Produit();
            P.Nom_Produit = Nom;
            P.Prix_Produit = Prix;
            P.Id_Brasserie = Brasserie;
            P.Id_Categorie = Categorie;
            P.Id_Modele = Modele;
            P.Quantite = QuantiteP;
            if (db.Produits.SingleOrDefault(s => s.Nom_Produit == Nom) == null)
            {
                db.Produits.Add(P);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
                
                
        }

        public void ModifierProduit(string Nom, int Prix, int Brasserie, int Categorie, int Modele, int QuantiteP)
        {
            P = new Produit();
            P = db.Produits.SingleOrDefault(s => s.Nom_Produit == Nom);
            if (P != null)
            {
                P.Nom_Produit = Nom;
                P.Prix_Produit = Prix;
                P.Id_Brasserie = Brasserie;
                P.Id_Categorie = Categorie;
                P.Id_Modele = Modele;
                P.Quantite = QuantiteP;
                db.SaveChanges();
            }
            
        }

        public void SupprimerProduit()
        {

        }
    }
}
