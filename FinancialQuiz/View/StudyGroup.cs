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
using FinancialQuiz.Controller;

namespace FinancialQuiz.View
{
    public partial class StudyGroup : Form
    {
        User loggedInUser;
        QuestionController questionController;
        List<Question> favList;
        Question selectedQuestion;
        private int selectedRowIndex = -1;


        public StudyGroup()
        {
            InitializeComponent();
            this.questionController = new QuestionController();
            this.favList = new List<Question>();
            


        }

        /// <summary>
        /// Populates the data grid view with the users list of favorites
        /// </summary>
        private void RetrieveFavorites()
        {
            List<int> idList = new List<int>();
            this.favList = new List<Question>();

            idList = this.questionController.GetFavoritesList(this.loggedInUser.UserID);

            
            foreach (int id in idList)
            {
                this.favList.Add(this.questionController.GetQuestions(id)[0]);
            }

           
            FavoritesDataGrid.DataSource = this.favList;

            FavoritesDataGrid.Columns[0].Visible = false;
            FavoritesDataGrid.Columns[2].Visible = false;
            FavoritesDataGrid.Columns[3].Visible = false;
            FavoritesDataGrid.Columns[4].Visible = false;
            FavoritesDataGrid.Columns[5].Visible = false;
            FavoritesDataGrid.Columns[6].Visible = false;
            FavoritesDataGrid.Columns[7].Visible = false;
            FavoritesDataGrid.Columns[8].Visible = false;
            FavoritesDataGrid.Columns[9].Visible = false;

        }

        /// <summary>
        /// Sets the logged in user and begins the routine to populate the UI
        /// </summary>
        /// <param name="user">the logged in user</param>
        public void SetUser(User user)
        {
            label1.Text = user.FirstName;
            this.loggedInUser = user;
            this.RetrieveFavorites();
        }

        /// <summary>
        /// Helper method that toggles the visible answers on and off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerDisplayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CorrectAnswer.Visible == false)
            {
                this.CorrectAnswer.Visible = true;
            }
            else
            {
                this.CorrectAnswer.Visible = false;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (this.selectedQuestion != null)
            {
                this.questionController.RemoveQuestionFromFavorites(this.loggedInUser.UserID, this.selectedQuestion.QuestionID);

                this.QuestionText.Text = "";

                this.CorrectAnswer.Text = "";

                this.RetrieveFavorites();

            }
            else
            {
                MessageBox.Show("Please select a study group question below to remove it");
            }

        }

        /// <summary>
        /// Helper method to display the contents of a selected question to the UI
        /// </summary>
        private void DisplayQuestionContents()
        {
            this.QuestionText.Text = this.selectedQuestion.Description;

            this.CorrectAnswer.Text = this.GetAnswerText();


        }

        /// <summary>
        /// helper method that takes the letter representation of the correct answer and returns the corresponding string
        /// </summary>
        /// <returns></returns>
        private string GetAnswerText()
        {
          
            if (this.selectedQuestion.CorrectOption == "A")
            {
                return this.selectedQuestion.OptionA;
            }else if (this.selectedQuestion.CorrectOption == "B")
            {
                return this.selectedQuestion.OptionB;
            }
            else if(this.selectedQuestion.CorrectOption == "C")
            {
                return this.selectedQuestion.OptionC;
            }
            else
            {
                return this.selectedQuestion.OptionD;
            }
            

            

        }


        private void FavoritesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.favList.Count > 0)
            {
                selectedRowIndex = this.FavoritesDataGrid.CurrentRow.Index;

                this.selectedQuestion = this.favList[selectedRowIndex];

                if (this.selectedQuestion != null)
                {
                    this.DisplayQuestionContents();
                }

            }
            

        }
    }
}
