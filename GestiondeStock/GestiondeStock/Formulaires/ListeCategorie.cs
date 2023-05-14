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
    public partial class ListeCategorie : UserControl
    {
        private static ListeCategorie UCategorie;
        private MyContext db;
        public static ListeCategorie Instance
        {
            get
            {
                if(UCategorie == null)
                {
                    UCategorie = new ListeCategorie();
                }
                return UCategorie;
            }
        }
        public ListeCategorie()
        {
            InitializeComponent();
            db = new MyContext();
        }

        public void ActualiserGrid()
        {
            dgvcategorie.Rows.Clear();
            foreach (var i in db.Categories)
            {
                dgvcategorie.Rows.Add(i.Libelle_Categorie,i.Description_Categorie);
            }
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            Formulaires.AjouterCategorie AjoutCategorie = new AjouterCategorie(this);
            AjoutCategorie.ShowDialog();
        }

        private void ListeCategorie_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void dgvcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AjouterCategorie Ajout = new AjouterCategorie(this);
            if(dgvcategorie.Columns[e.ColumnIndex].Name == "Modifier")
            {
                Ajout.lbltitre.Text = "Modifier la catégorie";
                Ajout.textnom.Text = dgvcategorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                Ajout.ShowDialog();
            }
        }
    }
}
