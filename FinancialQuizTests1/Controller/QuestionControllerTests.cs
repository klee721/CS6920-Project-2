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
            string username = "jane";
            string password = "test1234";
            int gameId = 1;
            int questionNumber = 2;
            QuestionController controller = new QuestionController();
            Question question = new Question();
            question = controller.GetQuizQuestion(gameId, questionNumber);
            Assert.AreEqual(10, question.QuestionID);
           

        }

       
    }
}