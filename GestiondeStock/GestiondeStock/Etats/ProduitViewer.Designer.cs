
namespace GestiondeStock.Etats
{
    partial class ProduitViewer
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
            this.ReportViewerProduit = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportProduit1 = new GestiondeStock.Etats.ReportProduit();
            this.SuspendLayout();
            // 
            // ReportViewerProduit
            // 
            this.ReportViewerProduit.ActiveViewIndex = 0;
            this.ReportViewerProduit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerProduit.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerProduit.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerProduit.Name = "ReportViewerProduit";
            this.ReportViewerProduit.ReportSource = this.ReportProduit1;
            this.ReportViewerProduit.Size = new System.Drawing.Size(1297, 678);
            this.ReportViewerProduit.TabIndex = 0;
            // 
            // ProduitViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 678);
            this.Controls.Add(this.ReportViewerProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduitViewer";
            this.Text = "ProduitViewer";
            this.Load += new System.EventHandler(this.ProduitViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerProduit;
        private ReportProduit ReportProduit1;
    }
}