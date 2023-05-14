
namespace GestiondeStock.Etats
{
    partial class ClientViewer
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
            this.ReportViewerClient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportClient1 = new GestiondeStock.Etats.ReportClient();
            this.SuspendLayout();
            // 
            // ReportViewerClient
            // 
            this.ReportViewerClient.ActiveViewIndex = 0;
            this.ReportViewerClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerClient.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerClient.Name = "ReportViewerClient";
            this.ReportViewerClient.ReportSource = this.ReportClient1;
            this.ReportViewerClient.Size = new System.Drawing.Size(1210, 726);
            this.ReportViewerClient.TabIndex = 0;
            this.ReportViewerClient.Load += new System.EventHandler(this.ReportViewerClient_Load);
            // 
            // ClientViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 726);
            this.Controls.Add(this.ReportViewerClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientViewer";
            this.Text = "ClientViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerClient;
        private ReportClient ReportClient1;
    }
}