namespace Tp4Ex3
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
            this.TypeAnimal = new System.Windows.Forms.ComboBox();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.numericPrix = new System.Windows.Forms.NumericUpDown();
            this.panelMammal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNbMois = new System.Windows.Forms.NumericUpDown();
            this.panelInsecte = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericAiles = new System.Windows.Forms.NumericUpDown();
            this.panelChien = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textRace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.GeneralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrix)).BeginInit();
            this.panelMammal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbMois)).BeginInit();
            this.panelInsecte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAiles)).BeginInit();
            this.panelChien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeAnimal
            // 
            this.TypeAnimal.FormattingEnabled = true;
            this.TypeAnimal.Items.AddRange(new object[] {
            "Mammal",
            "Chien",
            "Insecte"});
            this.TypeAnimal.Location = new System.Drawing.Point(330, 71);
            this.TypeAnimal.Name = "TypeAnimal";
            this.TypeAnimal.Size = new System.Drawing.Size(121, 21);
            this.TypeAnimal.TabIndex = 0;
            this.TypeAnimal.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.label3);
            this.GeneralPanel.Controls.Add(this.label2);
            this.GeneralPanel.Controls.Add(this.textNom);
            this.GeneralPanel.Controls.Add(this.numericPrix);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 158);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(360, 100);
            this.GeneralPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nom";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(37, 61);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(134, 20);
            this.textNom.TabIndex = 1;
            // 
            // numericPrix
            // 
            this.numericPrix.Location = new System.Drawing.Point(213, 61);
            this.numericPrix.Name = "numericPrix";
            this.numericPrix.Size = new System.Drawing.Size(120, 20);
            this.numericPrix.TabIndex = 0;
            // 
            // panelMammal
            // 
            this.panelMammal.Controls.Add(this.label4);
            this.panelMammal.Controls.Add(this.numericNbMois);
            this.panelMammal.Location = new System.Drawing.Point(394, 158);
            this.panelMammal.Name = "panelMammal";
            this.panelMammal.Size = new System.Drawing.Size(170, 100);
            this.panelMammal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mois d\'accouchement";
            // 
            // numericNbMois
            // 
            this.numericNbMois.Location = new System.Drawing.Point(23, 61);
            this.numericNbMois.Name = "numericNbMois";
            this.numericNbMois.Size = new System.Drawing.Size(120, 20);
            this.numericNbMois.TabIndex = 1;
            // 
            // panelInsecte
            // 
            this.panelInsecte.Controls.Add(this.label5);
            this.panelInsecte.Controls.Add(this.numericAiles);
            this.panelInsecte.Location = new System.Drawing.Point(588, 158);
            this.panelInsecte.Name = "panelInsecte";
            this.panelInsecte.Size = new System.Drawing.Size(170, 100);
            this.panelInsecte.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre d\'ailes";
            // 
            // numericAiles
            // 
            this.numericAiles.Location = new System.Drawing.Point(22, 62);
            this.numericAiles.Name = "numericAiles";
            this.numericAiles.Size = new System.Drawing.Size(120, 20);
            this.numericAiles.TabIndex = 1;
            // 
            // panelChien
            // 
            this.panelChien.Controls.Add(this.label6);
            this.panelChien.Controls.Add(this.textRace);
            this.panelChien.Location = new System.Drawing.Point(775, 158);
            this.panelChien.Name = "panelChien";
            this.panelChien.Size = new System.Drawing.Size(181, 100);
            this.panelChien.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Race";
            // 
            // textRace
            // 
            this.textRace.Location = new System.Drawing.Point(27, 62);
            this.textRace.Name = "textRace";
            this.textRace.Size = new System.Drawing.Size(134, 20);
            this.textRace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "type animal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 100);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "Appliquer Remise";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(69, 291);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(776, 198);
            this.dataGrid.TabIndex = 8;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 514);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelChien);
            this.Controls.Add(this.panelInsecte);
            this.Controls.Add(this.panelMammal);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.TypeAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrix)).EndInit();
            this.panelMammal.ResumeLayout(false);
            this.panelMammal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbMois)).EndInit();
            this.panelInsecte.ResumeLayout(false);
            this.panelInsecte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAiles)).EndInit();
            this.panelChien.ResumeLayout(false);
            this.panelChien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeAnimal;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.NumericUpDown numericPrix;
        private System.Windows.Forms.Panel panelMammal;
        private System.Windows.Forms.NumericUpDown numericNbMois;
        private System.Windows.Forms.Panel panelInsecte;
        private System.Windows.Forms.Panel panelChien;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.NumericUpDown numericAiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

