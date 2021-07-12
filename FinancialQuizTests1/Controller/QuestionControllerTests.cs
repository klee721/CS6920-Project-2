using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialQuiz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;

namespace FinancialQuiz.Controller.Tests
{
    [TestClass()]
    public class QuestionControllerTests
    {
       
        [TestMethod()]
        public void GetQuizQuestionTest()
        {
            // Arrange
            int gameId = 1;
            int questionNumber = 2;
            QuestionController controller = new QuestionController();
            Question question = new Question();
            question = controller.GetQuizQuestion(gameId, questionNumber);
            Assert.AreEqual(10, question.QuestionID);
           

        }

        [TestMethod()]
        public void InsertQuizQuestionTest()
        {
            // Arrange
            int userId = 1;
            int totalQuestions = 5;
            int categoryId = 1;
            int agegroupId = 1;
            QuestionController controller = new QuestionController();
            int gameId = 0;
            gameId = controller.InsertQuizQuestion(userId, totalQuestions, categoryId, agegroupId);
            Console.WriteLine(gameId);
            Assert.AreNotEqual(gameId, 0);


        }

        [TestMethod()]
        public void UpdateUserQuestionAnswerTest()
        {
            // Arrange
            int gameId = 1;
            int questionId = 1;
            string userOption = "A";
            string usranswer = "";

            QuestionController controller = new QuestionController();
            usranswer = controller.UpdateUserQuestionAnswer(gameId, questionId, userOption);
            Assert.AreEqual(userOption, usranswer);


        }

        [TestMethod()]
        public void EndQuizTest()
        {
            // Arrange
            int gameId = 1;
            int correctCount = 1;
            int missedCount = 1;
            int score = 1;
            bool processed = false;

            GamesController controller = new GamesController();
            processed = controller.EndQuiz(gameId, correctCount, missedCount, score);
            Assert.AreEqual(processed, true);


        }

    }
}