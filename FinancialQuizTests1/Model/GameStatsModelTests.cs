using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Model
{
    [TestClass]
    public class GameStatsModelTests
    {

        public GameStatsModelTests()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestGameStatsCreation()
        {

            GameStats myStats = new GameStats();
            Assert.IsNotNull(myStats);

        }

        [TestMethod]
        public void TestGetSetGameID()
        {

            GameStats myStats = new GameStats();
            myStats.GameID = 1;
            Assert.AreEqual(1, myStats.GameID);

        }

        [TestMethod]
        public void TestGetSetUserID()
        {
            GameStats myStats = new GameStats();
            myStats.userID = 1;
            Assert.AreEqual(1, myStats.userID);
        }

        [TestMethod]
        public void TestGetSetTotalQuestions()
        {
            GameStats myStats = new GameStats();
            myStats.totalQuestions = 10;
            Assert.AreEqual(10, myStats.totalQuestions);
        }

        [TestMethod]
        public void TestGetSetCompIndex()
        {
            GameStats myStats = new GameStats();
            myStats.compIndex = "Y";
            Assert.AreEqual("Y", myStats.compIndex);
        }

        [TestMethod]
        public void TestGetSetQsCorrect()
        {
            GameStats myStats = new GameStats();
            myStats.questionsCorrect = 5;
            Assert.AreEqual(5, myStats.questionsCorrect);
        }

        [TestMethod]
        public void TestGetSetQsMissed()
        {
            GameStats myStats = new GameStats();
            myStats.questionsMissed = 5;
            Assert.AreEqual(5, myStats.questionsMissed);
        }

        [TestMethod]
        public void TestGetSetScore()
        {
            GameStats myStats = new GameStats();
            myStats.score = 9;
            Assert.AreEqual(9, myStats.score);
        }




    }
}
