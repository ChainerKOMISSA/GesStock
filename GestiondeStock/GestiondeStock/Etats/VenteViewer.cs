using GestiondeStock.Classes_Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock.Etats
{
    public partial class VenteViewer : Form
    {
        private MyContext db = new MyContext();
        public VenteViewer()
        {
            InitializeComponent();
        }

        private void ReportViewerVente_Load(object sender, EventArgs e)
        {
            var i = (from vte in db.Ventes
                     join prod in db.Produits on vte.Id_Produit equals prod.Id_Produit
                     join mod in db.Modeles on vte.Id_Modele equals mod.Id_Modele
                     join clt in db.Clients on vte.Id_Client equals clt.Id_Client
                     select new
                     {
                         vte.Id_Vente,
                         prod.Nom_Produit,
                         mod.Libelle_Modele,
                         vte.Prix_Vente,
                         vte.Quantite_Vente,
                         vte.Montant_Vente,
                         clt.Nom_Client,
                         vte.Date_Vente
                     }
                     ).ToList();
            List<VenteR> listeVente = new List<VenteR>();
            foreach(var s in i)
            {
                listeVente.Add(new VenteR(int.Parse(s.Id_Vente.ToString()), s.Nom_Produit.ToString(), s.Libelle_Modele.ToString(),
                    int.Parse(s.Prix_Vente.ToString()), int.Parse(s.Quantite_Vente.ToString()), s.Montant_Vente.ToString(),
                    s.Nom_Client.ToString(), s.Date_Vente.ToString()));
                ReportVente reportVente = new ReportVente();
                reportVente.SetDataSource(listeVente);
                ReportViewerVente.ReportSource = reportVente;
            }

        }
    }
}
