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
        readonly AgeController ageSource;

        public ManageQuestionControl()
        {
            InitializeComponent();
            this.questionController = new QuestionController();
            this.question = new Question();
            this.categorySource = new CategoryController();
            this.ageSource = new AgeController();

            // btnAddQ.Enabled = true;
            // btnUpdateQ.Enabled = false;
            //  btnDeleteQ.Enabled = false;
            //  btnClearQ.Enabled = false;
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

            if (searchCriteria == "Question ID")
            {
                try
                {
                    int questionId = Convert.ToInt32(txtSearch.Text);
                    if (questionId < 0)
                    {
                        errorMessage = "Please enter valid question id!";
                        txtSearch.Focus();
                    }

                    questionList = this.questionController.GetQuestions(questionId);
                    this.PopulateQuestionData(questionList[0]);
                }
                catch (FormatException)
                {
                    errorMessage = "Please enter valid user id!";
                    txtSearch.Focus();
                }

            }
        }

        private void PopulateQuestionData(Question question)
        {
            questionId = question.QuestionID;
            this.FillOutCategoryComboBox();
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
            cbxAge.SelectedIndex = -1;
            txtQuestion.Text = "";
            txtAnswerA.Text = "";
            txtAnswerB.Text = "";
            txtAnswerC.Text = "";
            txtAnswerD.Text = "";
            txtCorrectAnswer.Text = "";
            
          //  btnUpdateQ.Enabled = false;
           // btnAddQ.Enabled = true;
           // btnClearQ.Enabled = true;
        }



        private void FillOutCategoryComboBox()
        {
            this.cbxCat.DataSource = this.categorySource.GetAllCategories();
            this.cbxCat.DisplayMember = "Name";
            this.cbxCat.ValueMember = "CategoryID";

        }

        private void FillOutAgeComboBox()
        {
            this.cbxAge.DataSource = this.ageSource.GetAllAges();
            this.cbxAge.DisplayMember = "Name";
            this.cbxAge.ValueMember = "AgeID";
        }
    }
}
