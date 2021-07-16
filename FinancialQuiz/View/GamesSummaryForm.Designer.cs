
namespace FinancialQuiz.View
{
    partial class GamesSummaryForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gameSummaryDataSet = new FinancialQuiz.GameSummaryDataSet();
            this.userGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userGamesTableAdapter = new FinancialQuiz.GameSummaryDataSetTableAdapters.UserGamesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gameSummaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.userGamesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinancialQuiz.View.UserGamesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // gameSummaryDataSet
            // 
            this.gameSummaryDataSet.DataSetName = "GameSummaryDataSet";
            this.gameSummaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userGamesBindingSource
            // 
            this.userGamesBindingSource.DataMember = "UserGames";
            this.userGamesBindingSource.DataSource = this.gameSummaryDataSet;
            // 
            // userGamesTableAdapter
            // 
            this.userGamesTableAdapter.ClearBeforeFill = true;
            // 
            // GamesSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GamesSummaryForm";
            this.Text = "GamesSummaryForm";
            this.Load += new System.EventHandler(this.GamesSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameSummaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGamesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GameSummaryDataSet gameSummaryDataSet;
        private System.Windows.Forms.BindingSource userGamesBindingSource;
        private GameSummaryDataSetTableAdapters.UserGamesTableAdapter userGamesTableAdapter;
    }
}