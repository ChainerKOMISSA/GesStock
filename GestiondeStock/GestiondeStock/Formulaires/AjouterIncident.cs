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
    public partial class AjouterIncident : Form
    {
        private UserControl UsIncident;
        public AjouterIncident(UserControl userI)
        {
            InitializeComponent();
            this.UsIncident = userI;
        }


        string testobligatoire()
        {
            if (textlibelle.Text == "" || textlibelle.Text == "Entrez le libelle")
            {
                return "Veuillez entrez le libellé";

            }
            return null;
        }

        string VerifDate()
        {
            if (textdate.Value > DateTime.Today)
            {
                return "Veuillez choisir une bonne date";
            }
            return null;
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textlibelle_Enter(object sender, EventArgs e)
        {
            if (textlibelle.Text == "Entrez le libelle")
            {
                textlibelle.Text = "";
                textlibelle.ForeColor = Color.White;
            }
        }

        private void textlibelle_Leave(object sender, EventArgs e)
        {
            if (textlibelle.Text == "")
            {
                textlibelle.Text = "Entrez le libelle";
                textlibelle.ForeColor = Color.Silver;
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            textlibelle.Text = "Entrez le libelle";
            textlibelle.ForeColor = Color.Silver;
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifDate() != null)
            {
                MessageBox.Show(VerifDate(), "Vérifiez la date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Classes.ClsIncident clsIncident = new Classes.ClsIncident();
                //CultureInfo arSA = new CultureInfo("ar-SA");
                //arSA.DateTimeFormat.Calendar = new UmAlQuraCalendar();
                //DateTime date1 = new DateTime(textdate.Text);
                if (clsIncident.AjouterIncident(textlibelle.Text, textdate.Value) == true)
                {
                    MessageBox.Show("Incident ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (UsIncident as ListeIncident).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Cet incident existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
