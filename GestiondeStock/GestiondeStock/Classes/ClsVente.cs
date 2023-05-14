using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsVente
    {
        private MyContext db = new MyContext();
        private Vente V;

        public bool AjouterVente(int Produit,int Modele, int Prix_Vt, int Quantite_Vt, string Montant_Vt, int Client, DateTime Date_Vt)
        {
            V = new Vente();
            V.Id_Produit = Produit;
            V.Id_Modele = Modele;
            V.Prix_Vente = Prix_Vt;
            V.Quantite_Vente = Quantite_Vt;
            V.Montant_Vente = Montant_Vt;
            V.Id_Client = Client;
            V.Date_Vente = Date_Vt;
            db.Ventes.Add(V);
            db.SaveChanges();
            return true;
        }
    }
}
