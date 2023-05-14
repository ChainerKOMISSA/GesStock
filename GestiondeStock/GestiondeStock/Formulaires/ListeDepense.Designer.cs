﻿
namespace GestiondeStock.Formulaires
{
    partial class ListeDepense
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdepense = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepense)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(941, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dépenses";
            // 
            // dgvdepense
            // 
            this.dgvdepense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdepense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdepense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdepense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdepense.Location = new System.Drawing.Point(13, 104);
            this.dgvdepense.Name = "dgvdepense";
            this.dgvdepense.RowHeadersVisible = false;
            this.dgvdepense.RowHeadersWidth = 62;
            this.dgvdepense.RowTemplate.Height = 28;
            this.dgvdepense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdepense.Size = new System.Drawing.Size(1406, 456);
            this.dgvdepense.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numéro";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Libellé";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Montant";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // btnimprimer
            // 
            this.btnimprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnimprimer.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.Color.White;
            this.btnimprimer.Image = global::GestiondeStock.Properties.Resources.icons8_impression_48;
            this.btnimprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimer.Location = new System.Drawing.Point(1157, 576);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(262, 78);
            this.btnimprimer.TabIndex = 6;
            this.btnimprimer.Text = "Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = false;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnajouter.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Image = global::GestiondeStock.Properties.Resources.icons8_sac_d_argent_48;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(13, 14);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(411, 78);
            this.btnajouter.TabIndex = 5;
            this.btnajouter.Text = "Nouvelle dépense";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // ListeDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dgvdepense);
            this.Controls.Add(this.label1);
            this.Name = "ListeDepense";
            this.Size = new System.Drawing.Size(1433, 664);
            this.Load += new System.EventHandler(this.ListeDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdepense;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
