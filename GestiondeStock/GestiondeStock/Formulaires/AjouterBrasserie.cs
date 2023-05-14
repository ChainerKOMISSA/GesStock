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
    public partial class AjouterBrasserie : Form
    {
        private UserControl usbrasserie;
        public AjouterBrasserie(UserControl userB)
        {
            InitializeComponent();
            this.usbrasserie = userB;
        }

        string testobligatoire()
        {
            if (textnom.Text == "" || textnom.Text == "Entrez le nom")
            {
                return "Veuillez entrer le nom de la brasserie";
            }
            return null;
        }
        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textnom_Enter_1(object sender, EventArgs e)
        {
            if (textnom.Text == "Entrez le nom")
            {
                textnom.Text = "";
                textnom.ForeColor = Color.White;
            }
        }

        private void btnannuler_Click_1(object sender, EventArgs e)
        {
            textnom.Text = "Entrez le nom";
            textnom.ForeColor = Color.DarkGray;
        }

        private void btnvalider_Click_1(object sender, EventArgs e)
        {
            Classes.ClsBrasserie clsBrasserie = new Classes.ClsBrasserie();
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(lbltitre.Text == "Ajouter une brasserie")
                {
                    if (clsBrasserie.AjouterBrasserie(textnom.Text) == true)
                    {
                        MessageBox.Show("Brasserie ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usbrasserie as ListeBrasserie2).ActualiserGrid();
                        textnom.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cette brasserie existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (lbltitre.Text == "Modifier la brasserie")
                {
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier la brasserie?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsBrasserie.ModifierBrasserie(textnom.Text);
                        MessageBox.Show("Brasserie modifiée avec succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usbrasserie as ListeBrasserie2).ActualiserGrid();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private void AjouterBrasserie_Load(object sender, EventArgs e)
        {

        }
    }
}
