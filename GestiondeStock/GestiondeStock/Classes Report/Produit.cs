using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes_Report
{
    class ProduitR
    {
        private int Id_Produit;
        private string Nom_Produit;
        private int Prix_Produit;
        private string Nom_Brasserie;
        private string Libelle_Categorie;
        private string Libelle_Modele;
        private int Quantite;

        public ProduitR(int id_Produit, string nom_Produit, int prix_Produit, string nom_Brasserie, string libelle_Categorie, string libelle_Modele, int quantite)
        {
            Id_Produit = id_Produit;
            Nom_Produit = nom_Produit;
            Prix_Produit = prix_Produit;
            Nom_Brasserie = nom_Brasserie;
            Libelle_Categorie = libelle_Categorie;
            Libelle_Modele = libelle_Modele;
            Quantite = quantite;
        }
    }
}
