using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock.Formulaires
{
    public partial class AjouterDepense : Form
    {
        private UserControl UsDepense;
        public AjouterDepense(UserControl userD)
        {
            InitializeComponent();
            this.UsDepense = userD;
        }

        string testobligatoire()
        {
            if(textlibelle.Text == "" || textlibelle.Text == "Entrez le libelle")
            {
                return "Veuillez entrez le libellé";
                
            }
            if(textmontant.Text == "" || textmontant.Text == "Entrez le montant")
            {
                return "Veuillez entrer le montant";
            }
            return null;
        }

        string VerifDate()
        {
            if(textdate.Value > DateTime.Today)
            {
                return "Veuillez choisir une bonne date";
            }
            return null;
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <48 || e.KeyChar>57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void textlibelle_Enter(object sender, EventArgs e)
        {
            if(textlibelle.Text == "Entrez le libelle")
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

        private void textmontant_Enter(object sender, EventArgs e)
        {
            if (textmontant.Text == "Entrez le montant")
            {
                textmontant.Text = "";
                textmontant.ForeColor = Color.White;
            }
        }

        private void textmontant_Leave(object sender, EventArgs e)
        {
            if (textmontant.Text == "")
            {
                textmontant.Text = "Entrez le montant";
                textmontant.ForeColor = Color.Silver;
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            textlibelle.Text = "Entrez le libelle";
            textlibelle.ForeColor = Color.Silver;
            textmontant.Text = "Entrez le montant";
            textmontant.ForeColor = Color.Silver;
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifDate()!= null)
            {
                MessageBox.Show(VerifDate(), "Vérifiez la date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Classes.ClsDepense clsDepense = new Classes.ClsDepense();
                //CultureInfo arSA = new CultureInfo("ar-SA");
                //arSA.DateTimeFormat.Calendar = new UmAlQuraCalendar();
                //DateTime date1 = new DateTime(textdate.Text);
                if (clsDepense.AjouterDepense(textlibelle.Text, textmontant.Text, textdate.Value) == true)
                {
                    MessageBox.Show("Dépense ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (UsDepense as ListeDepense).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Cette dépense existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
