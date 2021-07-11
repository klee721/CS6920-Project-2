using FinancialQuiz.Controller;
using FinancialQuiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialQuiz.UserControls
{
    public partial class ManageQuestionControl : UserControl
    {
        private readonly QuestionController questionController;
        private Question question;
        private int questionId;
        private List<Question> questionList;
        private ToolTip toolTip;
        readonly CategoryController categorySource;
        readonly GameLevelController gamelevelSource;
        readonly AgeController ageSource;

        public ManageQuestionControl()
        {
            InitializeComponent();
            this.questionController = new QuestionController();
            this.question = new Question();
            this.categorySource = new CategoryController();
            this.gamelevelSource = new GameLevelController();
            this.ageSource = new AgeController();
            btnAddQ.Enabled = true;
            btnUpdateQ.Enabled = false;
            btnDeleteQ.Enabled = false;
            btnClearQ.Enabled = false;
            txtSearch.Focus();
            questionId = 0;
            toolTip = new ToolTip();
        }

        private void ManageQuestionControl_Load(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            cbxSearch.Focus();
            this.FillOutCategoryComboBox();
            this.FillOutGameLevelComboBox();
            this.FillOutAgeComboBox();
            cbxAge.SelectedIndex = -1;
            cbxGameLevel.SelectedIndex = -1;
            cbxCat.SelectedIndex = -1;
        }

        /// <summary>
        /// Method that returns the currently selected question
        /// </summary>
        public Question GetCurrentQuestion()
        {
            return this.question;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            questionId = 0;
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            string searchString = txtSearch.Text;

            string errorMessage = "";
            if (searchString.Trim().Length == 0)
            {
                errorMessage = "Please enter " + searchCriteria;
                txtSearch.Focus();
            }
            else if (searchCriteria == "Question ID")
            {
                try
                {
                    int questionId = Convert.ToInt32(txtSearch.Text);
                    if (questionId <= 0)
                    {
                        errorMessage = "Please enter valid question id!";
                        txtSearch.Focus();
                    }
                    questionList = this.questionController.GetQuestions(questionId);
                }
                catch (FormatException)
                {
                    errorMessage = "Please enter valid user id!";
                    txtSearch.Focus();
                }
            }
            
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Error");
                btnClearQ.Enabled = true;
                btnAddQ.Enabled = false;
            }
            else if (questionList.Count == 0)
            {
                MessageBox.Show("Question doesn't exist. Please check your information.", "Error");
                btnClearQ.Enabled = true;
                btnAddQ.Enabled = false;
            }
            else if (questionList.Count == 1)
            {
                this.PopulateQuestionData(questionList[0]);
            }
        }

        private void PopulateQuestionData(Question question)
        {
            btnUpdateQ.Enabled = true;
            btnAddQ.Enabled = false;
            btnClearQ.Enabled = true;
            btnDeleteQ.Enabled = true;

            questionId = question.QuestionID;
           
            cbxCat.SelectedValue = question.CategoryID;
            cbxAge.SelectedValue = question.AgeRangeID;
            cbxGameLevel.SelectedValue = question.GameLevelID;
            txtQuestion.Text = question.Description;
            txtAnswerA.Text = question.OptionA;
            txtAnswerB.Text = question.OptionB;
            txtAnswerC.Text = question.OptionC;
            txtAnswerD.Text = question.OptionD;
            txtBoxExplanation.Text = question.Explanation;
            txtCorrectAnswer.Text = question.CorrectOption;
            Console.WriteLine("Question cat id : " + question.CategoryID);
            Console.WriteLine("Question age id : " + question.AgeRangeID);
            Console.WriteLine("Question game l id : " + question.GameLevelID);

        }

        private void btnClearQ_Click(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
            cbxCat.SelectedIndex = -1;
            cbxGameLevel.SelectedIndex = -1;
            cbxAge.SelectedIndex = -1;
            txtQuestion.Text = "";
            txtAnswerA.Text = "";
            txtAnswerB.Text = "";
            txtAnswerC.Text = "";
            txtAnswerD.Text = "";
            txtCorrectAnswer.Text = "";
            txtBoxExplanation.Text = "";

            btnUpdateQ.Enabled = false;
            btnAddQ.Enabled = true;
            btnDeleteQ.Enabled = false;
            btnClearQ.Enabled = false;
        }



        private void FillOutCategoryComboBox()
        {
            this.cbxCat.DataSource = this.categorySource.GetAllCategories();
            this.cbxCat.DisplayMember = "Name";
            this.cbxCat.ValueMember = "CategoryID";
          
        }

        private void FillOutGameLevelComboBox()
        {
            this.cbxGameLevel.DataSource = this.gamelevelSource.GetAllGameLevels();
            this.cbxGameLevel.DisplayMember = "Name";
            this.cbxGameLevel.ValueMember = "GameLevelID";
        }

        private void FillOutAgeComboBox()
        {
            this.cbxAge.DataSource = this.ageSource.GetAllAges();
            this.cbxAge.DisplayMember = "Name";
            this.cbxAge.ValueMember = "AgeID";
        }

        

        private void btnUpdateQ_Click(object sender, EventArgs e)
        {
            if (this.isValid())
            {
                try
                {
                    Question updatedQuestion = new Question();
     
                    updatedQuestion.QuestionID = this.questionId;
                    updatedQuestion.CategoryID = (int)this.cbxCat.SelectedValue;
                    updatedQuestion.AgeRangeID = (int)this.cbxAge.SelectedValue;
                    updatedQuestion.GameLevelID = (int)this.cbxGameLevel.SelectedValue;
                    updatedQuestion.Description = txtQuestion.Text;
                    updatedQuestion.OptionA= txtAnswerA.Text;
                    updatedQuestion.OptionB = txtAnswerB.Text;
                    updatedQuestion.OptionC = txtAnswerC.Text;
                    updatedQuestion.OptionD = txtAnswerD.Text;
                    updatedQuestion.Explanation = txtBoxExplanation.Text;
                    updatedQuestion.CorrectOption = txtCorrectAnswer.Text;

                    bool isUpdated = this.questionController.UpdateQuestion(updatedQuestion);


                    if (isUpdated)
                    {
                        MessageBox.Show("Question is updated successfully! QuestionID: " + updatedQuestion.QuestionID, "Success");
                    }
                    else
                    {
                        MessageBox.Show("Unable to update the question!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private bool isValid()
        {

            if (txtQuestion.Text == "" ||
                txtAnswerA.Text == "" ||
                txtAnswerB.Text == "" ||
                txtCorrectAnswer.Text == "" ||
                cbxCat.Text == "" ||
                cbxAge.Text == "")
            {
                MessageBox.Show("Please check your information - some fields are empty.");
                return false;
            }
            else if (!Regex.IsMatch(txtCorrectAnswer.Text, @"^[A-D]+$") || txtCorrectAnswer.Text.Length > 1)
            {
                MessageBox.Show("Correct Answer must be one capital letter (A, B, C, D).");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAddQ_Click(object sender, EventArgs e)
        {
            if (this.isValid())
            {
                try
                {
                    Question newQuestion = new Question();
                   
                    newQuestion.CategoryID = (int)this.cbxCat.SelectedValue;
                    newQuestion.AgeRangeID = (int)this.cbxAge.SelectedValue;
                    newQuestion.GameLevelID = (int)this.cbxGameLevel.SelectedValue;
                    newQuestion.Description = txtQuestion.Text;
                    newQuestion.OptionA = txtAnswerA.Text;
                    newQuestion.OptionB = txtAnswerB.Text;
                    newQuestion.OptionC = txtAnswerC.Text;
                    newQuestion.OptionD = txtAnswerD.Text;
                    newQuestion.CorrectOption = txtCorrectAnswer.Text;
  
                    bool isAdded = this.questionController.AddQuestion(newQuestion);

                    if (isAdded)
                    {
                        MessageBox.Show("Question has been created successfully. QuestionID: " + newQuestion.QuestionID, "Registration Complete");
                        btnAddQ.Enabled = false;
                        btnUpdateQ.Enabled = true;
                        btnClearQ.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Question could not be added at this time");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

    }
}

