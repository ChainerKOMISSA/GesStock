using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiondeStock.Classes_Report;

namespace GestiondeStock.Formulaires
{
    public partial class ListeClient : UserControl
    {
        private static ListeClient UClient;
        private MyContext db;

        public static ListeClient Instance
        {
            get
            {
                if(UClient == null)
                {
                    UClient = new ListeClient();
                }
                return UClient;
            }
        }
        public ListeClient()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            AjouterClient AjoutClient = new AjouterClient(this);
            AjoutClient.ShowDialog();
        }

        public void ActualiserGrid()
        {
            dgvclient.Rows.Clear();
            foreach (var i in db.Clients)
            {
                dgvclient.Rows.Add(i.Nom_Client,i.Contact_Client,i.Localisation_Client);
            }
        }

        private void ListeClient_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            AjouterClient AjoutClient = new AjouterClient(this);
            AjoutClient.lbltitre.Text = "Modifier ce client";
            AjoutClient.btnannuler.Visible = false;
            AjoutClient.ShowDialog();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            /*for(int i =0;i<dgvclient.Rows.Count;i++)
            {
                if((bool)dgvclient.Rows[i].Cells[0].Value == true)
                {

                }
            }
            DialogResult R = 
            MessageBox.Show("Voulez-vous vraiment supprimer ce client", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                Classes.ClsClient clsClient = new Classes.ClsClient();
                clsClient.SupprimerClient(string Nom,string Contact,string Localisation);

            }*/
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            
            Etats.ClientViewer clientViewer = new Etats.ClientViewer();
            clientViewer.Show();
        }
    }
}
