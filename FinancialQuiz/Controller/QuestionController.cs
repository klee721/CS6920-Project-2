using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.DAL;
using FinancialQuiz.Model;


namespace FinancialQuiz.Controller
{
   

    public class QuestionController
    {
        QuestionDAL questionDAL;

        public QuestionController()
        {
            this.questionDAL = new QuestionDAL();
        }

        /// <summary>
        /// Methos to retrieve the first question in the DB for demo and development purposes
        /// </summary>
        /// <returns>A question object populated from the DB</returns>
        public Question GetSampleQuestion()
        {
            return this.questionDAL.GetSampleQuestion();
        }

        /// <summary>
        /// Method that returns a selected question from the question table
        /// </summary>
        /// <param name="questionId">id of the question</param>
        /// <returns>Question object</returns>
        public List<Question> GetQuestions(int questionId)
        {
            return this.questionDAL.GetQuestions(questionId);
        }

        /// <summary>
        /// Method that returns a selected question from the question table
        /// </summary>
        /// <param name="questionId">id of the question</param>
        /// <returns>Question object</returns>
        public Question GetQuizQuestion(int gameId, int questionNumber)
        {
            return this.questionDAL.GetQuizQuestion(gameId, questionNumber);
        }

        /// <summary>
        /// Updates the question in the Questions table.
        /// </summary>
        /// <param name="question">Question object</param>
        /// <returns>true if the question is updated successfully</returns>
        public bool UpdateQuestion(Question question)
        {
            return QuestionDAL.UpdateQuestion(question);
        }

        /// <summary>
        /// Updates the question in the Questions table.
        /// </summary>
        /// <param name="question">Question object</param>
        /// <returns>true if the question is updated successfully</returns>
        public string UpdateUserQuestionAnswer(int gameId, int questionId, string userOption)
        {
            return this.questionDAL.UpdateUserQuestionAnswer(gameId, questionId, userOption);
        }


        public int InsertQuizQuestion(int userId, int total_questions, int categoryId, int AgeGroupId)
        {
            return this.questionDAL.InsertQuizQuestion(userId, total_questions, categoryId, AgeGroupId);
        }

        /// <summary>
        /// Adds a question to the database through the DAL class.
        /// </summary>
        /// <param name="question">Question</param>
        public Boolean AddQuestion(Question question)
        {
            return QuestionDAL.AddQuestion(question);
        }
        /// <summary>
        /// Returns an integer list of all the input users favorited questions
        /// </summary>
        /// <param name="userID">users whos list is being pulled</param>
        /// <returns></returns>
        public List<int> GetFavoritesList(int userID)
        {
            return this.questionDAL.GetFavoritesList(userID);
        }

        public bool AddQuestionToFavorites(int userId, int questionID)
        {
            return this.questionDAL.AddQuestionToFavorites(userId, questionID);
        }

        public bool RemoveQuestionFromFavorites(int userId, int questionID)
        {
            return this.questionDAL.RemoveQuestionFromFavorites(userId, questionID);
        }

    }
}
