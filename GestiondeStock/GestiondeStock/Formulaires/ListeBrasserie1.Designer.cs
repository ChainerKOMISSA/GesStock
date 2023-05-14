
namespace GestiondeStock.Formulaires
{
    partial class ListeBrasserie1
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
            this.btnbrasserie = new System.Windows.Forms.Button();
            this.btnboisson = new System.Windows.Forms.Button();
            this.pnlafficher2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnbrasserie
            // 
            this.btnbrasserie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnbrasserie.FlatAppearance.BorderSize = 0;
            this.btnbrasserie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrasserie.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrasserie.ForeColor = System.Drawing.Color.White;
            this.btnbrasserie.Image = global::GestiondeStock.Properties.Resources.icons8_société_48;
            this.btnbrasserie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbrasserie.Location = new System.Drawing.Point(100, 20);
            this.btnbrasserie.Name = "btnbrasserie";
            this.btnbrasserie.Size = new System.Drawing.Size(250, 83);
            this.btnbrasserie.TabIndex = 0;
            this.btnbrasserie.Text = "Brasseries";
            this.btnbrasserie.UseVisualStyleBackColor = false;
            this.btnbrasserie.Click += new System.EventHandler(this.btnbrasserie_Click);
            // 
            // btnboisson
            // 
            this.btnboisson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnboisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnboisson.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboisson.ForeColor = System.Drawing.Color.White;
            this.btnboisson.Image = global::GestiondeStock.Properties.Resources.icons8_bouteille_de_vin_48;
            this.btnboisson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboisson.Location = new System.Drawing.Point(1100, 20);
            this.btnboisson.Name = "btnboisson";
            this.btnboisson.Size = new System.Drawing.Size(250, 83);
            this.btnboisson.TabIndex = 1;
            this.btnboisson.Text = "Boissons";
            this.btnboisson.UseVisualStyleBackColor = false;
            this.btnboisson.Click += new System.EventHandler(this.btnboisson_Click);
            // 
            // pnlafficher2
            // 
            this.pnlafficher2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlafficher2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlafficher2.Location = new System.Drawing.Point(3, 131);
            this.pnlafficher2.Name = "pnlafficher2";
            this.pnlafficher2.Size = new System.Drawing.Size(1406, 520);
            this.pnlafficher2.TabIndex = 2;
            // 
            // ListeBrasserie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlafficher2);
            this.Controls.Add(this.btnboisson);
            this.Controls.Add(this.btnbrasserie);
            this.Name = "ListeBrasserie1";
            this.Size = new System.Drawing.Size(1433, 664);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbrasserie;
        private System.Windows.Forms.Button btnboisson;
        private System.Windows.Forms.Panel pnlafficher2;
    }
}
