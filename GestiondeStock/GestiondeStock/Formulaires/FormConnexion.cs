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
    public partial class FormConnexion : Form
    {

        private MyContext db;
        private Form frmmenu;
        Classes.ClsConnexion clsConnexion = new Classes.ClsConnexion();
        public FormConnexion(Form menu)
        {
            InitializeComponent();
            this.frmmenu = menu;
            db = new MyContext();
        }

        string testobligatoire()
        {
            if(textnom.Text == "" || textnom.Text == "Nom d'utilisateur")
            {
                return "Veuillez entrer le nom";
            }
            if(textmdp.Text == "" || textmdp.Text == "Mot de passe")
            {
                return "Veuillez entrer le mot de passe";
            }
            return null;
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textnom_Enter(object sender, EventArgs e)
        {
            if(textnom.Text == "Nom d'utilisateur")
            {
                textnom.Text = "";
                textnom.ForeColor = Color.White;
            }
        }

        private void textmdp_Enter(object sender, EventArgs e)
        {
            if (textmdp.Text == "Mot de passe")
            {
                textmdp.Text = "";
                textmdp.UseSystemPasswordChar = false;
                textmdp.PasswordChar = '•';
                textmdp.ForeColor = Color.White;
            }
        }

        private void textnom_Leave(object sender, EventArgs e)
        {
            if(textnom.Text == "")
            {
                textnom.Text = "Nom d'utilisateur";
                textnom.ForeColor = Color.Silver;
            }
        }

        private void textmdp_Leave(object sender, EventArgs e)
        {
            if (textmdp.Text == "")
            {
                textmdp.Text = "Mot de passe";
                textmdp.UseSystemPasswordChar = true;
                textmdp.ForeColor = Color.Silver;
            }
        }

        private void btnseconnecter_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!= null)
            {
                MessageBox.Show(testobligatoire(), "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               if(clsConnexion.VerifyConnexion(db,textnom.Text,textmdp.Text) == true)
                {
                    MessageBox.Show("Connexion réussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as MenuPrincipal).ActiverForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion échouée", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
