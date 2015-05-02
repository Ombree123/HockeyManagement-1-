using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HockeyManagement
{
    class FormationDefensive
    {
        Joueur[] joueurs = new Joueur[2];
        string nom;
        List<string> _source = new List<string>();

        public void ChangerDuo()
        {
        }

        public FormationDefensive()
        {
        }

        public FormationDefensive(string nom, List<string> _source)
        {
            this.nom = nom.Trim();
            this._source = _source;

            TextWriter tw = File.AppendText(@Directory.GetCurrentDirectory() + "\\formationD.txt");

            tw.WriteLine(this.nom);
            
            foreach(string name in this._source)
            {
                tw.WriteLine(name);
            }
            tw.Close();
        }

        public FormationDefensive(string nom, Joueur[] joueurs)
        {
            this.nom = nom;
            this.joueurs = joueurs;
        }
    }
}
