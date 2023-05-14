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
    public partial class IncidentViewer : Form
    {
        private MyContext db = new MyContext();
        public IncidentViewer()
        {
            InitializeComponent();
        }

        private void ReportViewerIncident_Load(object sender, EventArgs e)
        {
            var i = (from inc in db.Incidents
                     select new
                     {
                         inc.Id_Incid,
                         inc.Libelle_Incid,
                         inc.Date_Incid
                     }
                     ).ToList();
            List<IncidentR> listeIncident = new List<IncidentR>();
            foreach (var s in i)
            {
                listeIncident.Add(new IncidentR(int.Parse(s.Id_Incid.ToString()), s.Libelle_Incid.ToString(), s.Date_Incid.ToString()));
                ReportIncident reportIncident = new ReportIncident();
                reportIncident.SetDataSource(listeIncident);
                ReportViewerIncident.ReportSource = reportIncident;
            }
        }
    }
}
