using System;
using System.Windows.Forms;
using FinancialQuiz.Model;
using FinancialQuiz.Controller;


namespace FinancialQuiz.View
{
    public partial class PlayerDashboard : Form
    {
        User loggedInUser;
        private LoginForm loginForm;
        private UserStatsForm userStatsForm;
        private QuestionController questionController;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();
            this.userStatsForm = new UserStatsForm();
            this.questionController = new QuestionController();
            this.FillOutComponents();

            this.DisplayQuestionOne();

        }

        /// <summary>
        /// Helper method that displays the information for the first question in the DB. For demo/development purposes
        /// </summary>
        private void DisplayQuestionOne()
        {
            Question questionOne = new Question();
            questionOne = this.questionController.GetSampleQuestion();

            this.QuestionLabel.Text = questionOne.Description;
            this.RadioAnswerA.Text = questionOne.OptionA;
            this.RadioAnswerB.Text = questionOne.OptionB;
            this.RadioAnswerC.Text = questionOne.OptionC;
            this.RadioAnswerD.Text = questionOne.OptionD;

        }



        /// <summary>
        /// Helper method for when the user clicks the X button to close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, FormClosedEventArgs e)
        {
            
            this.loginForm.Show();
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
        /// Method to retrieve the game settings for this session from the GameLauncher window
        /// </summary>
        /// <param name="categoryID">ID# correpsonding to the question topic</param>
        /// <param name="age">ID# corresponding to the age set</param>
        /// <param name="numberOfQuestions">number of questions pulled into the quiz set</param>
        public void GetGameSettings(int categoryID, int age, int numberOfQuestions)
        {



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

        private void reportLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.userStatsForm.SetUser(this.loggedInUser);
            this.userStatsForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {




            //Correct/incorrect label test
            if (CorrectLabel.Visible == false)
            {
               CorrectLabel.Visible = true;
            }
            else
            {
                CorrectLabel.Visible = false;
            }

            if(WrongLabel.Visible == false)
            {
                WrongLabel.Visible = true;
            }
            else
            {
                WrongLabel.Visible = false;
            }



        }
    }
}
