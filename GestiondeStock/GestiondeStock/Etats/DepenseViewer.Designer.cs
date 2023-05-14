
namespace GestiondeStock.Etats
{
    partial class DepenseViewer
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
            this.ReportViewerDepense = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportDepense1 = new GestiondeStock.Etats.ReportDepense();
            this.SuspendLayout();
            // 
            // ReportViewerDepense
            // 
            this.ReportViewerDepense.ActiveViewIndex = 0;
            this.ReportViewerDepense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerDepense.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerDepense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerDepense.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerDepense.Name = "ReportViewerDepense";
            this.ReportViewerDepense.ReportSource = this.ReportDepense1;
            this.ReportViewerDepense.Size = new System.Drawing.Size(1297, 725);
            this.ReportViewerDepense.TabIndex = 0;
            this.ReportViewerDepense.Load += new System.EventHandler(this.ReportViewerDepense_Load);
            // 
            // DepenseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 725);
            this.Controls.Add(this.ReportViewerDepense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepenseViewer";
            this.Text = "DepenseViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerDepense;
        private ReportDepense ReportDepense1;
    }
}