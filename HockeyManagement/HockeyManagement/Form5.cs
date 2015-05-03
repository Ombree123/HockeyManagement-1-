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
    public partial class Form5 : Form
    {
        string nom, formA="", formD="", formG="";
        bool formationA = false, formationD = false, formationG = false;
        List<string> _source = new List<string>(), _sources = new List<string>();

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(string formation)
        {
            InitializeComponent();
            string[] lines = new string[] { };
            nomB.Text = formation;
            int counter = 0;

            lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formations.txt");

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
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            if (formationA && formationD && formationG)
            {

                var forG = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");
                var forA = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt");
                var forD = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt");

                nom = nomB.Text;

                foreach( string lines in _sources)
                {
                    if (forG.Contains(lines))
                        this.formG = lines;

                    if (forA.Contains(lines))
                        this.formA = lines;

                    if (forD.Contains(lines))
                        this.formD = lines;
                }
                
            }
                Formation forma = new Formation(nom, formA, formD, formG);
                this.Close();
        }

        private void RadioA_CheckedChanged(object sender, EventArgs e)
        {
            _source = new List<string>();

            var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt");
            int counter = 0;

            foreach (string line in lines)
            {
                if (counter == 0)
                {
                    _source.Add(line);
                }

                counter++;

                if (counter == 4)
                {
                    counter = 0;
                }
            }

            formationsItems.DataSource = null;
            formationsItems.DataSource = _source;
        }

        private void RadioD_CheckedChanged(object sender, EventArgs e)
        {
            _source = new List<string>();

            if (File.Exists(@Directory.GetCurrentDirectory() + "\\formationD.txt"))
            {
                _source = new List<string>();

                var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt");
                int counter = 0;

                foreach (string line in lines)
                {
                    if (counter == 0)
                    {
                        _source.Add(line);
                    }

                    counter++;

                    if (counter == 3)
                    {
                        counter = 0;
                    }
                }

                formationsItems.DataSource = null;
                formationsItems.DataSource = _source;
            }
            else
            {
                using (StreamWriter w = File.AppendText(@Directory.GetCurrentDirectory() + "\\formationD.txt"))
                {

                }
            }
        }

        private void RadioG_CheckedChanged(object sender, EventArgs e)
        {
            _source = new List<string>();

            var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");  //Fix Double Occurence Bug
            List<int> _gardiens = new List<int>();
            int index = 0;

            foreach (string line in lines)
            {    
                if(line == "Gardien")
                {
                    _gardiens.Add(index);
                }
                index++;
            }

            foreach (int ind in _gardiens)
            {
                string firstName = lines[ind-4], lastName = lines[ind-3], name = firstName + " "+lastName;

                _source.Add(name);
            }

            formationsItems.DataSource = null;
            formationsItems.DataSource = _source;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (RadioA.Checked || RadioD.Checked || RadioG.Checked)
            {
                if (RadioA.Checked)
                {
                    if(!formationA)
                    {
                      _sources.Add(formationsItems.GetItemText(formationsItems.SelectedItem));
                      formationA = true;
                    } 
                    else
                        MessageBox.Show("Vous avez déjà une formation attaquante dans votre formation active");
                }

                if (RadioD.Checked)
                {
                    if(!formationD)
                    {
                      _sources.Add(formationsItems.GetItemText(formationsItems.SelectedItem));
                      formationD = true;
                    }
                    else
                        MessageBox.Show("Vous avez déjà une formation defensive dans votre formation active");
                }

                if (RadioG.Checked)
                {
                    if(!formationG)
                    {
                        _sources.Add(formationsItems.GetItemText(formationsItems.SelectedItem));
                        formationG = true;
                    }
                    else
                        MessageBox.Show("Vous avez déjà un gardien dans votre formation active");
                }
                
            }
            else
                MessageBox.Show("Vous devez avoir une selection active");

            formationActive.DataSource = null;
            formationActive.DataSource = _sources;
        }

        private void retirer_Click(object sender, EventArgs e)
        {
            string aRetirer = formationActive.GetItemText(formationActive.SelectedItem);

            var formationG = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");
            var formationA = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt");
            var formationD = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt");

            if (formationG.Contains(aRetirer))
                this.formationG = false;

            if (formationA.Contains(aRetirer))
                this.formationA = false;

            if (formationD.Contains(aRetirer))
                this.formationD = false;

            _sources.Remove(aRetirer);

            formationActive.DataSource = null;
            formationActive.DataSource = _sources;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
