namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculImpotB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.netTextBox = new System.Windows.Forms.TextBox();
            this.PartsCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CalculImpotB
            // 
            this.CalculImpotB.Location = new System.Drawing.Point(73, 156);
            this.CalculImpotB.Name = "CalculImpotB";
            this.CalculImpotB.Size = new System.Drawing.Size(124, 41);
            this.CalculImpotB.TabIndex = 0;
            this.CalculImpotB.Text = "Calcul des impots";
            this.CalculImpotB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de part :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saisir votre revenu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // netTextBox
            // 
            this.netTextBox.Location = new System.Drawing.Point(22, 87);
            this.netTextBox.Name = "netTextBox";
            this.netTextBox.Size = new System.Drawing.Size(100, 20);
            this.netTextBox.TabIndex = 4;
            // 
            // PartsCombo
            // 
            this.PartsCombo.FormattingEnabled = true;
            this.PartsCombo.Location = new System.Drawing.Point(151, 87);
            this.PartsCombo.Name = "PartsCombo";
            this.PartsCombo.Size = new System.Drawing.Size(90, 21);
            this.PartsCombo.TabIndex = 5;
            this.PartsCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(277, 254);
            this.Controls.Add(this.PartsCombo);
            this.Controls.Add(this.CalculImpotB);
            this.Controls.Add(this.netTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculImpotB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox netTextBox;
        private System.Windows.Forms.ComboBox PartsCombo;
    }
}

