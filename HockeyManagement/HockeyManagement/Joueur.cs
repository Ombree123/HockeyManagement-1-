using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace HockeyManagement
{
    class Joueur : Personne
    {
        protected string position;
        protected string equipe;
        protected bool capitaine = false; 
        protected bool gardien = false;
        protected int numero;

        public void getDescription()
        {
            MessageBox.Show("PlaceHolder");
        }

        public Joueur()
        {
        }

        public Joueur(string prenom, string nom, string taille, string naissance, string position, string equipe,  int numero, bool capitaine, bool gardien)
        {
            this.position = position;
            this.equipe = equipe;
            this.capitaine = capitaine;
            this.gardien = gardien;
            this.prenom = prenom.Trim();
            this.nom = nom.Trim();
            this.taille = taille;
            this.naissance = naissance;
            this.numero = numero;

            TextWriter tw = File.AppendText(@Directory.GetCurrentDirectory() + "\\Equipe.txt");

            tw.WriteLine(this.prenom);
            tw.WriteLine(this.nom);
            tw.WriteLine(this.taille);
            tw.WriteLine(this.naissance);

            if (this.gardien == true)
                tw.WriteLine("Gardien");
            
            if(this.gardien == false)
            tw.WriteLine(this.position);
            tw.WriteLine(this.equipe);
            tw.WriteLine(this.gardien);
            tw.WriteLine(this.capitaine);
            tw.WriteLine(this.numero);
            tw.Close();
        }
    }
}
