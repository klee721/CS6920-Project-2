﻿
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
            this.getUserReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userStatsDataSet = new FinancialQuiz.UserStatsDataSet();
            this.getUserReportTableAdapter = new FinancialQuiz.UserStatsDataSetTableAdapters.GetUserReportTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UserStatsDataSet";
            reportDataSource1.Value = this.getUserReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinancialQuiz.View.UserStatsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // UserStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UserStatsForm";
            this.Text = "UserStatsForm";
            this.Load += new System.EventHandler(this.UserStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getUserReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource getUserReportBindingSource;
        private UserStatsDataSet userStatsDataSet;
        private UserStatsDataSetTableAdapters.GetUserReportTableAdapter getUserReportTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}