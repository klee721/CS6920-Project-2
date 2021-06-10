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
    public partial class PlayerDashboard : Form
    {
        User loggedInUser;
        private LoginForm loginForm;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();
            this.FillOutComponents();

        }


        /// <summary>
        /// Helper method for when the user clicks the X button to close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Helper method to set any applicable labels to user specific data
        /// </summary>
        private void FillOutComponents()
        {
            this.UserNameLabel.Text = this.loggedInUser.FirstName;
        }

        /// <summary>
        /// Takes in a User object and stores it for use in game
        /// </summary>
        /// <param name="user"></param>
        public void SetLoggedInUser(User user)
        {
            if (user != null)
            {
                this.loggedInUser = new User();
                this.loggedInUser = user;
            }

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

        /// <summary>
        /// Logout link closes this instance of the dashboard and sends the user back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.loggedInUser = null;
            PlayerDashboard.ActiveForm.Close();
            this.loginForm.Show();
            
        }
    }
}
