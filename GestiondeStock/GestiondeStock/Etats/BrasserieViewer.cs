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
    public partial class BrasserieViewer : Form
    {
        private MyContext db = new MyContext();
        public BrasserieViewer()
        {
            InitializeComponent();

        }

        private void ReportViewerBrasserie_Load(object sender, EventArgs e)
        {
            var i = (from bras in db.Brasseries
                     select new
                     {
                         bras.Id_Brasserie,
                         bras.Nom_Brasserie
                     }
                     ).ToList();
            List<BrasserieR> listeBrasserie = new List<BrasserieR>();
            foreach (var s in i)
            {
                listeBrasserie.Add(new BrasserieR(int.Parse(s.Id_Brasserie.ToString()),s.Nom_Brasserie.ToString()));
            }
            ReportBrasserie reportBrasserie = new ReportBrasserie();
            reportBrasserie.SetDataSource(listeBrasserie);
            ReportViewerBrasserie.ReportSource = reportBrasserie;
        }
    }
}
