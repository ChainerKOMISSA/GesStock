using GestiondeStock.Formulaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            pnlparametre.Visible = false;
        }
        public void DesactiverForm()
        {
            btnbrasserie.Enabled = false;
            btncategorie.Enabled = false;
            btnclient.Enabled = false;
            btncmd.Enabled = false;
            btndepense.Enabled = false;
            btnincident.Enabled = false;
            btnproduit.Enabled = false;
            btnvente.Enabled = false;
            btnuser.Enabled = false;
            btnmodele.Enabled = false;
            btnsvgarder.Enabled = false;
            btndeconnecter.Enabled = false;
            btnconnecter.Enabled = true;
        }

        public void ActiverForm()
        {
            btnbrasserie.Enabled = true;
            btncategorie.Enabled = true;
            btnclient.Enabled = true;
            btncmd.Enabled = true;
            btndepense.Enabled = true;
            btnincident.Enabled = true;
            btnproduit.Enabled = true;
            btnvente.Enabled = true;
            btnuser.Enabled = true;
            btnmodele.Enabled = true;
            btnsvgarder.Enabled = true;
            btndeconnecter.Enabled = true;
            btnconnecter.Enabled = false;
            pnlparametre.Visible = false;
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            DesactiverForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnbrasserie_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeBrasserie1.Instance))
            {
                pnlafficher.Controls.Add(ListeBrasserie1.Instance);
                ListeBrasserie1.Instance.Dock = DockStyle.Fill;
                ListeBrasserie1.Instance.BringToFront();
            }
            else
            {
                ListeBrasserie1.Instance.BringToFront();
            }
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeCategorie.Instance))
            {
                pnlafficher.Controls.Add(ListeCategorie.Instance);
                ListeCategorie.Instance.Dock = DockStyle.Fill;
                ListeCategorie.Instance.BringToFront();
            }
            else
            {
                ListeCategorie.Instance.BringToFront();
            }
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            if(!pnlafficher.Controls.Contains(ListeClient.Instance))
            {
                pnlafficher.Controls.Add(ListeClient.Instance);
                ListeClient.Instance.Dock = DockStyle.Fill;
                ListeClient.Instance.BringToFront();
            }
            else
            {
                ListeClient.Instance.BringToFront();
            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeProduit.Instance))
            {
                pnlafficher.Controls.Add(ListeProduit.Instance);
                ListeProduit.Instance.Dock = DockStyle.Fill;
                ListeProduit.Instance.BringToFront();
                ListeProduit.Instance.ActualiserGrid();
            }
            else
            {
                ListeProduit.Instance.BringToFront();
                ListeProduit.Instance.ActualiserGrid();
            }
        }

        private void btndepense_Click(object sender, EventArgs e)
        {
            if(!pnlafficher.Controls.Contains(ListeDepense.Instance))
            {
                pnlafficher.Controls.Add(ListeDepense.Instance);
                ListeDepense.Instance.Dock = DockStyle.Fill;
                ListeDepense.Instance.BringToFront();
            }
            else
            {
                ListeDepense.Instance.BringToFront();
            }
        }

        private void btnincident_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeIncident.Instance))
            {
                pnlafficher.Controls.Add(ListeIncident.Instance);
                ListeIncident.Instance.Dock = DockStyle.Fill;
                ListeIncident.Instance.BringToFront();
            }
            else
            {
                ListeIncident.Instance.BringToFront();
            }
        }

        private void btncmd_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeCommande.Instance))
            {
                pnlafficher.Controls.Add(ListeCommande.Instance);
                ListeCommande.Instance.Dock = DockStyle.Fill;
                ListeCommande.Instance.BringToFront();
            }
            else
            {
                ListeCommande.Instance.BringToFront();
            }
        }

        private void btnvente_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeVente.Instance))
            {
                pnlafficher.Controls.Add(ListeVente.Instance);
                ListeVente.Instance.Dock = DockStyle.Fill;
                ListeVente.Instance.BringToFront();
            }
            else
            {
                ListeVente.Instance.BringToFront();
            }
        }

        private void btnmodele_Click(object sender, EventArgs e)
        {
            if (!pnlafficher.Controls.Contains(ListeModele.Instance))
            {
                pnlafficher.Controls.Add(ListeModele.Instance);
                ListeModele.Instance.Dock = DockStyle.Fill;
                ListeModele.Instance.BringToFront();
            }
            else
            {
                ListeModele.Instance.BringToFront();
            }
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnparametre_Click(object sender, EventArgs e)
        {
            pnlparametre.Size = new Size(508, 196);
            pnlparametre.Visible = !pnlparametre.Visible;
        }

        private void pnlafficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnconnecter_Click(object sender, EventArgs e)
        {
            FormConnexion Connexion = new FormConnexion(this);
            Connexion.ShowDialog();

        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            DesactiverForm();
        }
    }
}
