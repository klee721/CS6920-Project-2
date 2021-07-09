using System;
using System.Windows.Forms;
using FinancialQuiz.Model;
using FinancialQuiz.Controller;
using System.Collections.Generic;


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
        private GamesController gamesController;
        int categoryID;
        int ageID;
        int numberOfQuestions;
        string categoryName;
        int currentQuestionCount;
        int gameID;
        string chosenAnswer;
        int exitClicked;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();
            
            
            this.questionController = new QuestionController();
            this.gamesController = new GamesController();
            this.currentQuestionCount = 1;
            this.exitClicked = 0;



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


            this.gameID = this.gamesController.InsertQuizGameDetails(this.loggedInUser.UserID, this.numberOfQuestions, this.categoryID, this.ageID);

            Console.WriteLine("Procedure returned: " + this.gameID);

            this.DisplayCurrentQuestion();



        }

        private void DisplayCurrentQuestion()
        {
            this.currentQuestion = this.questionController.GetQuizQuestion(this.gameID,this.currentQuestionCount);
            this.QuestionProgressLabel.Text = this.currentQuestionCount + "/" + this.numberOfQuestions;
            this.QuestionNumberLabel.Text = this.currentQuestionCount.ToString()+".";
            this.QuestionLabel.Text = currentQuestion.Description;
            this.RadioAnswerA.Text = currentQuestion.OptionA;
            this.RadioAnswerB.Text = currentQuestion.OptionB;



            if (currentQuestion.OptionC == "")
            {
                this.RadioAnswerC.Visible = false;
            }
            else
            {
                this.RadioAnswerC.Text = currentQuestion.OptionC;
            }

            if (currentQuestion.OptionD == "")
            {
                this.RadioAnswerD.Visible = false;
            }
            else
            {
                this.RadioAnswerD.Text = currentQuestion.OptionD;
            }
        }

        private void DisableRadios()
        {
            this.RadioAnswerA.Enabled = false;
            this.RadioAnswerB.Enabled = false;
            this.RadioAnswerC.Enabled = false;
            this.RadioAnswerD.Enabled = false;
        }

        private void EnableRadios()
        {
            this.RadioAnswerA.Enabled = true;
            this.RadioAnswerB.Enabled = true;
            this.RadioAnswerC.Enabled = true;
            this.RadioAnswerD.Enabled = true;
        }


        /// <summary>
        /// Logout link closes this instance of the dashboard and sends the user back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.loggedInUser = null;
            this.exitClicked = 1;
            PlayerDashboard.ActiveForm.Close();
            this.loginForm.Show();
            
        }

        private void reportLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.userStatsForm = new UserStatsForm();
            this.userStatsForm.SetUser(this.loggedInUser);
            this.userStatsForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)   //TODO refactor this to cleaner code
        {
            this.DisableRadios();

            SubmitButton.Visible = false;
            NextButton.Visible = true;
            SaveQuestionButton.Visible = true;

            if (RadioAnswerA.Checked == true)
            {
                chosenAnswer = "A";
            }
            else if (RadioAnswerB.Checked == true)
            {
                chosenAnswer = "B";
            }
            else if (RadioAnswerC.Checked == true)
            {
                chosenAnswer = "C";
            }
            else if (RadioAnswerD.Checked == true)
            {
                chosenAnswer = "D";
            }


            if ((RadioAnswerA.Checked==true && currentQuestion.CorrectOption == "A") || (RadioAnswerB.Checked == true && currentQuestion.CorrectOption == "B") 
                    || (RadioAnswerC.Checked == true && currentQuestion.CorrectOption == "C") || (RadioAnswerD.Checked == true && currentQuestion.CorrectOption == "D"))
            {
                this.WrongLabel.Visible = false;
                this.CorrectLabel.Visible = true;
            }else
            {
                this.WrongLabel.Visible = true;
                this.CorrectLabel.Visible = false;
            }


            this.questionController.UpdateUserQuestionAnswer(this.gameID, this.currentQuestion.QuestionID, chosenAnswer);




            if (this.currentQuestionCount == this.numberOfQuestions)
            {
                NextButton.Visible = false;
                this.NewGameButton.Visible = true;
                MessageBox.Show("You have completed this quiz! Click 'Start a New Game' to play again, or logout to quit.");
            }

        }


        private void NewGameCreation()
        {
            GameLauncher newLauncher = new GameLauncher(this.loggedInUser);
            newLauncher.SetLoginForm(this.loginForm);

            this.loginForm.Hide();
            this.exitClicked = 1;
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
            this.EnableRadios();

            this.CorrectLabel.Visible = false;
            this.WrongLabel.Visible = false;

            this.currentQuestionCount++;
            this.NextButton.Visible = false;
            this.SubmitButton.Visible = true;
            this.SaveQuestionButton.Visible = false;

            if (RadioAnswerC.Visible == false)
            {
                RadioAnswerC.Visible = true;
            }

            if (RadioAnswerD.Visible == false)
            {
                RadioAnswerD.Visible = true;
            }

            RadioAnswerA.Checked = true;

            this.DisplayCurrentQuestion();

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {

            this.NewGameCreation();
        }

        private void PlayerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.exitClicked == 0)
            {
                Application.Exit();
            }
            
        }

        private void SaveQuestionButton_Click(object sender, EventArgs e)
        {
            List<int> allFavorites = this.questionController.GetFavoritesList(this.loggedInUser.UserID);
            if (allFavorites.Contains(this.currentQuestion.QuestionID))
            {
                MessageBox.Show("You have already added this question to your study list.");
            }
            else
            {
                 if (this.questionController.AddQuestionToFavorites(this.loggedInUser.UserID, this.currentQuestion.QuestionID)){
                    this.SaveQuestionButton.Visible = false;
                    MessageBox.Show("Successfully added to your study group.");
                 }
            }
        }
    }
}
