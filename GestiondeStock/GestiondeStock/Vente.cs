//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestiondeStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vente
    {
        public int Id_Vente { get; set; }
        public int Id_Produit { get; set; }
        public int Id_Modele { get; set; }
        public int Prix_Vente { get; set; }
        public int Quantite_Vente { get; set; }
        public string Montant_Vente { get; set; }
        public int Id_Client { get; set; }
        public System.DateTime Date_Vente { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Produit Produit { get; set; }
    }
}