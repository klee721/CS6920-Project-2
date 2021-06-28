using System;
using System.Windows.Forms;
using FinancialQuiz.Model;
using FinancialQuiz.Controller;


namespace FinancialQuiz.View
{
    public partial class PlayerDashboard : Form
    {
        User loggedInUser;
        Question currentQuestion;
        private LoginForm loginForm;
        private UserStatsForm userStatsForm;
        private StudyGroup myStudyGroup;
        private QuestionController questionController;
        int categoryID;
        int ageID;
        int numberOfQuestions;
        string categoryName;
        int currentQuestionCount;
        int gameID;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();
            
            
            this.questionController = new QuestionController();
            this.currentQuestionCount = 1;
           

        }

        /// <summary>
        /// Helper method to set any applicable labels to user specific data
        /// </summary>
        private void FillOutComponents()
        {
            this.UserNameLabel.Text = this.loggedInUser.FirstName;
            this.CategoryLabel.Text = this.categoryName;
            this.QuestionProgressLabel.Text = this.currentQuestion+ "/" + this.numberOfQuestions;
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
        public void GetGameSettings(int categoryID, string categoryName, int age, int numberOfQuestions)
        {
            this.categoryID = categoryID;
            this.ageID = age;
            this.numberOfQuestions = numberOfQuestions;
            this.categoryName = categoryName;

            Console.WriteLine("Values are: " + categoryID + " " + age + " " + numberOfQuestions);
            this.FillOutComponents();


            //CREATE GAME ROUTINE, RETURNS GAMEID


            this.DisplayCurrentQuestion();



        }

        private void DisplayCurrentQuestion()
        {
           

            this.gameID = 1;   //HARD CODED TEST DATA 

           
            this.currentQuestion = this.questionController.GetQuizQuestion(this.gameID,this.currentQuestionCount);
            this.QuestionProgressLabel.Text = this.currentQuestionCount + "/" + this.numberOfQuestions;
            this.QuestionNumberLabel.Text = this.currentQuestionCount.ToString()+".";
            this.QuestionLabel.Text = currentQuestion.Description;
            this.RadioAnswerA.Text = currentQuestion.OptionA;
            this.RadioAnswerB.Text = currentQuestion.OptionB;
            this.RadioAnswerC.Text = currentQuestion.OptionC;
            this.RadioAnswerD.Text = currentQuestion.OptionD;

            


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
            this.userStatsForm = new UserStatsForm();
            this.userStatsForm.SetUser(this.loggedInUser);
            this.userStatsForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SubmitButton.Visible = false;
            NextButton.Visible = true;
            SaveQuestionButton.Visible = true;

            //TODO: VERIFY CORRECT ANSWER



            if (this.currentQuestionCount == this.numberOfQuestions)
            {
                NextButton.Visible = false;
                this.NewGameButton.Visible = true;
                MessageBox.Show("You have completed this quiz! Click 'Start a New Game' to play again, or logout to quit.");






                //TODO: Finished game routine; offer new game/quit
            }

        }


        private void NewGameCreation()
        {
            GameLauncher newLauncher = new GameLauncher(this.loggedInUser);
            newLauncher.SetLoginForm(this.loginForm);

            this.loginForm.Hide();
            PlayerDashboard.ActiveForm.Close();
            newLauncher.Show();
        }

        private void StudyGroupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.myStudyGroup = new StudyGroup();
            this.myStudyGroup.SetUser(this.loggedInUser);
            this.myStudyGroup.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.currentQuestionCount++;
            this.NextButton.Visible = false;
            this.SubmitButton.Visible = true;
            this.SaveQuestionButton.Visible = false;

            this.DisplayCurrentQuestion();

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {

            this.NewGameCreation();
        }
    }
}
