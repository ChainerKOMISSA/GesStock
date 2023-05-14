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

namespace GestiondeStock.Etats
{
    public partial class ClientViewer : Form
        
    {
        private MyContext db = new MyContext();
        public ClientViewer()

        {
            InitializeComponent();  
        }

        private void ReportViewerClient_Load(object sender, EventArgs e)
        {
            var i = (from clt in db.Clients
                     select new
                     {
                         clt.Id_Client,
                         clt.Nom_Client,
                         clt.Contact_Client,
                         clt.Localisation_Client
                     }
                     ).ToList();
            List<ClientR> listeClient = new List<ClientR>();
            foreach (var s in i)
            {
                listeClient.Add(new ClientR(int.Parse(s.Id_Client.ToString()), s.Nom_Client.ToString(), s.Contact_Client.ToString(), s.Localisation_Client.ToString()));
            }
            ReportClient reportClient = new ReportClient();
            reportClient.SetDataSource(listeClient);
            ReportViewerClient.ReportSource = reportClient;
        }
    }
}
