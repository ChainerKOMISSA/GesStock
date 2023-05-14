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
    public partial class ListeModele : UserControl
    {

        private static ListeModele UModele;
        private MyContext db;


        public static ListeModele Instance
        {
            get
            {
                if(UModele == null)
                {
                    UModele = new ListeModele();
                }
                return UModele;
            }
        }
        public ListeModele()
        {
            InitializeComponent();
            db = new MyContext();
        }

        public void ActualiserGrid()
        {
            dgvmodele.Rows.Clear();
            foreach (var i in db.Modeles)
            {
                dgvmodele.Rows.Add(i.Libelle_Modele);
            }
        }

        private void ListeModele_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Formulaires.AjouterModele Ajout = new AjouterModele(this);
            Ajout.ShowDialog();
        }

        private void dgvmodele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AjouterModele Ajout = new AjouterModele(this);
            if (dgvmodele.Columns[e.ColumnIndex].Name == "Modifier")
            {
                Ajout.lbltitre.Text = "Modifier le modèle";
                Ajout.textnom.Text = dgvmodele.Rows[e.RowIndex].Cells[0].Value.ToString();
                Ajout.ShowDialog();
            }
        }
    }
}
