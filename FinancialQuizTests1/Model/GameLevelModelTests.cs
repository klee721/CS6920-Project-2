using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Model
{
    [TestClass]
    public class GameLevelModelTests
    {

        public GameLevelModelTests()
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
        public void TestGameLevelCreation()
        {
            GameLevel testLevel = new GameLevel();
            Assert.IsNotNull(testLevel);
        }

        [TestMethod]
        public void TestGameLevelGetSetID()
        {
            GameLevel testLevel = new GameLevel();
            testLevel.GameLevelID = 1;
            Assert.AreEqual(1, testLevel.GameLevelID);
        }

        [TestMethod]
        public void TestGameLevelGetSetName()
        {
            GameLevel testLevel = new GameLevel();
            testLevel.Name = "Hard";
            Assert.AreEqual("Hard", testLevel.Name);
        }

        [TestMethod]
        public void TestGameLevelGetSetDescription()
        {
            GameLevel testLevel = new GameLevel();
            testLevel.Description = "Most difficult setting";
            Assert.AreEqual("Most difficult setting", testLevel.Description);
        }





    }

}
