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
    public partial class GameLauncher : Form
    {

        User loggedInUser;
        private LoginForm loginForm;

        public GameLauncher(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();


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

        private void BeginGameButton_Click(object sender, EventArgs e)
        {
            PlayerDashboard playerDashboard = new PlayerDashboard(this.loggedInUser);
            playerDashboard.SetLoginForm(this.loginForm);

            playerDashboard.GetGameSettings(1,2,3);  //NEEDS TO PULL FORM SELECTED DATA

            GameLauncher.ActiveForm.Close();
            playerDashboard.Show();
            

        }
    }
}
