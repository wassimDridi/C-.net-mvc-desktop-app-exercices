namespace tp3ex5
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
            this.choix = new System.Windows.Forms.ComboBox();
            this.v1 = new System.Windows.Forms.NumericUpDown();
            this.v2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.afficher = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2)).BeginInit();
            this.SuspendLayout();
            // 
            // choix
            // 
            this.choix.DisplayMember = "Carre";
            this.choix.FormattingEnabled = true;
            this.choix.Items.AddRange(new object[] {
            "Carre",
            "Rectangle",
            "Cercle"});
            this.choix.Location = new System.Drawing.Point(166, 83);
            this.choix.Name = "choix";
            this.choix.Size = new System.Drawing.Size(121, 21);
            this.choix.TabIndex = 0;
            this.choix.ValueMember = "Rectangle";
            this.choix.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.choix.SelectionChangeCommitted += new System.EventHandler(this.choix_SelectionChangeCommitted);
            this.choix.SelectedValueChanged += new System.EventHandler(this.choix_SelectedValueChanged);
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(84, 254);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(120, 20);
            this.v1.TabIndex = 1;
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(377, 253);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(120, 20);
            this.v2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Langeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Largeur";
            // 
            // afficher
            // 
            this.afficher.FormattingEnabled = true;
            this.afficher.Location = new System.Drawing.Point(131, 322);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(411, 95);
            this.afficher.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.choix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choix;
        private System.Windows.Forms.NumericUpDown v1;
        private System.Windows.Forms.NumericUpDown v2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox afficher;
    }
}

