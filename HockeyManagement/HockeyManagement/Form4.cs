using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HockeyManagement
{
    public partial class Form4 : Form
    {
        List<string> _source = new List<string>();
        int index = 0;
        bool nouveau = true;
        int current = 0;
        string formation = "";

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int current)
        {
            InitializeComponent();
            this.current = current;
        }

        public Form4(string formation, int current)
        {
            InitializeComponent();
            this.current = current;
            this.formation = formation;
            int counter = -1;
            string[] lines = new string[] { };

            if (current == 2)
            {
                StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\formationA.txt");
                lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt");
                file.Close();
            }

            if (current == 3)
            {
                StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\formationD.txt");
                lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt");
                file.Close();
            }
            

            foreach (string line in lines)
            {
                counter++;

                if (line == formation)
                {
                    for (int i = 1; i <= 3; ++i)
                    {
                        _source.Add(lines[counter + i]);
                    }
                }
            }            
            
            formationActive.DataSource = null;
            formationActive.DataSource = _source;
            nouveau = false;
            index = 3;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void players_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (File.Exists(@Directory.GetCurrentDirectory() + "\\Equipe.txt"))
            {
                List<string> _items = new List<string>();
                string nom = "";

                StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\Equipe.txt");

                var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");
                int counter = 0;

                foreach (string line in lines)
                {
                    if (counter == 2)
                    {
                        _items.Add(nom);
                        nom = null;
                    }
                    if (counter == 0 || counter == 1)
                    {
                        nom = nom + " " + line;
                        counter++;
                    }
                    else
                    {
                        counter++;
                    }
                    if (counter == 9)
                    {
                        counter = 0;
                    }
                }

                players.DataSource = _items;
                file.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formationActive.GetItemText(formationActive.SelectedItem) != "" || nouveau)
            {
            if (index != 3)
            {
                if (!(_source.Contains(players.GetItemText(players.SelectedItem).TrimStart())))
                {
                    _source.Add(players.GetItemText(players.SelectedItem).TrimStart());
                    formationActive.DataSource = null;
                    formationActive.DataSource = _source;
                    index++;
                    nouveau = false;
                }
                else
                    MessageBox.Show("Joueur déja présent");
            }
            else
                MessageBox.Show("3 joueurs maximum");
            }
            else
                MessageBox.Show("Vous devez avoir un joueur de selectionné");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formationActive.GetItemText(formationActive.SelectedItem) != "" || nouveau)
            {
                if (index != 0)
                {
                    _source.Remove(formationActive.GetItemText(formationActive.SelectedItem));
                    formationActive.DataSource = null;
                    formationActive.DataSource = _source;
                    index--;
                    nouveau = false;
                }
                else
                    MessageBox.Show("Aucun joueur à supprimer");
            }
            else
                MessageBox.Show("Vous devez avoir un joueur de selectionné");
            if (index == 0)
                nouveau = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            bool ailierDroit = false, ailierGauche = false, millieu = false;

            if(current == 2)
            {
                foreach(string nom in _source)
                {
                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");  //Fix Double Occurence Bug
                    var names = nom.Split(' ');
                    string firstName = names[0], lastName = names[1];

                    int index1 = Array.IndexOf(lines, firstName)+4;

                    if(lines[index1] == "ailierDroitA")                     //Ne peut pas s'appeller millieu
                    {
                            ailierDroit = true;
                    }

                    if(lines[index1] == "ailierGaucheA")
                    {
                            ailierGauche = true;
                    }

                    if(lines[index1] == "millieu")
                    {
                            millieu = true;
                    }               
                }

                if (ailierDroit && ailierGauche && millieu)
                {
                    FormationAttaquante formationA = new FormationAttaquante(nomB.Text, _source);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Combinaison de joueur invalide");
                }
                
            }

            if(current == 3)
            {
                foreach(string nom in _source)
                {
                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");  //Fix Double Occurence Bug
                    var names = nom.Split(' ');
                    string firstName = names[0], lastName = names[1];

                    int index1 = Array.IndexOf(lines, firstName) + 4;

                    if (lines[index1] == "ailierDroitD")
                    {
                        ailierDroit = true;
                    }

                    if (lines[index1] == "ailierGaucheD")
                    {
                        ailierGauche = true;
                    }
                }

                if (ailierDroit && ailierGauche)
                {
                    FormationDefensive formationD = new FormationDefensive(nomB.Text, _source);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Combinaison de joueur invalide");
                }
                
            }

        }

        private void formationActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
