﻿
namespace GestiondeStock.Formulaires
{
    partial class AjouterCategorie
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
            this.lbltitre = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textnom = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textdesc = new System.Windows.Forms.TextBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(738, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 594);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 594);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(741, 3);
            this.panel4.TabIndex = 1;
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.White;
            this.lbltitre.Location = new System.Drawing.Point(171, 40);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(414, 44);
            this.lbltitre.TabIndex = 3;
            this.lbltitre.Text = "Ajouter une catégorie";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(136, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 3);
            this.panel5.TabIndex = 11;
            // 
            // textnom
            // 
            this.textnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnom.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom.ForeColor = System.Drawing.Color.White;
            this.textnom.Location = new System.Drawing.Point(136, 168);
            this.textnom.Multiline = true;
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(434, 45);
            this.textnom.TabIndex = 10;
            this.textnom.Text = "Entrez le nom";
            this.textnom.Enter += new System.EventHandler(this.textnom_Enter);
            this.textnom.Leave += new System.EventHandler(this.textnom_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(136, 356);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(434, 3);
            this.panel6.TabIndex = 7;
            // 
            // textdesc
            // 
            this.textdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textdesc.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdesc.ForeColor = System.Drawing.Color.White;
            this.textdesc.Location = new System.Drawing.Point(136, 305);
            this.textdesc.Multiline = true;
            this.textdesc.Name = "textdesc";
            this.textdesc.Size = new System.Drawing.Size(434, 45);
            this.textdesc.TabIndex = 6;
            this.textdesc.Text = "Entrez la description";
            this.textdesc.Enter += new System.EventHandler(this.textdesc_Enter);
            this.textdesc.Leave += new System.EventHandler(this.textdesc_Leave);
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.Red;
            this.btnannuler.FlatAppearance.BorderSize = 0;
            this.btnannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnannuler.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.ForeColor = System.Drawing.Color.White;
            this.btnannuler.Location = new System.Drawing.Point(467, 477);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(213, 67);
            this.btnannuler.TabIndex = 14;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            // 
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnvalider.FlatAppearance.BorderSize = 0;
            this.btnvalider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalider.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.ForeColor = System.Drawing.Color.White;
            this.btnvalider.Location = new System.Drawing.Point(25, 477);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(213, 67);
            this.btnvalider.TabIndex = 13;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = false;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GestiondeStock.Properties.Resources.icons8_créer_un_nouveau_48;
            this.button2.Location = new System.Drawing.Point(42, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 69);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestiondeStock.Properties.Resources.icons8_usine_48;
            this.button1.Location = new System.Drawing.Point(42, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 69);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnfermer
            // 
            this.btnfermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfermer.BackColor = System.Drawing.Color.White;
            this.btnfermer.FlatAppearance.BorderSize = 0;
            this.btnfermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfermer.Image = global::GestiondeStock.Properties.Resources.icons8_fermer_48;
            this.btnfermer.Location = new System.Drawing.Point(675, 9);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(54, 48);
            this.btnfermer.TabIndex = 9;
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // AjouterCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(741, 600);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textdesc);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Button btnannuler;
        public System.Windows.Forms.Button btnvalider;
        public System.Windows.Forms.TextBox textnom;
        public System.Windows.Forms.TextBox textdesc;
    }
}