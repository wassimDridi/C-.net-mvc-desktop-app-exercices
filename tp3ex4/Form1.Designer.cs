namespace tp3ex4
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
            this.num = new System.Windows.Forms.NumericUpDown();
            this.m = new System.Windows.Forms.NumericUpDown();
            this.n = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cc = new System.Windows.Forms.RadioButton();
            this.dd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m)).BeginInit();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(56, 46);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 20);
            this.num.TabIndex = 0;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(72, 175);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(120, 20);
            this.m.TabIndex = 1;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(257, 45);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 2;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(400, 45);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 20);
            this.p.TabIndex = 3;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(91, 294);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(395, 20);
            this.res.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "creer client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "creer compte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "valider";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(296, 171);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(52, 17);
            this.cc.TabIndex = 8;
            this.cc.TabStop = true;
            this.cc.Text = "Credit";
            this.cc.UseVisualStyleBackColor = true;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(296, 195);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(50, 17);
            this.dd.TabIndex = 9;
            this.dd.TabStop = true;
            this.dd.Text = "Debit";
            this.dd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "montant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "operation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "resultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.p);
            this.Controls.Add(this.n);
            this.Controls.Add(this.m);
            this.Controls.Add(this.num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.NumericUpDown m;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton cc;
        private System.Windows.Forms.RadioButton dd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

