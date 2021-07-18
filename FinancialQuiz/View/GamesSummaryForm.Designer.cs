
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesSummaryForm));
            this.userGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameSummaryDataSet = new FinancialQuiz.GameSummaryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.userGamesTableAdapter = new FinancialQuiz.GameSummaryDataSetTableAdapters.UserGamesTableAdapter();
            this.lblGameReport = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.userGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSummaryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userGamesBindingSource
            // 
            this.userGamesBindingSource.DataMember = "UserGames";
            this.userGamesBindingSource.DataSource = this.gameSummaryDataSet;
            // 
            // gameSummaryDataSet
            // 
            this.gameSummaryDataSet.DataSetName = "GameSummaryDataSet";
            this.gameSummaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.userGamesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinancialQuiz.View.UserGamesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 226);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // userGamesTableAdapter
            // 
            this.userGamesTableAdapter.ClearBeforeFill = true;
            // 
            // lblGameReport
            // 
            this.lblGameReport.AutoSize = true;
            this.lblGameReport.BackColor = System.Drawing.Color.Transparent;
            this.lblGameReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameReport.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGameReport.Location = new System.Drawing.Point(446, 94);
            this.lblGameReport.Name = "lblGameReport";
            this.lblGameReport.Size = new System.Drawing.Size(288, 23);
            this.lblGameReport.TabIndex = 2;
            this.lblGameReport.Text = "User/Game Summary Report";
            this.lblGameReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(277, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(163, 170);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GamesSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1126, 860);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblGameReport);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GamesSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamesSummaryForm";
            this.Load += new System.EventHandler(this.GamesSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSummaryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GameSummaryDataSet gameSummaryDataSet;
        private System.Windows.Forms.BindingSource userGamesBindingSource;
        private GameSummaryDataSetTableAdapters.UserGamesTableAdapter userGamesTableAdapter;
        private System.Windows.Forms.Label lblGameReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}