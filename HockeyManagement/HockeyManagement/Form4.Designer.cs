namespace HockeyManagement
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.confirmer = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.nomB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.players = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formationActive = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(91, 233);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(75, 23);
            this.confirmer.TabIndex = 0;
            this.confirmer.Text = "Confirmer";
            this.confirmer.UseVisualStyleBackColor = true;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(206, 233);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nomB
            // 
            this.nomB.Location = new System.Drawing.Point(49, 18);
            this.nomB.Name = "nomB";
            this.nomB.Size = new System.Drawing.Size(100, 20);
            this.nomB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // players
            // 
            this.players.FormattingEnabled = true;
            this.players.Location = new System.Drawing.Point(17, 72);
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(149, 134);
            this.players.TabIndex = 4;
            this.players.SelectedIndexChanged += new System.EventHandler(this.players_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Joueurs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // formationActive
            // 
            this.formationActive.FormattingEnabled = true;
            this.formationActive.Location = new System.Drawing.Point(206, 72);
            this.formationActive.Name = "formationActive";
            this.formationActive.Size = new System.Drawing.Size(149, 134);
            this.formationActive.TabIndex = 6;
            this.formationActive.SelectedIndexChanged += new System.EventHandler(this.formationActive_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Formation Active";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formationActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.players);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomB);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirmer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox nomB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox players;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox formationActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}