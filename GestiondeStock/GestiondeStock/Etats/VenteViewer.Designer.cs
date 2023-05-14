
namespace GestiondeStock.Etats
{
    partial class VenteViewer
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
            this.ReportViewerVente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportVente1 = new GestiondeStock.Etats.ReportVente();
            this.SuspendLayout();
            // 
            // ReportViewerVente
            // 
            this.ReportViewerVente.ActiveViewIndex = 0;
            this.ReportViewerVente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerVente.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerVente.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerVente.Name = "ReportViewerVente";
            this.ReportViewerVente.ReportSource = this.ReportVente1;
            this.ReportViewerVente.Size = new System.Drawing.Size(1340, 689);
            this.ReportViewerVente.TabIndex = 0;
            this.ReportViewerVente.Load += new System.EventHandler(this.ReportViewerVente_Load);
            // 
            // VenteViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 689);
            this.Controls.Add(this.ReportViewerVente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenteViewer";
            this.Text = "VenteViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerVente;
        private ReportVente ReportVente1;
    }
}