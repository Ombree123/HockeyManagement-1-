using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HockeyManagement
{
    public partial class Accueil : Form
    {
        public static string identite;

        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            var myForm = new Form1();
            myForm.Show();

            identite = "coach";

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();

            identite = "assistant";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();

            identite = "joueur";

        }
    }
}
