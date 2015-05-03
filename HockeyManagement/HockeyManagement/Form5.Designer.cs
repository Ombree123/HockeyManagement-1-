namespace HockeyManagement
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.nomB = new System.Windows.Forms.TextBox();
            this.formationsItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formationActive = new System.Windows.Forms.ListBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.retirer = new System.Windows.Forms.Button();
            this.confirmer = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.RadioA = new System.Windows.Forms.RadioButton();
            this.RadioD = new System.Windows.Forms.RadioButton();
            this.RadioG = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // nomB
            // 
            this.nomB.Location = new System.Drawing.Point(49, 217);
            this.nomB.Name = "nomB";
            this.nomB.Size = new System.Drawing.Size(100, 20);
            this.nomB.TabIndex = 5;
            // 
            // formationsItems
            // 
            this.formationsItems.FormattingEnabled = true;
            this.formationsItems.Location = new System.Drawing.Point(180, 25);
            this.formationsItems.Name = "formationsItems";
            this.formationsItems.Size = new System.Drawing.Size(182, 121);
            this.formationsItems.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Formation Active";
            // 
            // formationActive
            // 
            this.formationActive.FormattingEnabled = true;
            this.formationActive.Location = new System.Drawing.Point(180, 189);
            this.formationActive.Name = "formationActive";
            this.formationActive.Size = new System.Drawing.Size(182, 121);
            this.formationActive.TabIndex = 10;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(232, 153);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(27, 23);
            this.ajouter.TabIndex = 11;
            this.ajouter.Text = "+";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // retirer
            // 
            this.retirer.Location = new System.Drawing.Point(279, 153);
            this.retirer.Name = "retirer";
            this.retirer.Size = new System.Drawing.Size(27, 23);
            this.retirer.TabIndex = 12;
            this.retirer.Text = "-";
            this.retirer.UseVisualStyleBackColor = true;
            this.retirer.Click += new System.EventHandler(this.retirer_Click);
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(89, 327);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(75, 23);
            this.confirmer.TabIndex = 13;
            this.confirmer.Text = "Confirmer";
            this.confirmer.UseVisualStyleBackColor = true;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(203, 327);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // RadioA
            // 
            this.RadioA.AutoSize = true;
            this.RadioA.Location = new System.Drawing.Point(28, 41);
            this.RadioA.Name = "RadioA";
            this.RadioA.Size = new System.Drawing.Size(136, 17);
            this.RadioA.TabIndex = 19;
            this.RadioA.TabStop = true;
            this.RadioA.Text = "Formations Attaquantes";
            this.RadioA.UseVisualStyleBackColor = true;
            this.RadioA.CheckedChanged += new System.EventHandler(this.RadioA_CheckedChanged);
            // 
            // RadioD
            // 
            this.RadioD.AutoSize = true;
            this.RadioD.Location = new System.Drawing.Point(29, 77);
            this.RadioD.Name = "RadioD";
            this.RadioD.Size = new System.Drawing.Size(132, 17);
            this.RadioD.TabIndex = 20;
            this.RadioD.TabStop = true;
            this.RadioD.Text = "Formations Defensives";
            this.RadioD.UseVisualStyleBackColor = true;
            this.RadioD.CheckedChanged += new System.EventHandler(this.RadioD_CheckedChanged);
            // 
            // RadioG
            // 
            this.RadioG.AutoSize = true;
            this.RadioG.Location = new System.Drawing.Point(29, 114);
            this.RadioG.Name = "RadioG";
            this.RadioG.Size = new System.Drawing.Size(67, 17);
            this.RadioG.TabIndex = 21;
            this.RadioG.TabStop = true;
            this.RadioG.Text = "Gardiens";
            this.RadioG.UseVisualStyleBackColor = true;
            this.RadioG.CheckedChanged += new System.EventHandler(this.RadioG_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 369);
            this.Controls.Add(this.RadioG);
            this.Controls.Add(this.RadioD);
            this.Controls.Add(this.RadioA);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirmer);
            this.Controls.Add(this.retirer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.formationActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formationsItems);
            this.Controls.Add(this.nomB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Formations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomB;
        private System.Windows.Forms.ListBox formationsItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox formationActive;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button retirer;
        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.RadioButton RadioA;
        private System.Windows.Forms.RadioButton RadioD;
        private System.Windows.Forms.RadioButton RadioG;
    }
}