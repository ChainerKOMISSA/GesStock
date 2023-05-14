using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsCommande
    {
        private MyContext db = new MyContext();
        private Commande Cmd;

        public bool AjouterCommande(int Produit, int Modele, int Prix, int Quantite, int Montant, DateTime DateCmd)
        {
            Cmd = new Commande();
            Cmd.Id_Produit = Produit;
            Cmd.Id_Modele = Modele;
            Cmd.Prix_Achat = Prix;
            Cmd.Quantite_Cmd = Quantite;
            Cmd.Montant_Cmd = Montant;
            Cmd.Date_Cmd = DateCmd;
            db.Commandes.Add(Cmd);
            db.SaveChanges();
            return true;
        }
    }
}
