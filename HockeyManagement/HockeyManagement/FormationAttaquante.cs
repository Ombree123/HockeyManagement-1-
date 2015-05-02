using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HockeyManagement
{
    class FormationAttaquante
    {
        Joueur[] joueurs = new Joueur[3];
        List<string> _source = new List<string>();
        string nom;

        public void ChangerTrio()
        {
        }

        public FormationAttaquante()
        {

        }

        public FormationAttaquante(string nom, List<string> _source)
        {
            this.nom = nom.Trim();
            this._source = _source;

            TextWriter tw = File.AppendText(@Directory.GetCurrentDirectory() + "\\formationA.txt");

            tw.WriteLine(this.nom);
            
            foreach(string name in this._source)
            {
                tw.WriteLine(name);
            }
            tw.Close();

        }

        public FormationAttaquante(string nom, Joueur[] joueurs)
        {
            this.nom = nom;
            this.joueurs = joueurs;
        }


    }
}
