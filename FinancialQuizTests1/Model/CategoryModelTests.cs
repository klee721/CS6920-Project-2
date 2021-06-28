using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Model
{
    [TestClass]
    public class CategoryModelTests
    {

        public CategoryModelTests()
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
        public void TestCategoryCreation()
        {

            Category testCategory = new Category();
            Assert.IsNotNull(testCategory);

        }

        [TestMethod]
        public void TestGetSetCategoryID()
        {

            Category testCategory = new Category();
            testCategory.CategoryID = 1;
            Assert.AreEqual(1, testCategory.CategoryID);

        }

        [TestMethod]
        public void TestGetSetCategoryName()
        {

            Category testCategory = new Category();
            testCategory.Name = "Economics";
            Assert.AreEqual("Economics", testCategory.Name);

        }

        [TestMethod]
        public void TestGetSetCategoryDescription()
        {

            Category testCategory = new Category();
            testCategory.Description = "Questions about econ topics";
            Assert.AreEqual("Questions about econ topics", testCategory.Description);

        }


    }
}
