using FinancialQuiz.Controller;
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
            this.FillOutCategoryComboBox();
            this.FillOutGameLevelComboBox();
            this.FillOutAgeComboBox();
            txtQuestion.Text = question.Description;
            txtAnswerA.Text = question.OptionA;
            txtAnswerB.Text = question.OptionB;
            txtAnswerC.Text = question.OptionC;
            txtAnswerD.Text = question.OptionD;
            txtCorrectAnswer.Text = question.CorrectOption;
            
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
                txtAnswerC.Text == "" ||
                txtAnswerD.Text == "" ||
                txtCorrectAnswer.Text == "" ||
                cbxCat.Text == "" ||
                cbxAge.Text == "")
            {
                MessageBox.Show("Please check your information - some fields are empty.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
