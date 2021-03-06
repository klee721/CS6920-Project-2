using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialQuiz.Model;

namespace FinancialQuiz.View
{
    public partial class AdminDashboard : Form
    {

        User loggedInUser;
        private LoginForm loginForm;
        private GamesSummaryForm gamesSummaryForm;
        int exitClicked;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();
            this.FillOutComponents();
            this.exitClicked = 1;
        }


        /// <summary>
        /// Helper method to set any applicable labels to user specific data
        /// </summary>
        private void FillOutComponents()
        {
            this.UserNameLabel.Text = this.loggedInUser.FirstName;
        }

        /// <summary>
        /// Stores a reference to the 'main menu' login form so the player can log out and return to it
        /// </summary>
        /// <param name="loginForm">the main menu form created on application startup</param>
        public void SetLoginForm(LoginForm loginForm)
        {
            if (loginForm != null)
            {
                this.loginForm = loginForm;
            }
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.exitClicked = 0;
            this.loggedInUser = null;
            AdminDashboard.ActiveForm.Close();
            
            this.loginForm.Show();
            
        }

        private void userGamesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.gamesSummaryForm = new GamesSummaryForm();
            this.gamesSummaryForm.Show();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.exitClicked == 1)
            {
                Application.Exit();
            }
            
        }
    }
}
