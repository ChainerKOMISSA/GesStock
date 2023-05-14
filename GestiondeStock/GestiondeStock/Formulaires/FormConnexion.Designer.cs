
namespace GestiondeStock.Formulaires
{
    partial class FormConnexion
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textmdp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.btnseconnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(647, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 591);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 594);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 594);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connexion";
            // 
            // textnom
            // 
            this.textnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnom.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom.ForeColor = System.Drawing.Color.White;
            this.textnom.Location = new System.Drawing.Point(147, 176);
            this.textnom.Multiline = true;
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(348, 34);
            this.textnom.TabIndex = 9;
            this.textnom.Text = "Nom d\'utilisateur";
            this.textnom.Enter += new System.EventHandler(this.textnom_Enter);
            this.textnom.Leave += new System.EventHandler(this.textnom_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(147, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 3);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(147, 363);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 3);
            this.panel6.TabIndex = 13;
            // 
            // textmdp
            // 
            this.textmdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textmdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textmdp.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmdp.ForeColor = System.Drawing.Color.White;
            this.textmdp.Location = new System.Drawing.Point(147, 323);
            this.textmdp.Multiline = true;
            this.textmdp.Name = "textmdp";
            this.textmdp.Size = new System.Drawing.Size(348, 34);
            this.textmdp.TabIndex = 12;
            this.textmdp.Text = "Mot de passe";
            this.textmdp.Enter += new System.EventHandler(this.textmdp_Enter);
            this.textmdp.Leave += new System.EventHandler(this.textmdp_Leave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GestiondeStock.Properties.Resources.icons8_verrouiller_2_48;
            this.button2.Location = new System.Drawing.Point(51, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 52);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestiondeStock.Properties.Resources.icons8_utilisateur_48;
            this.button1.Location = new System.Drawing.Point(51, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 52);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnfermer
            // 
            this.btnfermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfermer.BackColor = System.Drawing.Color.White;
            this.btnfermer.FlatAppearance.BorderSize = 0;
            this.btnfermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfermer.Image = global::GestiondeStock.Properties.Resources.icons8_fermer_48;
            this.btnfermer.Location = new System.Drawing.Point(587, 9);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(54, 48);
            this.btnfermer.TabIndex = 8;
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // btnseconnecter
            // 
            this.btnseconnecter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnseconnecter.FlatAppearance.BorderSize = 0;
            this.btnseconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseconnecter.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseconnecter.ForeColor = System.Drawing.Color.White;
            this.btnseconnecter.Location = new System.Drawing.Point(120, 478);
            this.btnseconnecter.Name = "btnseconnecter";
            this.btnseconnecter.Size = new System.Drawing.Size(403, 61);
            this.btnseconnecter.TabIndex = 15;
            this.btnseconnecter.Text = "Se Connecter";
            this.btnseconnecter.UseVisualStyleBackColor = false;
            this.btnseconnecter.Click += new System.EventHandler(this.btnseconnecter_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 597);
            this.Controls.Add(this.btnseconnecter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textmdp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnseconnecter;
        public System.Windows.Forms.TextBox textnom;
        public System.Windows.Forms.TextBox textmdp;
    }
}