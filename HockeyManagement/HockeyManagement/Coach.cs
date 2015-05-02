using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HockeyManagement
{
    class Coach : Personne, management
    {
        bool gardien = false;
        bool capitaine = false;

        public Coach()
        {
        }

        public Coach(string prenom, string nom, string taille, string naissance)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.taille = taille;
            this.naissance = naissance;
        }

        public void formationAttaquante()
        {

        }

        public void formationDefensive()
        {

        }

        public void ajouterJoueur()
        {

        }

        public void retirerJoueur()
        {

        }
    }
}
