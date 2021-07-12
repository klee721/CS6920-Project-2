using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialQuiz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Controller
{
    [TestClass()]
    public class GamesControllerTests
    {

        [TestMethod()]
        public void GetGamesStatsTest()
        {
            GamesController gameController = new GamesController();
            GameStats gameStats = gameController.GetGameStats(1);

            Assert.AreEqual(gameStats.userID, 3);
            Assert.AreEqual(gameStats.totalQuestions, 5);
            Assert.AreEqual(gameStats.questionsCorrect, 3);
            Assert.AreEqual(gameStats.questionsMissed, 0);
            Assert.AreEqual(gameStats.score, 3);

        }


    }
}
