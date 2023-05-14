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
    public partial class ListeCommande : UserControl
    {
        private static ListeCommande UCommande;
        private MyContext db;

        public static ListeCommande Instance
        {
            get
            {
                if(UCommande == null)
                {
                    UCommande = new ListeCommande();
                }
                return UCommande;
            }
        }
        public ListeCommande()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            AjouterCommande Ajout = new AjouterCommande(this);
            Ajout.ShowDialog();
        }

        public void ActualiserGrid()
        {
            dgvcommande.Rows.Clear();
            int s = 0;
            foreach(var i in db.Commandes)
            {
                s++;
                dgvcommande.Rows.Add(s,i.Produit.Nom_Produit,i.Produit.Modele.Libelle_Modele,i.Prix_Achat,i.Quantite_Cmd,i.Montant_Cmd,i.Date_Cmd);
            }
        }

        private void ListeCommande_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }
    }
}
