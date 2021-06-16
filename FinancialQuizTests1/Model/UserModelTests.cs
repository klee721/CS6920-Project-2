using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Model
{
    /// <summary>
    /// Summary description for UserModelTests
    /// </summary>
    [TestClass]
    public class UserModelTests
    {
        public UserModelTests()
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
        public void TestUserCreation()
        {

            User testUser = new User();
            Assert.IsNotNull(testUser);
           
        }

        [TestMethod]
        public void TestUserGetSetID()
        {

            User testUser = new User();
            testUser.UserID = 1;
            Assert.AreEqual(testUser.UserID, 1);

        }

        [TestMethod]
        public void TestUserGetSetName()
        {

            User testUser = new User();
            testUser.FirstName = "Tom";
            testUser.LastName = "Brady";
            Assert.AreEqual(testUser.FirstName + testUser.LastName, "TomBrady");

        }

        [TestMethod]
        public void TestUserGetSetAge()
        {

            User testUser = new User();
            testUser.Age = 18;
            Assert.AreEqual(testUser.Age, 18);

        }

        [TestMethod]
        public void TestUserGetSetUserName()
        {

            User testUser = new User();
            testUser.UserName = "Kyle";
            Assert.AreEqual(testUser.UserName, "Kyle");

        }

        [TestMethod]
        public void TestUserGetSetPassword()
        {

            User testUser = new User();
            testUser.Password = "test123";
            Assert.AreEqual(testUser.Password, "test123");

        }

        [TestMethod]
        public void TestUserGetSetAdminInd()
        {

            User testUser = new User();
            testUser.AdminInd = "Y";
            Assert.AreEqual(testUser.AdminInd, "Y");

        }








    }
}
