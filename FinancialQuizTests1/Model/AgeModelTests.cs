using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FinancialQuiz.Model;


namespace FinancialQuizTests1.Model

{
    [TestClass]
    public class AgeModelTests
    {

        public AgeModelTests()
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
        public void TestAgeCreation()
        {

            Age testAge = new Age();
            Assert.IsNotNull(testAge);

        }

        [TestMethod]
        public void TestGetSetAgeID()
        {

            Age testAge = new Age();
            testAge.AgeID = 1;
            Assert.AreEqual(1, testAge.AgeID);

        }

        [TestMethod]
        public void TestGetSetAgeName()
        {

            Age testAge = new Age();
            testAge.Name = "10-18";
            Assert.AreEqual("10-18", testAge.Name);

        }

        [TestMethod]
        public void TestGetSetAgeDescription()
        {

            Age testAge = new Age();
            testAge.Description = "description";
            Assert.AreEqual("description", testAge.Description);

        }













    }
}
