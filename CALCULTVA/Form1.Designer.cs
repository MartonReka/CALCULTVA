namespace CALCULTVA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valtva = new System.Windows.Forms.Label();
            this.valoare = new System.Windows.Forms.TextBox();
            this.TVA = new System.Windows.Forms.TextBox();
            this.Calculeaza = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoarea produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procent TVA";
            // 
            // valtva
            // 
            this.valtva.AutoSize = true;
            this.valtva.Location = new System.Drawing.Point(34, 220);
            this.valtva.Name = "valtva";
            this.valtva.Size = new System.Drawing.Size(67, 13);
            this.valtva.TabIndex = 2;
            this.valtva.Text = "Preti cu TVA";
            this.valtva.Click += new System.EventHandler(this.label3_Click);
            // 
            // valoare
            // 
            this.valoare.Location = new System.Drawing.Point(146, 38);
            this.valoare.Name = "valoare";
            this.valoare.Size = new System.Drawing.Size(208, 20);
            this.valoare.TabIndex = 3;
            // 
            // TVA
            // 
            this.TVA.Location = new System.Drawing.Point(147, 108);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(206, 20);
            this.TVA.TabIndex = 4;
            // 
            // Calculeaza
            // 
            this.Calculeaza.Location = new System.Drawing.Point(43, 345);
            this.Calculeaza.Name = "Calculeaza";
            this.Calculeaza.Size = new System.Drawing.Size(97, 49);
            this.Calculeaza.TabIndex = 5;
            this.Calculeaza.Text = "Calculeaza";
            this.Calculeaza.UseVisualStyleBackColor = true;
            this.Calculeaza.Click += new System.EventHandler(this.Calculeaza_Click);
            // 
            // Iesire
            // 
            this.Iesire.Location = new System.Drawing.Point(221, 344);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(110, 49);
            this.Iesire.TabIndex = 6;
            this.Iesire.Text = "Iesire";
            this.Iesire.UseVisualStyleBackColor = true;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.Iesire);
            this.Controls.Add(this.Calculeaza);
            this.Controls.Add(this.TVA);
            this.Controls.Add(this.valoare);
            this.Controls.Add(this.valtva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valtva;
        private System.Windows.Forms.TextBox valoare;
        private System.Windows.Forms.TextBox TVA;
        private System.Windows.Forms.Button Calculeaza;
        private System.Windows.Forms.Button Iesire;
    }
}

