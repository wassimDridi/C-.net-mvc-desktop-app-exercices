namespace ex2
{
    partial class Form1
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
            this.typeArticle = new System.Windows.Forms.ComboBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.panelArticle = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TVA = new System.Windows.Forms.NumericUpDown();
            this.PU = new System.Windows.Forms.NumericUpDown();
            this.panelOrinateur = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.marque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.frequence = new System.Windows.Forms.NumericUpDown();
            this.ram = new System.Windows.Forms.NumericUpDown();
            this.panelStylos = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.couleur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.referance = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.panelArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PU)).BeginInit();
            this.panelOrinateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.panelStylos.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeArticle
            // 
            this.typeArticle.FormattingEnabled = true;
            this.typeArticle.Items.AddRange(new object[] {
            "Ordinateur",
            "Stylos"});
            this.typeArticle.Location = new System.Drawing.Point(175, 29);
            this.typeArticle.Name = "typeArticle";
            this.typeArticle.Size = new System.Drawing.Size(264, 32);
            this.typeArticle.TabIndex = 0;
            this.typeArticle.SelectedIndexChanged += new System.EventHandler(this.typeArticle_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(27, 51);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 29);
            this.Code.TabIndex = 1;
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(174, 51);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(136, 29);
            this.designation.TabIndex = 2;
            // 
            // panelArticle
            // 
            this.panelArticle.Controls.Add(this.label4);
            this.panelArticle.Controls.Add(this.label);
            this.panelArticle.Controls.Add(this.label2);
            this.panelArticle.Controls.Add(this.label1);
            this.panelArticle.Controls.Add(this.TVA);
            this.panelArticle.Controls.Add(this.PU);
            this.panelArticle.Controls.Add(this.Code);
            this.panelArticle.Controls.Add(this.designation);
            this.panelArticle.Location = new System.Drawing.Point(44, 80);
            this.panelArticle.Name = "panelArticle";
            this.panelArticle.Size = new System.Drawing.Size(672, 100);
            this.panelArticle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "TVA";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(325, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 24);
            this.label.TabIndex = 5;
            this.label.Text = "PU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Code";
            // 
            // TVA
            // 
            this.TVA.Location = new System.Drawing.Point(491, 52);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(120, 29);
            this.TVA.TabIndex = 4;
            // 
            // PU
            // 
            this.PU.Location = new System.Drawing.Point(330, 52);
            this.PU.Name = "PU";
            this.PU.Size = new System.Drawing.Size(120, 29);
            this.PU.TabIndex = 3;
            // 
            // panelOrinateur
            // 
            this.panelOrinateur.Controls.Add(this.label7);
            this.panelOrinateur.Controls.Add(this.marque);
            this.panelOrinateur.Controls.Add(this.label5);
            this.panelOrinateur.Controls.Add(this.label6);
            this.panelOrinateur.Controls.Add(this.frequence);
            this.panelOrinateur.Controls.Add(this.ram);
            this.panelOrinateur.Location = new System.Drawing.Point(808, 199);
            this.panelOrinateur.Name = "panelOrinateur";
            this.panelOrinateur.Size = new System.Drawing.Size(523, 100);
            this.panelOrinateur.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marque";
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(373, 51);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(110, 29);
            this.marque.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "RAM(Go)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fréquence";
            // 
            // frequence
            // 
            this.frequence.Location = new System.Drawing.Point(32, 52);
            this.frequence.Name = "frequence";
            this.frequence.Size = new System.Drawing.Size(121, 29);
            this.frequence.TabIndex = 6;
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(193, 52);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(121, 29);
            this.ram.TabIndex = 7;
            // 
            // panelStylos
            // 
            this.panelStylos.Controls.Add(this.label9);
            this.panelStylos.Controls.Add(this.couleur);
            this.panelStylos.Controls.Add(this.label8);
            this.panelStylos.Controls.Add(this.referance);
            this.panelStylos.Location = new System.Drawing.Point(779, 80);
            this.panelStylos.Name = "panelStylos";
            this.panelStylos.Size = new System.Drawing.Size(311, 100);
            this.panelStylos.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Couleur";
            // 
            // couleur
            // 
            this.couleur.Location = new System.Drawing.Point(15, 56);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(100, 29);
            this.couleur.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Referance";
            // 
            // referance
            // 
            this.referance.Location = new System.Drawing.Point(174, 53);
            this.referance.Name = "referance";
            this.referance.Size = new System.Drawing.Size(119, 29);
            this.referance.TabIndex = 6;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 24;
            this.list.Location = new System.Drawing.Point(35, 218);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(754, 292);
            this.list.TabIndex = 6;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(840, 339);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(164, 68);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelStylos);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.list);
            this.Controls.Add(this.panelOrinateur);
            this.Controls.Add(this.panelArticle);
            this.Controls.Add(this.typeArticle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelArticle.ResumeLayout(false);
            this.panelArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PU)).EndInit();
            this.panelOrinateur.ResumeLayout(false);
            this.panelOrinateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.panelStylos.ResumeLayout(false);
            this.panelStylos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox typeArticle;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Panel panelArticle;
        private System.Windows.Forms.NumericUpDown TVA;
        private System.Windows.Forms.NumericUpDown PU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelOrinateur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox marque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown frequence;
        private System.Windows.Forms.NumericUpDown ram;
        private System.Windows.Forms.Panel panelStylos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox couleur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox referance;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button ajouter;
    }
}

