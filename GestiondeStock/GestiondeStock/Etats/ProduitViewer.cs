using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiondeStock.Classes_Report;

namespace GestiondeStock.Etats
{
    public partial class ProduitViewer : Form
    {
        private MyContext db = new MyContext();
        public ProduitViewer()
        {
            InitializeComponent();
        }

        private void ProduitViewer_Load(object sender, EventArgs e)
        {
            var i = (from prod in db.Produits
                     join bras in db.Brasseries on prod.Id_Brasserie equals bras.Id_Brasserie
                     join cat in db.Categories on prod.Id_Categorie equals cat.Id_Categorie
                     join mod in db.Modeles on prod.Id_Modele equals mod.Id_Modele
                     select new
                     {
                         prod.Id_Produit,
                         prod.Nom_Produit,
                         prod.Prix_Produit,
                         bras.Nom_Brasserie,
                         cat.Libelle_Categorie,
                         mod.Libelle_Modele,
                         prod.Quantite
                     }
                     ).ToList();
            List<ProduitR> listeproduit = new List<ProduitR>();
            foreach (var s in i)
            {
                listeproduit.Add(new ProduitR(int.Parse(s.Id_Produit.ToString()), s.Nom_Produit.ToString(), int.Parse(s.Prix_Produit.ToString()), s.Nom_Brasserie.ToString(),
                    s.Libelle_Categorie.ToString(), s.Libelle_Modele.ToString(), int.Parse(s.Quantite.ToString())));
                ReportProduit reportProduit = new ReportProduit();
                reportProduit.SetDataSource(listeproduit);
                ReportViewerProduit.ReportSource = reportProduit;
            }
            
        }
    }
}
