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
            this.getUserReportTableAdapter.Fill(this.userStatsDataSet.GetUserReport, this.loggedInUser.UserID);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
