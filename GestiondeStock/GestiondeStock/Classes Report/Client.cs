using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes_Report
{
    class ClientR
    {
        private int Id_Client;
        private string Nom_Client;
        private string Contact_Client;
        private string Localisation_Client;

        public ClientR(int id_Client, string nom_Client, string contact_Client, string localisation_Client)
        {
            Id_Client = id_Client;
            Nom_Client = nom_Client;
            Contact_Client = contact_Client;
            Localisation_Client = localisation_Client;
        }
    }
}
