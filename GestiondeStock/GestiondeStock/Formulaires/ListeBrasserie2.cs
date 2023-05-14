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
    public partial class ListeBrasserie2 : UserControl
    {
        private static ListeBrasserie2 UBrasserie;
        private MyContext db;

        public static ListeBrasserie2 Instance
        {
            get
            {
                if (UBrasserie == null)
                {
                    UBrasserie = new ListeBrasserie2();
                }
                return UBrasserie;
            }
        }
        public ListeBrasserie2()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Formulaires.AjouterBrasserie AjoutBrasserie = new AjouterBrasserie(this);
            AjoutBrasserie.ShowDialog();
        }
        public void ActualiserGrid()
        {
            dgvbrasserie.Rows.Clear();
            foreach (var i in db.Brasseries)
            {
                dgvbrasserie.Rows.Add(i.Nom_Brasserie);
            }
        }

        private void ListeBrasserie_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void dgvbrasserie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* AjouterBrasserie Ajout = new AjouterBrasserie(this);
            if (dgvbrasserie.Columns[e.ColumnIndex].Name == "Modifier")
            {
                Ajout.lbltitre.Text = "Modifier la brasserie";
                Ajout.textnom.Text = dgvbrasserie.Rows[e.RowIndex].Cells[0].Value.ToString();
                Ajout.ShowDialog();
            }
            if(dgvbrasserie.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                Classes.ClsBrasserie clsBrasserie = new Classes.ClsBrasserie();
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer cette brasserie?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    clsBrasserie.SupprimerBrasserie();
                    MessageBox.Show("Brasserie supprimée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (UBrasserie as ListeBrasserie2).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            Etats.BrasserieViewer brasserieViewer = new Etats.BrasserieViewer();
            brasserieViewer.Show();
        }
    }
}
