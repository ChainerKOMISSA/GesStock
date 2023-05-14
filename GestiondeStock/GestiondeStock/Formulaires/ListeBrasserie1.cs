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
    public partial class ListeBrasserie1 : UserControl
    {

        private static ListeBrasserie1 liste;
        private MyContext db;

        public static ListeBrasserie1 Instance
        {
            get
            {
                if(liste == null)
                {
                    liste = new ListeBrasserie1();
                }
                return liste;
            }
        }
        public ListeBrasserie1()
        {
            InitializeComponent();
            db = new MyContext();

        }

        private void btnbrasserie_Click(object sender, EventArgs e)
        {
            if (!pnlafficher2.Controls.Contains(ListeBrasserie2.Instance))
            {
                pnlafficher2.Controls.Add(ListeBrasserie2.Instance);
                ListeBrasserie2.Instance.Dock = DockStyle.Fill;
                ListeBrasserie2.Instance.BringToFront();
            }
            else
            {
                ListeBrasserie2.Instance.BringToFront();
            }
        }

        private void btnboisson_Click(object sender, EventArgs e)
        {
            if (!pnlafficher2.Controls.Contains(ListeProdBras.Instance))
            {
                pnlafficher2.Controls.Add(ListeProdBras.Instance);
                ListeProdBras.Instance.Dock = DockStyle.Fill;
                ListeProdBras.Instance.BringToFront();
            }
            else
            {
                ListeProdBras.Instance.BringToFront();
            }
        }
    }
}
