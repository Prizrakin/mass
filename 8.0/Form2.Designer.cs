namespace _8._0
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DobutokMM = new System.Windows.Forms.Button();
            this.Vidnim = new System.Windows.Forms.Button();
            this.DobutokMCh = new System.Windows.Forms.Button();
            this.Skladanie = new System.Windows.Forms.Button();
            this.Dobutok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 261);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Dobutok);
            this.panel2.Controls.Add(this.DobutokMM);
            this.panel2.Controls.Add(this.Vidnim);
            this.panel2.Controls.Add(this.DobutokMCh);
            this.panel2.Controls.Add(this.Skladanie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 261);
            this.panel2.TabIndex = 0;
            // 
            // DobutokMM
            // 
            this.DobutokMM.Location = new System.Drawing.Point(3, 109);
            this.DobutokMM.Name = "DobutokMM";
            this.DobutokMM.Size = new System.Drawing.Size(148, 23);
            this.DobutokMM.TabIndex = 3;
            this.DobutokMM.Text = "Добуток 2 матриць";
            this.DobutokMM.UseVisualStyleBackColor = true;
            this.DobutokMM.Click += new System.EventHandler(this.DobutokMM_Click);
            // 
            // Vidnim
            // 
            this.Vidnim.Location = new System.Drawing.Point(3, 80);
            this.Vidnim.Name = "Vidnim";
            this.Vidnim.Size = new System.Drawing.Size(148, 23);
            this.Vidnim.TabIndex = 2;
            this.Vidnim.Text = "Віднімання 2 матриць";
            this.Vidnim.UseVisualStyleBackColor = true;
            this.Vidnim.Click += new System.EventHandler(this.Vidnim_Click);
            // 
            // DobutokMCh
            // 
            this.DobutokMCh.Location = new System.Drawing.Point(3, 51);
            this.DobutokMCh.Name = "DobutokMCh";
            this.DobutokMCh.Size = new System.Drawing.Size(148, 23);
            this.DobutokMCh.TabIndex = 1;
            this.DobutokMCh.Text = "Добуток матриці на число";
            this.DobutokMCh.UseVisualStyleBackColor = true;
            this.DobutokMCh.Click += new System.EventHandler(this.DobutokMCh_Click);
            // 
            // Skladanie
            // 
            this.Skladanie.Location = new System.Drawing.Point(3, 22);
            this.Skladanie.Name = "Skladanie";
            this.Skladanie.Size = new System.Drawing.Size(148, 23);
            this.Skladanie.TabIndex = 0;
            this.Skladanie.Text = "Складання 2 матриць";
            this.Skladanie.UseVisualStyleBackColor = true;
            this.Skladanie.Click += new System.EventHandler(this.Skladanie_Click);
            // 
            // Dobutok
            // 
            this.Dobutok.Location = new System.Drawing.Point(42, 194);
            this.Dobutok.Name = "Dobutok";
            this.Dobutok.Size = new System.Drawing.Size(56, 20);
            this.Dobutok.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Число для добутку";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DobutokMM;
        private System.Windows.Forms.Button Vidnim;
        private System.Windows.Forms.Button DobutokMCh;
        private System.Windows.Forms.Button Skladanie;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Dobutok;
    }
}