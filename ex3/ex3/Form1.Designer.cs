namespace ex3
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.NumericUpDown();
            this.Ajouter = new System.Windows.Forms.Button();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.TypeAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelChien = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoisDaccouchement = new System.Windows.Forms.NumericUpDown();
            this.panelInsecte = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreAailes = new System.Windows.Forms.NumericUpDown();
            this.panelMammifere = new System.Windows.Forms.Panel();
            this.AppliqueRemise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix)).BeginInit();
            this.GeneralPanel.SuspendLayout();
            this.panelChien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoisDaccouchement)).BeginInit();
            this.panelInsecte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreAailes)).BeginInit();
            this.panelMammifere.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(80, 352);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.Size = new System.Drawing.Size(1206, 393);
            this.DataGrid.TabIndex = 14;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(27, 50);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(223, 29);
            this.Nom.TabIndex = 11;
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(304, 50);
            this.prix.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(195, 29);
            this.prix.TabIndex = 10;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(1160, 131);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(193, 100);
            this.Ajouter.TabIndex = 8;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.prix);
            this.GeneralPanel.Controls.Add(this.Nom);
            this.GeneralPanel.Controls.Add(this.label2);
            this.GeneralPanel.Controls.Add(this.label1);
            this.GeneralPanel.Location = new System.Drawing.Point(80, 134);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(530, 100);
            this.GeneralPanel.TabIndex = 15;
            // 
            // TypeAnimal
            // 
            this.TypeAnimal.FormattingEnabled = true;
            this.TypeAnimal.Items.AddRange(new object[] {
            "Mammifere",
            "Chien",
            "Insecte"});
            this.TypeAnimal.Location = new System.Drawing.Point(546, 68);
            this.TypeAnimal.Name = "TypeAnimal";
            this.TypeAnimal.Size = new System.Drawing.Size(234, 32);
            this.TypeAnimal.TabIndex = 16;
            this.TypeAnimal.SelectedIndexChanged += new System.EventHandler(this.TypeAnimal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type Animal";
            // 
            // panelChien
            // 
            this.panelChien.Controls.Add(this.label5);
            this.panelChien.Controls.Add(this.Race);
            this.panelChien.Location = new System.Drawing.Point(962, 131);
            this.panelChien.Name = "panelChien";
            this.panelChien.Size = new System.Drawing.Size(183, 100);
            this.panelChien.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Race";
            // 
            // Race
            // 
            this.Race.Location = new System.Drawing.Point(3, 50);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(179, 29);
            this.Race.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mois d\'accouchement";
            // 
            // MoisDaccouchement
            // 
            this.MoisDaccouchement.Location = new System.Drawing.Point(3, 50);
            this.MoisDaccouchement.Name = "MoisDaccouchement";
            this.MoisDaccouchement.Size = new System.Drawing.Size(245, 29);
            this.MoisDaccouchement.TabIndex = 0;
            // 
            // panelInsecte
            // 
            this.panelInsecte.Controls.Add(this.label6);
            this.panelInsecte.Controls.Add(this.NombreAailes);
            this.panelInsecte.Location = new System.Drawing.Point(630, 237);
            this.panelInsecte.Name = "panelInsecte";
            this.panelInsecte.Size = new System.Drawing.Size(276, 109);
            this.panelInsecte.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre d\'ailes";
            // 
            // NombreAailes
            // 
            this.NombreAailes.Location = new System.Drawing.Point(7, 54);
            this.NombreAailes.Name = "NombreAailes";
            this.NombreAailes.Size = new System.Drawing.Size(245, 29);
            this.NombreAailes.TabIndex = 0;
            // 
            // panelMammifere
            // 
            this.panelMammifere.Controls.Add(this.MoisDaccouchement);
            this.panelMammifere.Controls.Add(this.label4);
            this.panelMammifere.Location = new System.Drawing.Point(630, 131);
            this.panelMammifere.Name = "panelMammifere";
            this.panelMammifere.Size = new System.Drawing.Size(308, 100);
            this.panelMammifere.TabIndex = 20;
            this.panelMammifere.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMammifere_Paint);
            // 
            // AppliqueRemise
            // 
            this.AppliqueRemise.Location = new System.Drawing.Point(1160, 246);
            this.AppliqueRemise.Name = "AppliqueRemise";
            this.AppliqueRemise.Size = new System.Drawing.Size(193, 100);
            this.AppliqueRemise.TabIndex = 21;
            this.AppliqueRemise.Text = "Applique Remise";
            this.AppliqueRemise.UseVisualStyleBackColor = true;
            this.AppliqueRemise.Click += new System.EventHandler(this.AppliqueRemise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.AppliqueRemise);
            this.Controls.Add(this.panelMammifere);
            this.Controls.Add(this.panelInsecte);
            this.Controls.Add(this.panelChien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeAnimal);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Ajouter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix)).EndInit();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.panelChien.ResumeLayout(false);
            this.panelChien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoisDaccouchement)).EndInit();
            this.panelInsecte.ResumeLayout(false);
            this.panelInsecte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreAailes)).EndInit();
            this.panelMammifere.ResumeLayout(false);
            this.panelMammifere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.NumericUpDown prix;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.ComboBox TypeAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelChien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Race;
        private System.Windows.Forms.NumericUpDown MoisDaccouchement;
        private System.Windows.Forms.Panel panelInsecte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NombreAailes;
        private System.Windows.Forms.Panel panelMammifere;
        private System.Windows.Forms.Button AppliqueRemise;
    }
}

