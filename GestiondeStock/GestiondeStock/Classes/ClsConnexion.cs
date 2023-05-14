using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeStock.Classes
{
    class ClsConnexion
    {
        //verifier la connexion
        public bool VerifyConnexion(MyContext db, string Nom, string MotDePasse)
        {
            Utilisateur user = new Utilisateur();
            user.Nom_Ut = Nom;
            user.Mot_de_passe = MotDePasse;
            if(db.Utilisateurs.SingleOrDefault(s => s.Nom_Ut == Nom && s.Mot_de_passe == MotDePasse)!= null)//si le nom et le mdp existent
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
