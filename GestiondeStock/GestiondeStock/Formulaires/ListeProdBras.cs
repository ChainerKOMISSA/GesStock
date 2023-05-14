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

namespace GestiondeStock.Formulaires
{
    public partial class ListeProdBras : UserControl
    {
        private static ListeProdBras UsProduit;
        private MyContext db;

        public static ListeProdBras Instance
        {
            get
            {
                if(UsProduit == null)
                {
                    UsProduit = new ListeProdBras();
                }
                return UsProduit;
            }
        }
        public ListeProdBras()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void dgvbrasserie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualiserGrid()
        {
            AjouterProduit Ajout = new AjouterProduit(this);
            dgvprod.Rows.Clear();
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
                    dgvprod.Rows.Add(p, i.Nom_Produit, i.Prix_Produit, bras.Nom_Brasserie, cat.Libelle_Categorie, mod.Libelle_Modele, i.Quantite);
                }
                
            }
            
        }


        private void btnajouter_Click(object sender, EventArgs e)
        {
            AjouterProduit Ajout = new AjouterProduit(this);
            Ajout.ShowDialog();
        }

        private void ListeProdBras_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        //verifier le nombre de ligne selectionner
        /*public string selectverification()
        {
            int nbreligneselect = 0;
            for (int i = 0; i < dgvprod.Rows.Count; i++)
            {
               nbreligneselect++;
                
            }
            if (nbreligneselect == 0)
            {
                return "Selectionner le produit que vous voulez modifier";
            }
            if (nbreligneselect > 1)
            {
                return "Selectionner seulement un seul produit";
            }
            return null;
        }*/
        private void btnmod_Click(object sender, EventArgs e)
        {
           /* Formulaires.AjouterProduit Ajout = new AjouterProduit(this);
            //if (selectverification() != null)
            //{
                for (int i=0; i<dgvprod.Rows.Count;i++)
                { 
                        Ajout.textboisson.Text = dgvprod.Rows[i].Cells[1].Value.ToString();
                        Ajout.textprix.Text = dgvprod.Rows[i].Cells[2].Value.ToString();
                        Ajout.combobras.Text = dgvprod.Rows[i].Cells[3].Value.ToString();
                        Ajout.combocat.Text = dgvprod.Rows[i].Cells[4].Value.ToString();
                        Ajout.combomod.Text = dgvprod.Rows[i].Cells[5].Value.ToString();
                        Ajout.textquantite.Text = dgvprod.Rows[i].Cells[6].Value.ToString();
                }
                
            //}
            Ajout.lbltitre.Text = "Modifier ce produit";
            Ajout.btnannuler.Visible = false;
            Ajout.ShowDialog();*/



        }
    }
}
