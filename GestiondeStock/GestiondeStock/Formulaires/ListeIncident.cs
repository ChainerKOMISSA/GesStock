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
    public partial class ListeIncident : UserControl
    {
        private static ListeIncident UIncident;
        private MyContext db;

        public static ListeIncident Instance
        {
            get
            {
                if(UIncident == null)
                {
                    UIncident = new ListeIncident();
                }
                return UIncident;
            }
        }

        public ListeIncident()
        {
            InitializeComponent();
            db = new MyContext();
        }

        public void ActualiserGrid()
        {
            int s = 0;
            dgvincident.Rows.Clear();
            foreach(var i in db.Incidents)
            {
                s++;
                dgvincident.Rows.Add(s, i.Libelle_Incid, i.Date_Incid);
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            AjouterIncident Ajout = new AjouterIncident(this);
            Ajout.ShowDialog();
        }

        private void ListeIncident_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            Etats.IncidentViewer incidentViewer = new Etats.IncidentViewer();
            incidentViewer.Show();
        }
    }
}
