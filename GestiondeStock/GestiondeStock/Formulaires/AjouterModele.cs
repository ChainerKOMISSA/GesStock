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
    public partial class AjouterModele : Form
    {

        private UserControl UsModele;
        public AjouterModele(UserControl userM)
        {
            InitializeComponent();
            this.UsModele = userM;
        }

        string testobligatoire()
        {
            if (textnom.Text == "" || textnom.Text == "Entrez le libellé")
            {
                return "Veuillez entrer le libellé du modèle";
            }
            return null;
        }
        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            textnom.Text = "Entrez le libellé";
            textnom.ForeColor = Color.Silver;
        }

        private void textnom_Enter(object sender, EventArgs e)
        {
            if (textnom.Text == "Entrez le libellé")
            {
                textnom.Text = "";
                textnom.ForeColor = Color.White;
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Classes.ClsModele clsModele = new Classes.ClsModele();
            if (testobligatoire()!= null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lbltitre.Text == "Ajouter un modèle")
                {
                    if (clsModele.AjouterModele(textnom.Text) == true)
                    {
                        MessageBox.Show("Modèle ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsModele as ListeModele).ActualiserGrid();
                        textnom.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cet modèle existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(lbltitre.Text == "Modifier le modèle")
                {
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier le modèle?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsModele.ModifierModele(textnom.Text);
                        MessageBox.Show("Modèle modifié avec succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsModele as ListeModele).ActualiserGrid();
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

