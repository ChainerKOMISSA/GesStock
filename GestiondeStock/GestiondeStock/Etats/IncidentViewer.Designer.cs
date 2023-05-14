
namespace GestiondeStock.Etats
{
    partial class IncidentViewer
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
            this.ReportViewerIncident = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportIncident1 = new GestiondeStock.Etats.ReportIncident();
            this.SuspendLayout();
            // 
            // ReportViewerIncident
            // 
            this.ReportViewerIncident.ActiveViewIndex = 0;
            this.ReportViewerIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerIncident.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerIncident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerIncident.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerIncident.Name = "ReportViewerIncident";
            this.ReportViewerIncident.ReportSource = this.ReportIncident1;
            this.ReportViewerIncident.Size = new System.Drawing.Size(1292, 717);
            this.ReportViewerIncident.TabIndex = 0;
            this.ReportViewerIncident.Load += new System.EventHandler(this.ReportViewerIncident_Load);
            // 
            // IncidentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 717);
            this.Controls.Add(this.ReportViewerIncident);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncidentViewer";
            this.Text = "IncidentViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerIncident;
        private ReportIncident ReportIncident1;
    }
}