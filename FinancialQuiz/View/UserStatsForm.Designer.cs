
namespace FinancialQuiz.View
{
    partial class UserStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStatsForm));
            this.getUserReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userStatsDataSet = new FinancialQuiz.UserStatsDataSet();
            this.getUserReportTableAdapter = new FinancialQuiz.UserStatsDataSetTableAdapters.GetUserReportTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblUserReport = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.getUserReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getUserReportBindingSource
            // 
            this.getUserReportBindingSource.DataMember = "GetUserReport";
            this.getUserReportBindingSource.DataSource = this.userStatsDataSet;
            // 
            // userStatsDataSet
            // 
            this.userStatsDataSet.DataSetName = "UserStatsDataSet";
            this.userStatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getUserReportTableAdapter
            // 
            this.getUserReportTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "UserStatsReportDataSet";
            reportDataSource1.Value = this.getUserReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinancialQuiz.View.UserReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 84);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1233, 584);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblUserReport
            // 
            this.lblUserReport.AutoSize = true;
            this.lblUserReport.BackColor = System.Drawing.Color.Transparent;
            this.lblUserReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserReport.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUserReport.Location = new System.Drawing.Point(547, 46);
            this.lblUserReport.Name = "lblUserReport";
            this.lblUserReport.Size = new System.Drawing.Size(236, 23);
            this.lblUserReport.TabIndex = 1;
            this.lblUserReport.Text = "Player Summary Report";
            this.lblUserReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(505, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(40, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // UserStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 676);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblUserReport);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserStatsForm";
            this.Text = "UserStatsForm";
            this.Load += new System.EventHandler(this.UserStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getUserReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource getUserReportBindingSource;
        private UserStatsDataSet userStatsDataSet;
        private UserStatsDataSetTableAdapters.GetUserReportTableAdapter getUserReportTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblUserReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}