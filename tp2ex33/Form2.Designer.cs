﻿namespace tp2ex33
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.longueur = new System.Windows.Forms.NumericUpDown();
            this.centreX = new System.Windows.Forms.NumericUpDown();
            this.Largeur = new System.Windows.Forms.NumericUpDown();
            this.CentreY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentreY)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(562, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Avancer En Bas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(562, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Avancer Droite";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "longueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "largeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "center(x,y)";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(213, 322);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(120, 20);
            this.distance.TabIndex = 17;
            // 
            // longueur
            // 
            this.longueur.Location = new System.Drawing.Point(374, 179);
            this.longueur.Name = "longueur";
            this.longueur.Size = new System.Drawing.Size(120, 20);
            this.longueur.TabIndex = 16;
            // 
            // centreX
            // 
            this.centreX.Location = new System.Drawing.Point(167, 107);
            this.centreX.Name = "centreX";
            this.centreX.Size = new System.Drawing.Size(120, 20);
            this.centreX.TabIndex = 15;
            // 
            // Largeur
            // 
            this.Largeur.Location = new System.Drawing.Point(140, 180);
            this.Largeur.Name = "Largeur";
            this.Largeur.Size = new System.Drawing.Size(120, 20);
            this.Largeur.TabIndex = 14;
            // 
            // CentreY
            // 
            this.CentreY.Location = new System.Drawing.Point(334, 108);
            this.CentreY.Name = "CentreY";
            this.CentreY.Size = new System.Drawing.Size(120, 20);
            this.CentreY.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.longueur);
            this.Controls.Add(this.centreX);
            this.Controls.Add(this.Largeur);
            this.Controls.Add(this.CentreY);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentreY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.NumericUpDown longueur;
        private System.Windows.Forms.NumericUpDown centreX;
        private System.Windows.Forms.NumericUpDown Largeur;
        private System.Windows.Forms.NumericUpDown CentreY;
    }
}