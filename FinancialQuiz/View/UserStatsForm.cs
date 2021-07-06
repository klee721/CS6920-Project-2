using FinancialQuiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialQuiz.View
{
    public partial class UserStatsForm : Form
    {

        User loggedInUser;

        public UserStatsForm()
        {
            InitializeComponent();
            this.loggedInUser = new User();

        }

        public void SetUser(User user)
        {
            this.loggedInUser = user;
        }

        private void UserStatsForm_Load(object sender, EventArgs e)
        {
            var reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();

            reportViewer1.LocalReport.ReportEmbeddedResource = "FinancialQuiz.View.UserReport.rdlc";

            this.getUserReportTableAdapter.Fill(this.userStatsDataSet.GetUserReport, this.loggedInUser.UserID);
            this.reportViewer1.RefreshReport();


            //reportViewer1.Reset();
           // reportViewer1.LocalReport.ReportEmbeddedResource = "FinancialQuiz.View.UserReport.rdlc";
           // Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            // Must match the DataSet in the RDLC
            //reportDataSource.Name = "UserStatsReportDataSet";
            //reportDataSource.Value = userStatsDataSet.Tables[0];
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //reportViewer1.RefreshReport();

        }
    }
}
