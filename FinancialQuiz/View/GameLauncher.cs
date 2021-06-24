using System;
using System.Windows.Forms;
using FinancialQuiz.Model;
using FinancialQuiz.Controller;

namespace FinancialQuiz.View
{
    public partial class GameLauncher : Form
    {

        User loggedInUser;
        private LoginForm loginForm;
        CategoryController categorySource;

        public GameLauncher(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();

            this.categorySource = new CategoryController();

            this.FillOutCategoryComboBox();
            this.FillOutAgeComboBox();
            this.FillOutQuestionsComboBox();

        }

        /// <summary>
        /// Method to fill out the Number of Questions combo box
        /// </summary>
        private void FillOutQuestionsComboBox()
        {
            this.NumberOfQuestionsNumUpDown.Minimum = 5;
            this.NumberOfQuestionsNumUpDown.Maximum = 20;
        }
        /// <summary>
        /// Method to fill out the Age combo box
        /// </summary>
        private void FillOutAgeComboBox()
        {
            
        }
        /// <summary>
        /// Method to fill out the Category combo box
        /// </summary>
        private void FillOutCategoryComboBox()
        {
            this.CategoryComboBox.DataSource = this.categorySource.GetAllCategories();
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.ValueMember = "CategoryID";
            
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
        /// Routine to begin the game when the button is clicked. Gathers the selected setting data and passes it to the game dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
