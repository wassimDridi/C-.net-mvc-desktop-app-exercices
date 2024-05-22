namespace Tp4Ex4
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
            this.typePerssone = new System.Windows.Forms.ComboBox();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.Label();
            this.dateNais = new System.Windows.Forms.DateTimePicker();
            this.textP = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.panelEmploye = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalaireJ = new System.Windows.Forms.NumericUpDown();
            this.nbJour = new System.Windows.Forms.NumericUpDown();
            this.panelChef = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textService = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDirecteur = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Primee = new System.Windows.Forms.NumericUpDown();
            this.socit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GeneralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaireJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJour)).BeginInit();
            this.panelChef.SuspendLayout();
            this.panelDirecteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Primee)).BeginInit();
            this.SuspendLayout();
            // 
            // typePerssone
            // 
            this.typePerssone.FormattingEnabled = true;
            this.typePerssone.Items.AddRange(new object[] {
            "Employe",
            "Chef",
            "Directeur"});
            this.typePerssone.Location = new System.Drawing.Point(382, 67);
            this.typePerssone.Name = "typePerssone";
            this.typePerssone.Size = new System.Drawing.Size(121, 21);
            this.typePerssone.TabIndex = 0;
            this.typePerssone.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.dataGridView2);
            this.GeneralPanel.Controls.Add(this.label4);
            this.GeneralPanel.Controls.Add(this.prenom);
            this.GeneralPanel.Controls.Add(this.textNom);
            this.GeneralPanel.Controls.Add(this.dateNais);
            this.GeneralPanel.Controls.Add(this.textP);
            this.GeneralPanel.Controls.Add(this.textN);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 127);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(470, 100);
            this.GeneralPanel.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(319, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "date naissance";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(159, 28);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(42, 13);
            this.prenom.TabIndex = 12;
            this.prenom.Text = "prenom";
            // 
            // textNom
            // 
            this.textNom.AutoSize = true;
            this.textNom.Location = new System.Drawing.Point(58, 23);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(27, 13);
            this.textNom.TabIndex = 11;
            this.textNom.Text = "nom";
            // 
            // dateNais
            // 
            this.dateNais.Location = new System.Drawing.Point(256, 65);
            this.dateNais.Name = "dateNais";
            this.dateNais.Size = new System.Drawing.Size(200, 20);
            this.dateNais.TabIndex = 2;
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(139, 65);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(100, 20);
            this.textP.TabIndex = 1;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(17, 65);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 20);
            this.textN.TabIndex = 0;
            // 
            // panelEmploye
            // 
            this.panelEmploye.Controls.Add(this.label6);
            this.panelEmploye.Controls.Add(this.label5);
            this.panelEmploye.Controls.Add(this.SalaireJ);
            this.panelEmploye.Controls.Add(this.nbJour);
            this.panelEmploye.Location = new System.Drawing.Point(545, 127);
            this.panelEmploye.Name = "panelEmploye";
            this.panelEmploye.Size = new System.Drawing.Size(325, 100);
            this.panelEmploye.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "salaire Journalier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "nb jour";
            // 
            // SalaireJ
            // 
            this.SalaireJ.Location = new System.Drawing.Point(190, 65);
            this.SalaireJ.Name = "SalaireJ";
            this.SalaireJ.Size = new System.Drawing.Size(120, 20);
            this.SalaireJ.TabIndex = 1;
            // 
            // nbJour
            // 
            this.nbJour.Location = new System.Drawing.Point(45, 65);
            this.nbJour.Name = "nbJour";
            this.nbJour.Size = new System.Drawing.Size(120, 20);
            this.nbJour.TabIndex = 0;
            // 
            // panelChef
            // 
            this.panelChef.Controls.Add(this.label7);
            this.panelChef.Controls.Add(this.textService);
            this.panelChef.Location = new System.Drawing.Point(353, 240);
            this.panelChef.Name = "panelChef";
            this.panelChef.Size = new System.Drawing.Size(178, 100);
            this.panelChef.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "service";
            // 
            // textService
            // 
            this.textService.Location = new System.Drawing.Point(29, 61);
            this.textService.Name = "textService";
            this.textService.Size = new System.Drawing.Size(100, 20);
            this.textService.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 100);
            this.button1.TabIndex = 7;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(957, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelDirecteur
            // 
            this.panelDirecteur.Controls.Add(this.label9);
            this.panelDirecteur.Controls.Add(this.label8);
            this.panelDirecteur.Controls.Add(this.Primee);
            this.panelDirecteur.Controls.Add(this.socit);
            this.panelDirecteur.Location = new System.Drawing.Point(578, 240);
            this.panelDirecteur.Name = "panelDirecteur";
            this.panelDirecteur.Size = new System.Drawing.Size(303, 100);
            this.panelDirecteur.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Prime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "societe";
            // 
            // Primee
            // 
            this.Primee.Location = new System.Drawing.Point(180, 61);
            this.Primee.Name = "Primee";
            this.Primee.Size = new System.Drawing.Size(120, 20);
            this.Primee.TabIndex = 1;
            // 
            // socit
            // 
            this.socit.Location = new System.Drawing.Point(29, 61);
            this.socit.Name = "socit";
            this.socit.Size = new System.Drawing.Size(100, 20);
            this.socit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "type perssone";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(217, 509);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 384);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(674, 121);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 580);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDirecteur);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelChef);
            this.Controls.Add(this.panelEmploye);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.typePerssone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelEmploye.ResumeLayout(false);
            this.panelEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaireJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJour)).EndInit();
            this.panelChef.ResumeLayout(false);
            this.panelChef.PerformLayout();
            this.panelDirecteur.ResumeLayout(false);
            this.panelDirecteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Primee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typePerssone;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel panelEmploye;
        private System.Windows.Forms.Panel panelChef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.DateTimePicker dateNais;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.NumericUpDown SalaireJ;
        private System.Windows.Forms.NumericUpDown nbJour;
        private System.Windows.Forms.TextBox textService;
        private System.Windows.Forms.Panel panelDirecteur;
        private System.Windows.Forms.TextBox socit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label textNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Primee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

