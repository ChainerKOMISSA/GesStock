using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsClient
    {
        private MyContext db = new MyContext();
        private Client C;

        

        public bool AjouterClient(string Nom,string Contact,string Localisation)
        {
            C = new Client();
            C.Nom_Client = Nom;
            C.Contact_Client = Contact;
            C.Localisation_Client = Localisation;
            if (db.Clients.SingleOrDefault(s => s.Nom_Client == Nom) == null)
            {
                db.Clients.Add(C);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifierClient(string Nom, string Contact, string Localisation)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.Nom_Client == Nom);
            if (C!= null)
            {
                C.Nom_Client = Nom;
                C.Contact_Client = Contact;
                C.Localisation_Client = Localisation;
                db.SaveChanges();
            }
        }

        public void SupprimerClient(string Nom, string Contact, string Localisation)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.Nom_Client == Nom);
            if (C != null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }
        }
    }
}
