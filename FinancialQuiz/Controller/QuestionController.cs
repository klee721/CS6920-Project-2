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

        public Question GetQuizQuestion(int gameId, int questionNumber)
        {
            return this.questionDAL.GetQuizQuestion(gameId, questionNumber);
        }

        /// <summary>
        /// Adds a question to the database through the DAL class.
        /// </summary>
        /// <param name="question">Question</param>
        public Boolean AddQuestion(Question question)
        {
            return QuestionDAL.AddQuestion(question);
        }

    }
}
