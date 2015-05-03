using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HockeyManagement
{
    public partial class Form1 : Form
    {
        int current = 0;
        List<string> _items = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
        }

        void refresh()
        {
            #region refreshEquipe
            if (current == 1)
            {
                if (File.Exists(@Directory.GetCurrentDirectory() + "\\Equipe.txt"))
                {
                    _items = new List<string>();
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

                    listBox1.DataSource = _items;
                    file.Close();
                }
                else
                {
                    using (StreamWriter w = File.AppendText(@Directory.GetCurrentDirectory() + "\\Equipe.txt"))
                    {

                    }
                }

            }
            #endregion

            #region refreshAttaques
            if (current == 2)
            {
                if (File.Exists(@Directory.GetCurrentDirectory() + "\\formationA.txt"))
                {
                    _items = new List<string>();

                    StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\formationA.txt");

                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt");
                    int counter = 0;

                    foreach (string line in lines)
                    {
                        if (counter == 0)
                        {
                            _items.Add(line);
                        }

                        counter++;

                        if (counter == 4)
                        {
                            counter = 0;
                        }
                    }

                    listBox1.DataSource = _items;
                    file.Close();
                }
                else
                {
                    using (StreamWriter w = File.AppendText(@Directory.GetCurrentDirectory() + "\\formationA.txt"))
                    {

                    }
                }
            }
            #endregion

            #region refreshDefenses
            if (current == 3)
            {
                if (File.Exists(@Directory.GetCurrentDirectory() + "\\formationD.txt"))
                {
                    _items = new List<string>();

                    StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\formationD.txt");

                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt");
                    int counter = 0;

                    foreach (string line in lines)
                    {
                        if (counter == 0)
                        {
                            _items.Add(line);
                        }

                        counter++;

                        if (counter == 3)
                        {
                            counter = 0;
                        }
                    }

                    listBox1.DataSource = _items;
                    file.Close();
                }
                else
                {
                    using (StreamWriter w = File.AppendText(@Directory.GetCurrentDirectory() + "\\formationD.txt"))
                    {

                    }
                }
            }
            #endregion

            #region refreshFormations
            if (current == 4)
            {
                if (File.Exists(@Directory.GetCurrentDirectory() + "\\formations.txt"))
                {
                    _items = new List<string>();

                    StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\formations.txt");

                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formations.txt");
                    int counter = 0;

                    foreach (string line in lines)
                    {
                        if (counter == 0)
                        {
                            _items.Add(line);
                        }

                        counter++;

                        if (counter == 4)
                        {
                            counter = 0;
                        }
                    }

                    listBox1.DataSource = _items;
                    file.Close();
                }
                else
                {
                    using (StreamWriter w = File.AppendText(@Directory.GetCurrentDirectory() + "\\formations.txt"))
                    {

                    }
                }
            }
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            current = 1;
            string directory = Directory.GetCurrentDirectory();

            if (Accueil.identite != "coach")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current = 2;
            
            if (Accueil.identite != "coach" && Accueil.identite != "assistant")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            refresh();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current = 3;
            
            if (Accueil.identite != "coach" && Accueil.identite != "assistant")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            current = 4;
            
            if (Accueil.identite != "coach" && Accueil.identite != "assistant")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            if (File.Exists(@Directory.GetCurrentDirectory() + "\\formations.txt"))
            {
                _items = new List<string>();

                StreamReader file = new StreamReader(@Directory.GetCurrentDirectory() + "\\formations.txt");

                var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formations.txt");
                int counter = 0;

                foreach (string line in lines)
                {
                    if (counter == 0)
                    {
                        _items.Add(line);
                    }

                    counter++;

                    if (counter == 4)
                    {
                        counter = 0;
                    }
                }

                listBox1.DataSource = _items;
                file.Close();
            }
            else
            {
                using (StreamWriter w = File.AppendText(@Directory.GetCurrentDirectory() + "\\formations.txt"))
                {

                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Closed_Form(object sender, FormClosedEventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current == 1)
            {
                var form3 = new Form3();
                form3.FormClosed += new FormClosedEventHandler(Closed_Form);
                form3.Show();
            }

            if (current == 2)
            {
                var form4 = new Form4(current);
                form4.FormClosed += new FormClosedEventHandler(Closed_Form);
                form4.Show();
            }

            if (current == 3)
            {
                var form4 = new Form4(current);
                form4.FormClosed += new FormClosedEventHandler(Closed_Form);
                form4.Show();
            }

            if (current == 4)
            {
                var form5 = new Form5();
                form5.FormClosed += new FormClosedEventHandler(Closed_Form);
                form5.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current == 1)
            {
                try
                {
                    string joueur = listBox1.GetItemText(listBox1.SelectedItem).TrimStart();
                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\Equipe.txt");
                    var names = joueur.Split(' ');
                    string firstName = names[0], lastName = names[1];

                    int index1 = Array.IndexOf(lines, firstName);

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
                }
                catch (Exception c)
                {
                    MessageBox.Show("Vous devez selectionner un joueur");
                    MessageBox.Show(Convert.ToString(c));
                }

                refresh();
            }

            if ( current == 2 )
            {
                try
                {
                    string formation = listBox1.GetItemText(listBox1.SelectedItem).TrimStart();
                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt");
                    int index1 = Array.IndexOf(lines, formation);

                    lines[index1] = null;
                    lines[index1 + 1] = null;
                    lines[index1 + 2] = null;
                    lines[index1 + 3] = null;

                    lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    File.WriteAllLines(@Directory.GetCurrentDirectory() + "\\formationA.txt", lines);
                }
                catch (Exception c)
                {
                    MessageBox.Show("Vous devez selectionner une formation attaquante");
                    MessageBox.Show(Convert.ToString(c));
                }
                refresh();
            }

            if (current == 3)
            {
                try
                {
                    string formation = listBox1.GetItemText(listBox1.SelectedItem).TrimStart();
                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt");
                    int index1 = Array.IndexOf(lines, formation);

                    lines[index1] = null;
                    lines[index1 + 1] = null;
                    lines[index1 + 2] = null;
                    lines[index1 + 3] = null;

                    lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    File.WriteAllLines(@Directory.GetCurrentDirectory() + "\\formationD.txt", lines);
                }
                catch (Exception c)
                {
                    MessageBox.Show("Vous devez selectionner une formation defensive");
                    MessageBox.Show(Convert.ToString(c));
                }
                refresh();
            }

            if(current == 4)
            {
                try
                {
                    string formation = listBox1.GetItemText(listBox1.SelectedItem).TrimStart();
                    var lines = File.ReadAllLines(@Directory.GetCurrentDirectory() + "\\formations.txt");
                    int index1 = Array.IndexOf(lines, formation);

                    lines[index1] = null;
                    lines[index1 + 1] = null;
                    lines[index1 + 2] = null;
                    lines[index1 + 3] = null;

                    lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    File.WriteAllLines(@Directory.GetCurrentDirectory() + "\\formations.txt", lines);
                }
                catch (Exception c)
                {
                    MessageBox.Show("Vous devez selectionner une formation");
                    MessageBox.Show(Convert.ToString(c));
                }
                refresh();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (current == 1)
            {
                var form3 = new Form3(listBox1.GetItemText(listBox1.SelectedItem));
                form3.FormClosed += new FormClosedEventHandler(Closed_Form);
                form3.Show();
            }

            if (current == 2)
            {
                var form4 = new Form4(listBox1.GetItemText(listBox1.SelectedItem), current);
                form4.FormClosed += new FormClosedEventHandler(Closed_Form);
                form4.Show();
            }

            if (current == 3)
            {
                var form4 = new Form4(listBox1.GetItemText(listBox1.SelectedItem), current);
                form4.FormClosed += new FormClosedEventHandler(Closed_Form);
                form4.Show();
            }

            if (current == 4)
            {
                var form5 = new Form5(listBox1.GetItemText(listBox1.SelectedItem));
                form5.FormClosed += new FormClosedEventHandler(Closed_Form);
                form5.Show();
            }
        }
    }
}
