using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes_Report
{
    class VenteR
    {
        private int Id_Vente;
        private string Nom_Produit;
        private string Libelle_Modele;
        private int Prix_Vente;
        private int Quantite;
        private string Montant;
        private string Nom_Client;
        private string Date_Vente;

        public VenteR(int id_Vente, string nom_Produit, string libelle_Modele, int prix_Vente, int quantite, string montant, string nom_Client, string date_Vente)
        {
            Id_Vente = id_Vente;
            Nom_Produit = nom_Produit;
            Libelle_Modele = libelle_Modele;
            Prix_Vente = prix_Vente;
            Quantite = quantite;
            Montant = montant;
            Nom_Client = nom_Client;
            Date_Vente = date_Vente;
        }
    }
}
