using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock.Formulaires
{
    public partial class ListeVente : UserControl
    {

        private static ListeVente UVente;
        private MyContext db;

        public static ListeVente Instance
        {
            get
            {
                if(UVente == null)
                {
                    UVente = new ListeVente();
                }
                return UVente;
            }
        }
        public ListeVente()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            AjouterVente Ajout = new AjouterVente(this);
            Ajout.ShowDialog();
        }

        public void ActualiserGrid()
        {
            dgvvente.Rows.Clear();
            int s = 0;
            foreach (var i in db.Ventes)
            {
                s++;
                dgvvente.Rows.Add(s, i.Produit.Nom_Produit, i.Produit.Modele.Libelle_Modele, i.Prix_Vente, i.Quantite_Vente, i.Montant_Vente, i.Client.Nom_Client, i.Date_Vente);
            }
        }

        private void ListeVente_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            Etats.VenteViewer venteViewer = new Etats.VenteViewer();
            venteViewer.Show();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            AjouterVente Ajout = new AjouterVente(this);
            Ajout.lbltitre.Text = "Modifier la vente";
            /*for(int i=0;i<dgvvente.Rows.Count;i++)
            {
                Ajout.textboisson.Text = dgvvente.Rows[i].Cells[1].Value.ToString();
                Ajout.textmodele.Text = dgvvente.Rows[i].Cells[2].Value.ToString();
            }*/
            Ajout.ShowDialog();

        }
    }
}
