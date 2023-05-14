using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes_Report
{
    class IncidentR
    {
        private int Id_Incident;
        private string Libelle_Incident;
        private string Date_Incident;

        public IncidentR(int id_Incident, string libelle_Incident, string date_Incident)
        {
            Id_Incident = id_Incident;
            Libelle_Incident = libelle_Incident;
            Date_Incident = date_Incident;
        }
    }


}
