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
    public partial class AjouterCommande : Form
    {

        private UserControl UsCommande;
        private MyContext db;
        public AjouterCommande(UserControl userCmd)
        {
            InitializeComponent();
            db = new MyContext();
            this.UsCommande = userCmd;
            //remplir combo brasserie
            combobras.DataSource = db.Brasseries.ToList();
            combobras.DisplayMember = "Nom_Brasserie";
            combobras.ValueMember = "Id_Brasserie";
            //combo categorie
            combocat.DataSource = db.Categories.ToList();
            combocat.DisplayMember = "Libelle_Categorie";
            combocat.ValueMember = "Id_Categorie";
            //combo modele
            combomod.DataSource = db.Modeles.ToList();
            combomod.DisplayMember = "Libelle_Modele";
            combomod.ValueMember = "Id_Modele";
            //combo boisson
            comboboisson.DataSource = db.Produits.ToList();
            comboboisson.DisplayMember = "Nom_Produit";
            comboboisson.ValueMember = "Id_Produit";
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        string testobligatoire()
        {
            if (textprix.Text == "")
            {
                return "Veuillez entrer le prix";
            }
            if (textquantite.Text == "")
            {
                return "Veuillez entrer la quantité";
            }
            return null;
        }

        private void AjouterCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'lACAMIONNETTEDataSet.Brasserie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.brasserieTableAdapter.Fill(this.lACAMIONNETTEDataSet.Brasserie);

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datagridcmd.Rows.Add(combobras.SelectedValue.ToString(), combocat.SelectedValue.ToString(), comboboisson.SelectedValue.ToString(), combomod.SelectedValue.ToString(), textprix.Text, textquantite.Text, textmontant.Text);
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Classes.ClsCommande clsCommande = new Classes.ClsCommande();
            if(testobligatoire()!= null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lbltitre.Text == "Enregistrer une commande")
                {
                    if (clsCommande.AjouterCommande(Convert.ToInt32(comboboisson.SelectedValue),
                        Convert.ToInt32(combomod.SelectedValue), int.Parse(textprix.Text),
                        int.Parse(textquantite.Text),int.Parse(textmontant.Text),datecmdpicker.Value) == true)
                    {
                        MessageBox.Show("Commande ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsCommande as ListeCommande).ActualiserGrid();
                    }
                    else
                    {
                        MessageBox.Show("Cette commande a déjà été effectuée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textmontant_Enter(object sender, EventArgs e)
        {
            textmontant.Text = (int.Parse(textprix.Text) * int.Parse(textquantite.Text)).ToString();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
           
            textmontant.Text = "";
            textprix.Text = "";
            textquantite.Text = "";
            
        }
    }
}
