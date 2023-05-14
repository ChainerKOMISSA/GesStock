
namespace GestiondeStock.Etats
{
    partial class BrasserieViewer
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
            this.ReportViewerBrasserie = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportBrasserie1 = new GestiondeStock.Etats.ReportBrasserie();
            this.SuspendLayout();
            // 
            // ReportViewerBrasserie
            // 
            this.ReportViewerBrasserie.ActiveViewIndex = 0;
            this.ReportViewerBrasserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerBrasserie.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerBrasserie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerBrasserie.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerBrasserie.Name = "ReportViewerBrasserie";
            this.ReportViewerBrasserie.ReportSource = this.ReportBrasserie1;
            this.ReportViewerBrasserie.Size = new System.Drawing.Size(1276, 719);
            this.ReportViewerBrasserie.TabIndex = 0;
            this.ReportViewerBrasserie.Load += new System.EventHandler(this.ReportViewerBrasserie_Load);
            // 
            // BrasserieViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 719);
            this.Controls.Add(this.ReportViewerBrasserie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrasserieViewer";
            this.Text = "BrasserieViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerBrasserie;
        private ReportBrasserie ReportBrasserie1;
    }
}