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
    public partial class ListeDepense : UserControl
    {
        private static ListeDepense UDepense;
        private MyContext db;
        public static ListeDepense Instance
        {
            get
            {
                if(UDepense == null)
                {
                    UDepense = new ListeDepense();
                }
                return UDepense;
            }
        }
        public ListeDepense()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            AjouterDepense Ajout = new AjouterDepense(this);
            Ajout.ShowDialog();
        }

        public void ActualiserGrid()
        {
            int s = 0;
            dgvdepense.Rows.Clear();
            foreach (var i in db.Depenses)
            {
                s++;
                dgvdepense.Rows.Add(s, i.Libelle_Depense, i.Montant_Depense, i.Date_Depense);
            }
        }

        private void ListeDepense_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            Etats.DepenseViewer depenseViewer = new Etats.DepenseViewer();
            depenseViewer.Show();
        }
    }
}
