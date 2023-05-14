using GestiondeStock.Classes_Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock.Etats
{
    public partial class DepenseViewer : Form
    {
        private MyContext db = new MyContext();
        public DepenseViewer()
        {
            InitializeComponent();
        }

        private void ReportViewerDepense_Load(object sender, EventArgs e)
        {
            var i = (from dep in db.Depenses
                     select new
                     {
                         dep.Id_Depense,
                         dep.Libelle_Depense,
                         dep.Montant_Depense,
                         dep.Date_Depense
                     }
                     ).ToList();
            List<DépensesR> listeDepense = new List<DépensesR>();
            foreach (var s in i)
            {
                listeDepense.Add(new DépensesR(int.Parse(s.Id_Depense.ToString()), s.Libelle_Depense.ToString(), int.Parse(s.Montant_Depense.ToString()), s.Date_Depense.ToString()));
                ReportDepense reportDepense = new ReportDepense();
                ReportViewerDepense.ReportSource = reportDepense;
                reportDepense.SetDataSource(listeDepense);
                
            }
        }
    }
}
