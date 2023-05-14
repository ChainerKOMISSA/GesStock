using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes_Report
{
    class DépensesR
    {
        private int Id_Dep;
        private string Libelle_Dep;
        private int Montant_Dep;
        private string Date_Dep;
        

        public DépensesR(int id_Dep, string libelle_Dep, int montant_Dep, string date_Dep)
        {
            Id_Dep = id_Dep;
            Libelle_Dep = libelle_Dep;
            Montant_Dep = montant_Dep;
            Date_Dep = date_Dep;

        }
    }
}
