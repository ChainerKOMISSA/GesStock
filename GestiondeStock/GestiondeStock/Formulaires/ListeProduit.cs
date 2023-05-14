using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiondeStock.Formulaires;
using GestiondeStock.Etats;

namespace GestiondeStock.Formulaires
{
    public partial class ListeProduit : UserControl
    {
        private static ListeProduit UProduit;
        private static MyContext db;

        public static ListeProduit Instance
        {
            get
            {
                if(UProduit == null)
                {
                    UProduit = new ListeProduit();
                }
                return UProduit;
            }
        }
        public ListeProduit()
        {
            InitializeComponent();
            db = new MyContext();
        }

        public void ActualiserGrid()
        {
            AjouterProduit Ajout = new AjouterProduit(this);
            db = new MyContext();
            dgvproduit.Rows.Clear();
            Brasserie bras = new Brasserie();
            Categorie cat = new Categorie();
            Modele mod = new Modele();
            int p = 0;
            foreach (var i in db.Produits)
            {
                p++;
                bras = db.Brasseries.SingleOrDefault(s => s.Id_Brasserie == i.Id_Brasserie);
                cat = db.Categories.SingleOrDefault(s => s.Id_Categorie == i.Id_Categorie);
                mod = db.Modeles.SingleOrDefault(s => s.Id_Modele == i.Id_Modele);
                if (bras != null && cat != null)
                {
                    dgvproduit.Rows.Add(p, i.Nom_Produit, i.Prix_Produit, bras.Nom_Brasserie, cat.Libelle_Categorie, mod.Libelle_Modele, i.Quantite);
                }

            }
        }

        private void ListeProduit_Load(object sender, EventArgs e)
        {
            /*AjouterProduit ajouterProduit = new AjouterProduit(this);
            AjouterVente ajouterVente = new AjouterVente(this);
            int qutte_vendue = Convert.ToInt32(ajouterVente.textquantite.Text.ToString());
            int qutte_totale = Convert.ToInt32(ajouterProduit.textquantite.Text.ToString());
            int qutte_rest = qutte_totale - qutte_vendue;
            if(ajouterProduit.textboisson.Text == ajouterVente.textboisson.Text)
            {
                string boisson = ajouterProduit.textboisson.Text;
                for(int i=0;i<dgvproduit.Rows.Count;i++)
                {
                    if(dgvproduit.Rows[i].Cells[1].Value.ToString() == boisson)
                    {
                        dgvproduit.Rows[i].Cells[6].Value = qutte_rest;
                    }
                }
            }*/
            ActualiserGrid();
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            ProduitViewer produitViewer = new ProduitViewer();
            produitViewer.Show();
            
        }
    }
}
