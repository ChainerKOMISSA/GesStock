
namespace GestiondeStock.Formulaires
{
    partial class AjouterProduit
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltitre = new System.Windows.Forms.Label();
            this.btnfermer = new System.Windows.Forms.Button();
            this.modeleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lACAMIONNETTEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lACAMIONNETTEDataSet = new GestiondeStock.LACAMIONNETTEDataSet();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brasserieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textprix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.brasserieTableAdapter = new GestiondeStock.LACAMIONNETTEDataSetTableAdapters.BrasserieTableAdapter();
            this.categorieTableAdapter = new GestiondeStock.LACAMIONNETTEDataSetTableAdapters.CategorieTableAdapter();
            this.produitTableAdapter = new GestiondeStock.LACAMIONNETTEDataSetTableAdapters.ProduitTableAdapter();
            this.modeleTableAdapter = new GestiondeStock.LACAMIONNETTEDataSetTableAdapters.ModeleTableAdapter();
            this.textquantite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combobras = new System.Windows.Forms.ComboBox();
            this.combocat = new System.Windows.Forms.ComboBox();
            this.textboisson = new System.Windows.Forms.TextBox();
            this.combomod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.modeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brasserieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(935, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 704);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 704);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 701);
            this.panel4.TabIndex = 1;
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.White;
            this.lbltitre.Location = new System.Drawing.Point(268, 35);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(353, 44);
            this.lbltitre.TabIndex = 2;
            this.lbltitre.Text = "Ajouter un produit";
            // 
            // btnfermer
            // 
            this.btnfermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfermer.BackColor = System.Drawing.Color.White;
            this.btnfermer.FlatAppearance.BorderSize = 0;
            this.btnfermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfermer.Image = global::GestiondeStock.Properties.Resources.icons8_fermer_48;
            this.btnfermer.Location = new System.Drawing.Point(875, 10);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(54, 48);
            this.btnfermer.TabIndex = 9;
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // modeleBindingSource
            // 
            this.modeleBindingSource.DataMember = "Modele";
            this.modeleBindingSource.DataSource = this.lACAMIONNETTEDataSetBindingSource;
            // 
            // lACAMIONNETTEDataSetBindingSource
            // 
            this.lACAMIONNETTEDataSetBindingSource.DataSource = this.lACAMIONNETTEDataSet;
            this.lACAMIONNETTEDataSetBindingSource.Position = 0;
            // 
            // lACAMIONNETTEDataSet
            // 
            this.lACAMIONNETTEDataSet.DataSetName = "LACAMIONNETTEDataSet";
            this.lACAMIONNETTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.lACAMIONNETTEDataSetBindingSource;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.lACAMIONNETTEDataSetBindingSource;
            // 
            // brasserieBindingSource
            // 
            this.brasserieBindingSource.DataMember = "Brasserie";
            this.brasserieBindingSource.DataSource = this.lACAMIONNETTEDataSetBindingSource;
            // 
            // textprix
            // 
            this.textprix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textprix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textprix.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprix.ForeColor = System.Drawing.Color.White;
            this.textprix.Location = new System.Drawing.Point(175, 438);
            this.textprix.Multiline = true;
            this.textprix.Name = "textprix";
            this.textprix.Size = new System.Drawing.Size(135, 44);
            this.textprix.TabIndex = 30;
            this.textprix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 34);
            this.label5.TabIndex = 28;
            this.label5.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Boisson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(499, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Catégorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Brasserie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(499, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "Modèle";
            // 
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnvalider.FlatAppearance.BorderSize = 0;
            this.btnvalider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalider.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.ForeColor = System.Drawing.Color.White;
            this.btnvalider.Location = new System.Drawing.Point(103, 604);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(229, 69);
            this.btnvalider.TabIndex = 36;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = false;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.Red;
            this.btnannuler.FlatAppearance.BorderSize = 0;
            this.btnannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnannuler.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.ForeColor = System.Drawing.Color.White;
            this.btnannuler.Location = new System.Drawing.Point(532, 604);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(229, 69);
            this.btnannuler.TabIndex = 37;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // brasserieTableAdapter
            // 
            this.brasserieTableAdapter.ClearBeforeFill = true;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // modeleTableAdapter
            // 
            this.modeleTableAdapter.ClearBeforeFill = true;
            // 
            // textquantite
            // 
            this.textquantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textquantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textquantite.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textquantite.ForeColor = System.Drawing.Color.White;
            this.textquantite.Location = new System.Drawing.Point(671, 438);
            this.textquantite.Multiline = true;
            this.textquantite.Name = "textquantite";
            this.textquantite.Size = new System.Drawing.Size(135, 44);
            this.textquantite.TabIndex = 43;
            this.textquantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(499, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 34);
            this.label6.TabIndex = 42;
            this.label6.Text = "Quantité";
            // 
            // combobras
            // 
            this.combobras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combobras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobras.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobras.ForeColor = System.Drawing.Color.White;
            this.combobras.FormattingEnabled = true;
            this.combobras.Location = new System.Drawing.Point(175, 154);
            this.combobras.Name = "combobras";
            this.combobras.Size = new System.Drawing.Size(234, 37);
            this.combobras.TabIndex = 44;
            // 
            // combocat
            // 
            this.combocat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combocat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocat.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocat.ForeColor = System.Drawing.Color.White;
            this.combocat.FormattingEnabled = true;
            this.combocat.Location = new System.Drawing.Point(661, 151);
            this.combocat.Name = "combocat";
            this.combocat.Size = new System.Drawing.Size(234, 37);
            this.combocat.TabIndex = 45;
            // 
            // textboisson
            // 
            this.textboisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textboisson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboisson.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboisson.ForeColor = System.Drawing.Color.White;
            this.textboisson.Location = new System.Drawing.Point(175, 295);
            this.textboisson.Multiline = true;
            this.textboisson.Name = "textboisson";
            this.textboisson.Size = new System.Drawing.Size(234, 44);
            this.textboisson.TabIndex = 48;
            this.textboisson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combomod
            // 
            this.combomod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combomod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomod.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomod.ForeColor = System.Drawing.Color.White;
            this.combomod.FormattingEnabled = true;
            this.combomod.Location = new System.Drawing.Point(661, 302);
            this.combomod.Name = "combomod";
            this.combomod.Size = new System.Drawing.Size(234, 37);
            this.combomod.TabIndex = 49;
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(938, 707);
            this.Controls.Add(this.combomod);
            this.Controls.Add(this.textboisson);
            this.Controls.Add(this.combocat);
            this.Controls.Add(this.combobras);
            this.Controls.Add(this.textquantite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textprix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterProduit";
            ((System.ComponentModel.ISupportInitialize)(this.modeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brasserieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnfermer;
        public System.Windows.Forms.TextBox textprix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource lACAMIONNETTEDataSetBindingSource;
        private LACAMIONNETTEDataSet lACAMIONNETTEDataSet;
        private System.Windows.Forms.BindingSource brasserieBindingSource;
        private LACAMIONNETTEDataSetTableAdapters.BrasserieTableAdapter brasserieTableAdapter;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private LACAMIONNETTEDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private LACAMIONNETTEDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.BindingSource modeleBindingSource;
        private LACAMIONNETTEDataSetTableAdapters.ModeleTableAdapter modeleTableAdapter;
        public System.Windows.Forms.TextBox textquantite;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textboisson;
        public System.Windows.Forms.ComboBox combobras;
        public System.Windows.Forms.ComboBox combocat;
        public System.Windows.Forms.ComboBox combomod;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.Button btnvalider;
        public System.Windows.Forms.Button btnannuler;
    }
}