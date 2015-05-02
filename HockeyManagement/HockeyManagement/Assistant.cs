using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HockeyManagement
{
    class Assistant : Personne, management
    {
        string position;
        string equipe;
        bool gardien = false;
        bool capitaine = false;

        public void formationAttaquante()
        {

        }

        public void formationDefensive()
        {

        }

        public Assistant(string prenom, string nom, string taille, string naissance, string position, string equipe)
        {
            this.position = position;
            this.equipe = equipe;
            this.prenom = prenom;
            this.nom = nom;
            this.taille = taille;
            this.naissance = naissance;
        }

    }
}
