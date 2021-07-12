using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Model
{
    /// <summary>
    /// Summary description for QuestionModelTests
    /// </summary>
    [TestClass]
    public class QuestionModelTests
    {
        public QuestionModelTests()
        {
            //
            // TODO: Add constructor logic here
            //
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestQuestionCreation()
        {
            Question testQuestion = new Question();
            Assert.IsNotNull(testQuestion);
        }

        [TestMethod]
        public void TestQuestionGetSetID()
        {
            Question testQuestion = new Question();
            testQuestion.QuestionID = 1;
            Assert.AreEqual(testQuestion.QuestionID, 1);

        }

        [TestMethod]
        public void TestQuestionGetSetDescription()
        {
            Question testQuestion = new Question();
            testQuestion.Description = "How many cents in a dollar?";
            Assert.AreEqual(testQuestion.Description, "How many cents in a dollar?");

        }

        [TestMethod]
        public void TestQuestionGetSetOptions()
        {
            Question testQuestion = new Question();
            testQuestion.OptionA = "A";
            Assert.AreEqual(testQuestion.OptionA, "A");
            testQuestion.OptionB = "B";
            Assert.AreEqual(testQuestion.OptionB, "B");
            testQuestion.OptionC = "C";
            Assert.AreEqual(testQuestion.OptionC, "C");
            testQuestion.OptionD = "D";
            Assert.AreEqual(testQuestion.OptionD, "D");

        }

        [TestMethod]
        public void TestQuestionGetSetCorrectOption()
        {
            Question testQuestion = new Question();
            testQuestion.CorrectOption = "A";
            Assert.AreEqual(testQuestion.CorrectOption, "A");

        }

        [TestMethod]
        public void TestQuestionGetSetAgeRangeID()
        {
            Question testQuestion = new Question();
            testQuestion.AgeRangeID = 1;
            Assert.AreEqual(testQuestion.AgeRangeID, 1);

        }


        [TestMethod]
        public void TestQuestionGetSetCategoryID()
        {
            Question testQuestion = new Question();
            testQuestion.CategoryID = 9;
            Assert.AreEqual(testQuestion.CategoryID, 9);

        }

        [TestMethod]
        public void TestQuestionGetSetGameLevelID()
        {
            Question testQuestion = new Question();
            testQuestion.GameLevelID = 9;
            Assert.AreEqual(testQuestion.GameLevelID, 9);

        }

        [TestMethod]
        public void TestQuestionGetSetExplanation()
        {
            Question testQuestion = new Question();
            testQuestion.Explanation = "Test explanation";
            Assert.AreEqual(testQuestion.Explanation, "Test explanation");

        }







    }
}
