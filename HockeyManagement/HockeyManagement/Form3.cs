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
    public partial class Form3 : Form
    {
        bool modify = false;
        string nomM, prenomM;

        public Form3()
        {
            InitializeComponent();           
        }

        public Form3(string name)
        {
            InitializeComponent();
            modify = true;
            var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");
            name = name.TrimStart();
            var names = name.Split(' ');
            string firstName = names[0], lastName = names[1];

            int index1 = Array.IndexOf(lines, firstName);
            prenom.Text = lines[index1];
            prenomM = lines[index1];
            nomM = lines[index1 + 1];
            nom.Text = lines[index1+1];
            taille.Text = lines[index1+2];
            date.Text = lines[index1 + 3];

            switch (lines[index1+4])
            {
                case "ailierGaucheA":
                    ailierG.Checked = true;
                    fAtt.Checked = true;
                    break;
                case "ailierDroitA":
                    ailierD.Checked = true;
                    fAtt.Checked = true;
                    break;
                case "ailierGaucheD":
                    ailierG.Checked = true;
                    fDef.Checked = true;
                    break;
                case "ailierDroitD":
                    ailierD.Checked = true;
                    fDef.Checked = true;
                    break;
                case "millieu":
                    millieu.Checked = true;
                    fAtt.Checked = true;
                    break;
            }

            equipe.Text = lines[index1 + 5];

            if (lines[index1 + 6] == "True")
                fGard.Checked = true;

            if (lines[index1 + 7] == "False")
                capOn.Checked = true;
            else
                capOff.Checked = true;

            numericUpDown1.Text = lines[index1 + 8];
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            millieu.Hide();
            ailierD.Show();
            ailierG.Show();
            if (millieu.Checked == true)
                ailierG.Checked = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            millieu.Hide();
            ailierD.Hide();
            ailierG.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            millieu.Show();
            ailierD.Show();
            ailierG.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modify)
                {
                    if (!fGard.Checked && !ailierD.Checked && !millieu.Checked && !ailierG.Checked)
                    {
                        throw new Exception();
                    }

                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");

                    int index1 = Array.IndexOf(lines, prenomM);

                    lines[index1] = null;
                    lines[index1 + 1] = null;
                    lines[index1 + 2] = null;
                    lines[index1 + 3] = null;
                    lines[index1 + 4] = null;
                    lines[index1 + 5] = null;
                    lines[index1 + 6] = null;
                    lines[index1 + 7] = null;
                    lines[index1 + 8] = null;

                    lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    File.WriteAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt", lines);
                    modify = false;
                }
            }
            catch(Exception F)
            {
                MessageBox.Show("Aucune position de sélectionné");
                MessageBox.Show(Convert.ToString(F));
            }
            

            try
            {
                if (!fGard.Checked && !ailierD.Checked && !millieu.Checked && !ailierG.Checked)
                {
                    MessageBox.Show("Aucune position de sélectionné");
                    throw new Exception();
                }

                string prenomC = prenom.Text, nomC = nom.Text, tailleC = taille.Text, positionC="", equipeC=equipe.Text;
                string naissanceC = date.Value.ToString("yyyy/MM/dd");
                int numeroC = Convert.ToInt32(numericUpDown1.Value);
                bool capitaineC = false, gardienC = false;

                if(capOn.Checked)
                    capitaineC = true;
                if(fGard.Checked)
                    gardienC=true;
                if(ailierD.Checked && fAtt.Checked) //J'avais oublié d'enregistrer une ligne pour Offense et Défense, j'y est remédié en l'ajoutant à la position
                    positionC="ailierDroitA";
                if (ailierD.Checked && fDef.Checked)
                    positionC = "ailierDroitD";
                if(ailierG.Checked && fAtt.Checked)
                    positionC="ailierGaucheA";
                if (ailierG.Checked && fDef.Checked)
                    positionC = "ailierGaucheD";
                if(millieu.Checked)
                    positionC="millieu";

                Joueur joueur = new Joueur(prenomC, nomC, tailleC, naissanceC, positionC,equipeC, numeroC, capitaineC, gardienC);
            }
            catch(Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
