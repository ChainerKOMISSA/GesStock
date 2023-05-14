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
    public partial class AjouterVente : Form
    {
        private UserControl UsVente;
        private MyContext db;
        public AjouterVente(UserControl userV)
        {
            InitializeComponent();
            db = new MyContext();
            this.UsVente = userV;
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
            //combo client
            comboclient.DataSource = db.Clients.ToList();
            comboclient.DisplayMember = "Nom_Client";
            comboclient.ValueMember = "Id_Client";
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


        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    dgvresultat.Rows.Add(combobras.SelectedValue.ToString(), combocat.SelectedValue.ToString(), comboboisson.SelectedValue.ToString(), combomod.SelectedValue.ToString(), comboclient.SelectedValue.ToString(), textprix.Text, textquantite.Text, textmontant.Text);
            }
        }
        private void btnannuler_Click(object sender, EventArgs e)
        {
            
            textmontant.Text = "";
            textprix.Text = "";
            textquantite.Text = "";
            
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lbltitre.Text == "Nouvelle vente")
                {
                    Classes.ClsVente clsVente = new Classes.ClsVente();
                    if (clsVente.AjouterVente(Convert.ToInt32(comboboisson.SelectedValue), 
                        Convert.ToInt32(combomod.SelectedValue), int.Parse(textprix.Text), 
                        int.Parse(textquantite.Text), textmontant.Text, Convert.ToInt32(comboclient.SelectedValue),datevente.Value) == true)
                    {
                        MessageBox.Show("Vente effectuée avec succés", "Nouvelle vente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsVente as ListeVente).ActualiserGrid();
                    }
                    else
                    {
                        MessageBox.Show("Cette vente existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void textmontant_Enter(object sender, EventArgs e)
        {
            textmontant.Text = (int.Parse(textprix.Text) * int.Parse(textquantite.Text)).ToString();
        }
    }
}
