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
    public partial class AjouterCategorie : Form
    {
        private UserControl uscategorie;
        public AjouterCategorie(UserControl userCat)
        {
            InitializeComponent();
            this.uscategorie = userCat;
        }

        string testobligatoire()
        {
            if (textnom.Text == "" || textnom.Text == "Entrez le nom")
            {
                return "Veuillez entrer le nom de la catégorie";
            }
            if(textdesc.Text == "" || textdesc.Text == "Entrez la description")
            {
                return "Veuillez entrer la description";
            }
            return null;
        }
        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textnom_Enter(object sender, EventArgs e)
        {
            if(textnom.Text == "Entrez le nom")
            {
                textnom.Text = "";
                textnom.ForeColor = Color.White;
            }
        }

        private void textnom_Leave(object sender, EventArgs e)
        {
            if(textnom.Text == "")
            {
                textnom.Text = "Entrez le nom";
                textnom.ForeColor = Color.Silver;
            }
        }

        private void textdesc_Enter(object sender, EventArgs e)
        {
            if (textdesc.Text == "Entrez la description")
            {
                textdesc.Text = "";
                textdesc.ForeColor = Color.White;
            }
        }

        private void textdesc_Leave(object sender, EventArgs e)
        {
            if (textdesc.Text == "")
            {
                textdesc.Text = "Entrez la description";
                textdesc.ForeColor = Color.Silver;
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Classes.ClsCategorie clsCategorie = new Classes.ClsCategorie();
            if (testobligatoire()!= null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lbltitre.Text == "Ajouter une catégorie")
                {
                    
                    if (clsCategorie.AjouterCategorie(textnom.Text, textdesc.Text) == true)
                    {
                        MessageBox.Show("Catégorie ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (uscategorie as ListeCategorie).ActualiserGrid();
                        textnom.Text = ""; textdesc.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cette catégorie existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(lbltitre.Text == "Modifier la catégorie")
                {
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier la catégorie?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(R == DialogResult.Yes)
                    {
                        clsCategorie.ModifierCategorie(textnom.Text, textdesc.Text);
                        MessageBox.Show("Catégorie modifiée avec succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (uscategorie as ListeCategorie).ActualiserGrid();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }
    }
}
