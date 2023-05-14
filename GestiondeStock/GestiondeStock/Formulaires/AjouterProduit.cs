using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
//using Tutorial.SqlConn;

namespace GestiondeStock.Formulaires
{
    public partial class AjouterProduit : Form
    {
        private UserControl UsProduit;
        private MyContext db;

        public AjouterProduit(UserControl userP)
        {
            InitializeComponent();
            this.UsProduit = userP;
            db = new MyContext();
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
        }

        string testobligatoire()
        {
            if (textprix.Text == "")
            {
                return "Veuillez entrer le prix de la boisson";
            }
            if(textboisson.Text == "")
            {
                return "Veuillez entrer la boisson";
            }
            if (textquantite.Text == "")
            {
                return "Veuillez entrer la quantité";
            }
            return null;
        }
        private void combomodele_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lbltitre.Text == "Ajouter un produit")
                {
                    Classes.ClsProduit clsProduit = new Classes.ClsProduit();
                    if (clsProduit.AjouterProduit(textboisson.Text, 
                        int.Parse(textprix.Text), Convert.ToInt32(combobras.SelectedValue), 
                        Convert.ToInt32(combocat.SelectedValue), Convert.ToInt32(combomod.SelectedValue), 
                        int.Parse(textquantite.Text)) == true)
                    {
                        MessageBox.Show("Boisson ajoutée avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsProduit as ListeProdBras).ActualiserGrid();
                        ListeProduit listeProduit = new ListeProduit();
                        listeProduit.ActualiserGrid();
                    }
                    else
                    {
                        MessageBox.Show("Boisson existante", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               else//if(lbltitre.Text == "Modifier ce produit")
                {
                    Classes.ClsProduit clsProduit = new Classes.ClsProduit();
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier ce produit?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsProduit.ModifierProduit(textboisson.Text, int.Parse(textprix.Text), Convert.ToInt32(combobras.SelectedValue), Convert.ToInt32(combocat.SelectedValue), Convert.ToInt32(combomod.SelectedValue), int.Parse(textquantite.Text));
                        MessageBox.Show("Boisson modifiée avec succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UsProduit as ListeProdBras).ActualiserGrid();
                        
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                
               
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            
            textboisson.Text = "";
            textprix.Text = "";
            textquantite.Text = "";
        }
    }
    }

