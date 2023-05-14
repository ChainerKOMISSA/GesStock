
namespace GestiondeStock.Formulaires
{
    partial class AjouterCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnfermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltitre = new System.Windows.Forms.Label();
            this.groupselect = new System.Windows.Forms.GroupBox();
            this.textmontant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textquantite = new System.Windows.Forms.TextBox();
            this.textprix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnajouter = new System.Windows.Forms.Button();
            this.brasserieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lACAMIONNETTEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lACAMIONNETTEDataSet = new GestiondeStock.LACAMIONNETTEDataSet();
            this.groupresult = new System.Windows.Forms.GroupBox();
            this.datagridcmd = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.datecmdpicker = new System.Windows.Forms.DateTimePicker();
            this.brasserieTableAdapter = new GestiondeStock.LACAMIONNETTEDataSetTableAdapters.BrasserieTableAdapter();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combobras = new System.Windows.Forms.ComboBox();
            this.combocat = new System.Windows.Forms.ComboBox();
            this.comboboisson = new System.Windows.Forms.ComboBox();
            this.combomod = new System.Windows.Forms.ComboBox();
            this.groupselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brasserieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSet)).BeginInit();
            this.groupresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcmd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfermer
            // 
            this.btnfermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfermer.BackColor = System.Drawing.Color.White;
            this.btnfermer.FlatAppearance.BorderSize = 0;
            this.btnfermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfermer.Image = global::GestiondeStock.Properties.Resources.icons8_fermer_48;
            this.btnfermer.Location = new System.Drawing.Point(1343, 8);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(54, 48);
            this.btnfermer.TabIndex = 10;
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 3);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1401, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 701);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 704);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1401, 3);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 704);
            this.panel4.TabIndex = 12;
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.White;
            this.lbltitre.Location = new System.Drawing.Point(500, 30);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(514, 44);
            this.lbltitre.TabIndex = 13;
            this.lbltitre.Text = "Enregistrer une commande";
            // 
            // groupselect
            // 
            this.groupselect.Controls.Add(this.combomod);
            this.groupselect.Controls.Add(this.comboboisson);
            this.groupselect.Controls.Add(this.combocat);
            this.groupselect.Controls.Add(this.combobras);
            this.groupselect.Controls.Add(this.textmontant);
            this.groupselect.Controls.Add(this.label8);
            this.groupselect.Controls.Add(this.textquantite);
            this.groupselect.Controls.Add(this.textprix);
            this.groupselect.Controls.Add(this.label6);
            this.groupselect.Controls.Add(this.label5);
            this.groupselect.Controls.Add(this.label4);
            this.groupselect.Controls.Add(this.label3);
            this.groupselect.Controls.Add(this.label2);
            this.groupselect.Controls.Add(this.label1);
            this.groupselect.Controls.Add(this.btnajouter);
            this.groupselect.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupselect.ForeColor = System.Drawing.Color.White;
            this.groupselect.Location = new System.Drawing.Point(12, 81);
            this.groupselect.Name = "groupselect";
            this.groupselect.Size = new System.Drawing.Size(1386, 285);
            this.groupselect.TabIndex = 14;
            this.groupselect.TabStop = false;
            this.groupselect.Text = "Sélections";
            // 
            // textmontant
            // 
            this.textmontant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textmontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textmontant.ForeColor = System.Drawing.Color.White;
            this.textmontant.Location = new System.Drawing.Point(921, 223);
            this.textmontant.Multiline = true;
            this.textmontant.Name = "textmontant";
            this.textmontant.Size = new System.Drawing.Size(180, 44);
            this.textmontant.TabIndex = 30;
            this.textmontant.Enter += new System.EventHandler(this.textmontant_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(772, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Montant";
            // 
            // textquantite
            // 
            this.textquantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textquantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textquantite.ForeColor = System.Drawing.Color.White;
            this.textquantite.Location = new System.Drawing.Point(511, 223);
            this.textquantite.Multiline = true;
            this.textquantite.Name = "textquantite";
            this.textquantite.Size = new System.Drawing.Size(135, 44);
            this.textquantite.TabIndex = 20;
            // 
            // textprix
            // 
            this.textprix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textprix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textprix.ForeColor = System.Drawing.Color.White;
            this.textprix.Location = new System.Drawing.Point(89, 223);
            this.textprix.Multiline = true;
            this.textprix.Name = "textprix";
            this.textprix.Size = new System.Drawing.Size(135, 44);
            this.textprix.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1220, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Boisson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Catégorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Brasserie";
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Location = new System.Drawing.Point(1182, 228);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(198, 51);
            this.btnajouter.TabIndex = 12;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // brasserieBindingSource
            // 
            this.brasserieBindingSource.DataMember = "Brasserie";
            this.brasserieBindingSource.DataSource = this.lACAMIONNETTEDataSetBindingSource;
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
            // groupresult
            // 
            this.groupresult.Controls.Add(this.datagridcmd);
            this.groupresult.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupresult.ForeColor = System.Drawing.Color.White;
            this.groupresult.Location = new System.Drawing.Point(12, 378);
            this.groupresult.Name = "groupresult";
            this.groupresult.Size = new System.Drawing.Size(1386, 271);
            this.groupresult.TabIndex = 15;
            this.groupresult.TabStop = false;
            this.groupresult.Text = "Résultats";
            // 
            // datagridcmd
            // 
            this.datagridcmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridcmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridcmd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridcmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridcmd.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagridcmd.Location = new System.Drawing.Point(6, 36);
            this.datagridcmd.Name = "datagridcmd";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcmd.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridcmd.RowHeadersVisible = false;
            this.datagridcmd.RowHeadersWidth = 62;
            this.datagridcmd.RowTemplate.Height = 28;
            this.datagridcmd.Size = new System.Drawing.Size(1377, 229);
            this.datagridcmd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(11, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date de la commande";
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.Red;
            this.btnannuler.FlatAppearance.BorderSize = 0;
            this.btnannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnannuler.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.ForeColor = System.Drawing.Color.White;
            this.btnannuler.Location = new System.Drawing.Point(1194, 650);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(187, 51);
            this.btnannuler.TabIndex = 19;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnvalider.FlatAppearance.BorderSize = 0;
            this.btnvalider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalider.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.ForeColor = System.Drawing.Color.White;
            this.btnvalider.Location = new System.Drawing.Point(880, 650);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(198, 51);
            this.btnvalider.TabIndex = 18;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = false;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // datecmdpicker
            // 
            this.datecmdpicker.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecmdpicker.Location = new System.Drawing.Point(394, 664);
            this.datecmdpicker.Name = "datecmdpicker";
            this.datecmdpicker.Size = new System.Drawing.Size(248, 29);
            this.datecmdpicker.TabIndex = 20;
            // 
            // brasserieTableAdapter
            // 
            this.brasserieTableAdapter.ClearBeforeFill = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Brasserie";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Catégorie";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Boisson";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modèle";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantité";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Montant";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // combobras
            // 
            this.combobras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combobras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobras.ForeColor = System.Drawing.Color.White;
            this.combobras.FormattingEnabled = true;
            this.combobras.Location = new System.Drawing.Point(32, 106);
            this.combobras.Name = "combobras";
            this.combobras.Size = new System.Drawing.Size(245, 37);
            this.combobras.TabIndex = 31;
            // 
            // combocat
            // 
            this.combocat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combocat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocat.ForeColor = System.Drawing.Color.White;
            this.combocat.FormattingEnabled = true;
            this.combocat.Location = new System.Drawing.Point(385, 106);
            this.combocat.Name = "combocat";
            this.combocat.Size = new System.Drawing.Size(245, 37);
            this.combocat.TabIndex = 32;
            // 
            // comboboisson
            // 
            this.comboboisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboboisson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboisson.ForeColor = System.Drawing.Color.White;
            this.comboboisson.FormattingEnabled = true;
            this.comboboisson.Location = new System.Drawing.Point(777, 106);
            this.comboboisson.Name = "comboboisson";
            this.comboboisson.Size = new System.Drawing.Size(245, 37);
            this.comboboisson.TabIndex = 33;
            // 
            // combomod
            // 
            this.combomod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combomod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomod.ForeColor = System.Drawing.Color.White;
            this.combomod.FormattingEnabled = true;
            this.combomod.Location = new System.Drawing.Point(1138, 106);
            this.combomod.Name = "combomod";
            this.combomod.Size = new System.Drawing.Size(245, 37);
            this.combomod.TabIndex = 34;
            // 
            // AjouterCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1404, 707);
            this.Controls.Add(this.datecmdpicker);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupresult);
            this.Controls.Add(this.groupselect);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnfermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterCommande";
            this.Load += new System.EventHandler(this.AjouterCommande_Load);
            this.groupselect.ResumeLayout(false);
            this.groupselect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brasserieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lACAMIONNETTEDataSet)).EndInit();
            this.groupresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupselect;
        public System.Windows.Forms.TextBox textquantite;
        public System.Windows.Forms.TextBox textprix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.GroupBox groupresult;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnannuler;
        public System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.DateTimePicker datecmdpicker;
        private System.Windows.Forms.BindingSource lACAMIONNETTEDataSetBindingSource;
        private LACAMIONNETTEDataSet lACAMIONNETTEDataSet;
        private System.Windows.Forms.BindingSource brasserieBindingSource;
        private LACAMIONNETTEDataSetTableAdapters.BrasserieTableAdapter brasserieTableAdapter;
        private System.Windows.Forms.DataGridView datagridcmd;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.TextBox textmontant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox combomod;
        private System.Windows.Forms.ComboBox comboboisson;
        private System.Windows.Forms.ComboBox combocat;
        private System.Windows.Forms.ComboBox combobras;
    }
}