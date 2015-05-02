namespace HockeyManagement
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.capOn = new System.Windows.Forms.RadioButton();
            this.capOff = new System.Windows.Forms.RadioButton();
            this.equipe = new System.Windows.Forms.TextBox();
            this.ailierG = new System.Windows.Forms.RadioButton();
            this.ailierD = new System.Windows.Forms.RadioButton();
            this.millieu = new System.Windows.Forms.RadioButton();
            this.fAtt = new System.Windows.Forms.RadioButton();
            this.fDef = new System.Windows.Forms.RadioButton();
            this.fGard = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // prenom
            // 
            this.prenom.AllowDrop = true;
            this.prenom.Location = new System.Drawing.Point(69, 20);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(69, 56);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taille";
            // 
            // taille
            // 
            this.taille.Location = new System.Drawing.Point(69, 86);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(100, 20);
            this.taille.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Naissance";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(301, 21);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(129, 20);
            this.date.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Equipe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Capitaine";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(69, 271);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 12;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // capOn
            // 
            this.capOn.AutoSize = true;
            this.capOn.Location = new System.Drawing.Point(15, 12);
            this.capOn.Name = "capOn";
            this.capOn.Size = new System.Drawing.Size(41, 17);
            this.capOn.TabIndex = 15;
            this.capOn.Text = "Oui";
            this.capOn.UseVisualStyleBackColor = true;
            // 
            // capOff
            // 
            this.capOff.AutoSize = true;
            this.capOff.Location = new System.Drawing.Point(62, 12);
            this.capOff.Name = "capOff";
            this.capOff.Size = new System.Drawing.Size(45, 17);
            this.capOff.TabIndex = 16;
            this.capOff.Text = "Non";
            this.capOff.UseVisualStyleBackColor = true;
            // 
            // equipe
            // 
            this.equipe.Enabled = false;
            this.equipe.Location = new System.Drawing.Point(269, 89);
            this.equipe.Name = "equipe";
            this.equipe.Size = new System.Drawing.Size(112, 20);
            this.equipe.TabIndex = 18;
            this.equipe.Text = "Les Tamouls d\'Arabie";
            // 
            // ailierG
            // 
            this.ailierG.AutoSize = true;
            this.ailierG.Location = new System.Drawing.Point(6, 19);
            this.ailierG.Name = "ailierG";
            this.ailierG.Size = new System.Drawing.Size(88, 17);
            this.ailierG.TabIndex = 19;
            this.ailierG.Text = "Ailier Gauche";
            this.ailierG.UseVisualStyleBackColor = true;
            // 
            // ailierD
            // 
            this.ailierD.AutoSize = true;
            this.ailierD.Location = new System.Drawing.Point(6, 65);
            this.ailierD.Name = "ailierD";
            this.ailierD.Size = new System.Drawing.Size(72, 17);
            this.ailierD.TabIndex = 20;
            this.ailierD.Text = "Ailier Droit";
            this.ailierD.UseVisualStyleBackColor = true;
            // 
            // millieu
            // 
            this.millieu.AutoSize = true;
            this.millieu.Location = new System.Drawing.Point(6, 42);
            this.millieu.Name = "millieu";
            this.millieu.Size = new System.Drawing.Size(54, 17);
            this.millieu.TabIndex = 20;
            this.millieu.Text = "Millieu";
            this.millieu.UseVisualStyleBackColor = true;
            this.millieu.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // fAtt
            // 
            this.fAtt.AutoSize = true;
            this.fAtt.Location = new System.Drawing.Point(6, 19);
            this.fAtt.Name = "fAtt";
            this.fAtt.Size = new System.Drawing.Size(62, 17);
            this.fAtt.TabIndex = 22;
            this.fAtt.Text = "Attaque";
            this.fAtt.UseVisualStyleBackColor = true;
            this.fAtt.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // fDef
            // 
            this.fDef.AutoSize = true;
            this.fDef.Location = new System.Drawing.Point(6, 42);
            this.fDef.Name = "fDef";
            this.fDef.Size = new System.Drawing.Size(65, 17);
            this.fDef.TabIndex = 23;
            this.fDef.Text = "Defense";
            this.fDef.UseVisualStyleBackColor = true;
            this.fDef.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // fGard
            // 
            this.fGard.AutoSize = true;
            this.fGard.Location = new System.Drawing.Point(6, 65);
            this.fGard.Name = "fGard";
            this.fGard.Size = new System.Drawing.Size(62, 17);
            this.fGard.TabIndex = 24;
            this.fGard.Text = "Gardien";
            this.fGard.UseVisualStyleBackColor = true;
            this.fGard.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(269, 271);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ailierG);
            this.groupBox1.Controls.Add(this.millieu);
            this.groupBox1.Controls.Add(this.ailierD);
            this.groupBox1.Location = new System.Drawing.Point(69, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 95);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fAtt);
            this.groupBox2.Controls.Add(this.fDef);
            this.groupBox2.Controls.Add(this.fGard);
            this.groupBox2.Location = new System.Drawing.Point(245, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 95);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.capOn);
            this.groupBox3.Controls.Add(this.capOff);
            this.groupBox3.Location = new System.Drawing.Point(269, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 35);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Numero";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 119);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 306);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.equipe);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Ajouter Joueur";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.RadioButton capOn;
        private System.Windows.Forms.RadioButton capOff;
        private System.Windows.Forms.TextBox equipe;
        private System.Windows.Forms.RadioButton ailierG;
        private System.Windows.Forms.RadioButton ailierD;
        private System.Windows.Forms.RadioButton millieu;
        private System.Windows.Forms.RadioButton fAtt;
        private System.Windows.Forms.RadioButton fDef;
        private System.Windows.Forms.RadioButton fGard;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}