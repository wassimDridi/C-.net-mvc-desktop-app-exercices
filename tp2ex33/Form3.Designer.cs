namespace tp2ex33
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rayon = new System.Windows.Forms.NumericUpDown();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.CentreY = new System.Windows.Forms.NumericUpDown();
            this.centreX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rayon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentreY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreX)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(573, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 61);
            this.button3.TabIndex = 29;
            this.button3.Text = "Avancer en bas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(562, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "avancer en droite";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 42);
            this.button1.TabIndex = 27;
            this.button1.Text = "Creer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "rayon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Centre(x,y)";
            // 
            // rayon
            // 
            this.rayon.Location = new System.Drawing.Point(409, 169);
            this.rayon.Name = "rayon";
            this.rayon.Size = new System.Drawing.Size(120, 20);
            this.rayon.TabIndex = 23;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(212, 275);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(120, 20);
            this.distance.TabIndex = 22;
            // 
            // CentreY
            // 
            this.CentreY.Location = new System.Drawing.Point(213, 169);
            this.CentreY.Name = "CentreY";
            this.CentreY.Size = new System.Drawing.Size(120, 20);
            this.CentreY.TabIndex = 21;
            // 
            // centreX
            // 
            this.centreX.Location = new System.Drawing.Point(57, 169);
            this.centreX.Name = "centreX";
            this.centreX.Size = new System.Drawing.Size(120, 20);
            this.centreX.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rayon);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.CentreY);
            this.Controls.Add(this.centreX);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.rayon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentreY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rayon;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.NumericUpDown CentreY;
        private System.Windows.Forms.NumericUpDown centreX;
    }
}