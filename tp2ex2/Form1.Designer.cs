namespace tp2ex2
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
            this.m = new System.Windows.Forms.TextBox();
            this.xi = new System.Windows.Forms.NumericUpDown();
            this.yi = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.xi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.SuspendLayout();
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(130, 126);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 20);
            this.m.TabIndex = 0;
            // 
            // xi
            // 
            this.xi.Location = new System.Drawing.Point(301, 136);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(120, 20);
            this.xi.TabIndex = 1;
            // 
            // yi
            // 
            this.yi.Location = new System.Drawing.Point(450, 136);
            this.yi.Name = "yi";
            this.yi.Size = new System.Drawing.Size(120, 20);
            this.yi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "creer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(586, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "avance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(637, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "reculer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "position  (x,y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "annee de son model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "prix";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(130, 221);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 10;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(230, 302);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(120, 20);
            this.p.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yi);
            this.Controls.Add(this.xi);
            this.Controls.Add(this.m);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.NumericUpDown xi;
        private System.Windows.Forms.NumericUpDown yi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.NumericUpDown p;
    }
}

