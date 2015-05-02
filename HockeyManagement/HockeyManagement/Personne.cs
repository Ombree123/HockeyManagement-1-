using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace HockeyManagement
{
    class Personne
    {
        protected string prenom;
        protected string nom;
        protected string taille;
        protected string naissance;

        public Personne()
        {
        }

        public Personne(string prenom, string nom, string taille, string naissance)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.taille = taille;
            this.naissance = naissance;
        }
    }
}
