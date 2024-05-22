namespace tp4ex1
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
            this.vmatricule = new System.Windows.Forms.TextBox();
            this.vposition = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.bavancer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vmatricule
            // 
            this.vmatricule.Location = new System.Drawing.Point(135, 91);
            this.vmatricule.Name = "vmatricule";
            this.vmatricule.Size = new System.Drawing.Size(159, 20);
            this.vmatricule.TabIndex = 0;
            // 
            // vposition
            // 
            this.vposition.Location = new System.Drawing.Point(322, 92);
            this.vposition.Name = "vposition";
            this.vposition.Size = new System.Drawing.Size(120, 20);
            this.vposition.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "CREER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bavancer
            // 
            this.bavancer.Location = new System.Drawing.Point(510, 178);
            this.bavancer.Name = "bavancer";
            this.bavancer.Size = new System.Drawing.Size(130, 73);
            this.bavancer.TabIndex = 3;
            this.bavancer.Text = "AVANCER";
            this.bavancer.UseVisualStyleBackColor = true;
            this.bavancer.Click += new System.EventHandler(this.bavancer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 165);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MATRICULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "POSITION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bavancer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vposition);
            this.Controls.Add(this.vmatricule);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vmatricule;
        private System.Windows.Forms.NumericUpDown vposition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bavancer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

