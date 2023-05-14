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
    public partial class AjouterClient : Form
    {
        private UserControl UsClient;
        public AjouterClient(UserControl userC)
        {
            InitializeComponent();
            this.UsClient = userC;
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        string testobligatoire()
        {
            if(textnom.Text =="" || textnom.Text == "Entrez le nom")
            {
                return "Veuillez entrer le nom";
            }
            if(textcontact.Text == "" || textcontact.Text == "Entrez le contact")
            {
                return "Veuillez entrer le contact";
            }
            if (textloca.Text == "" || textloca.Text == "Entrez la localisation")
            {
                return "Veuillez entrer la localisation";
            }
            return null;
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
            if (textnom.Text == "")
            {
                textnom.Text = "Entrez le nom";
                textnom.ForeColor = Color.Silver;
            }
        }

        private void textcontact_Enter(object sender, EventArgs e)
        {
            if (textcontact.Text == "Entrez le contact")
            {
                textcontact.Text = "";
                textcontact.ForeColor = Color.White;
            }

        }

        private void textcontact_Leave(object sender, EventArgs e)
        {
            if (textcontact.Text == "")
            {
                textcontact.Text = "Entrez le contact";
                textcontact.ForeColor = Color.Silver;
            }
        }

        private void textloca_Enter(object sender, EventArgs e)
        {
            if (textloca.Text == "Entrez la localisation")
            {
                textloca.Text = "";
                textloca.ForeColor = Color.White;
            }
        }

        private void textloca_Leave(object sender, EventArgs e)
        {
            if (textloca.Text == "")
            {
                textloca.Text = "Entrez la localisation";
                textloca.ForeColor = Color.Silver;
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            textnom.Text = "Entrez le nom";
            textnom.ForeColor = Color.Silver;
            textcontact.Text = "Entrez le contact";
            textcontact.ForeColor = Color.Silver;
            textloca.Text = "Entrez la localisation";
            textloca.ForeColor = Color.Silver;
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lbltitre.Text == "Ajouter un client")
                {
                    Classes.ClsClient clsClient = new Classes.ClsClient();
                    if (clsClient.AjouterClient(textnom.Text, textcontact.Text, textloca.Text) == true)
                    {
                        MessageBox.Show("Client ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsClient as ListeClient).ActualiserGrid();
                        textnom.Text = "";
                        textcontact.Text = "";
                        textloca.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Ce client existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Classes.ClsClient clsClient = new Classes.ClsClient();
                    clsClient.ModifierClient(textnom.Text, textcontact.Text,textloca.Text);
                }
            }
            
        }

        private void textcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}
