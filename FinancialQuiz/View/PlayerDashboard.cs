﻿using System;
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
        private StudyGroup myStudyGroup;
        private QuestionController questionController;
        int categoryID;
        int ageID;
        int numberOfQuestions;
        string categoryName;
        int currentQuestion;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.loggedInUser = new User();
            this.loggedInUser = user;
            this.loginForm = new LoginForm();
            
            
            this.questionController = new QuestionController();
            this.currentQuestion = 1;
            

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

        private void StudyGroupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.myStudyGroup = new StudyGroup();
            this.myStudyGroup.SetUser(this.loggedInUser);
            this.myStudyGroup.Show();
        }
    }
}
