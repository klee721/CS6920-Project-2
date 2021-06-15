using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialQuiz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;
using System.Security.Cryptography;

namespace UserDAL.Tests
{
    [TestClass()]
    public class UserTests
    {
        
        [TestMethod()]
        public void UserLoginTest()
        {
            // Arrange
            string username = "Lauren";
            string password = "test123";
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.UserLogin(username, password);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("Lauren", listUsers[0].UserName);
            
        }

        [TestMethod()]
        public void AdminLoginTest()
        {
            // Arrange
            string username = "Laura";
            string password = "test4321";
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.AdminLogin(username, password);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("Laura", listUsers[0].UserName);
        }

        [TestMethod()]
        public void GetUsersTestByUsername()
        {
            // Arrange
            string username = "Laura";
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.GetUsers(null, username,1);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("Laura", listUsers[0].UserName);
        }

        [TestMethod()]
        public void GetUsersTestByUserID()
        {
            // Arrange
            int userId = 1;
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.GetUsers(null,null , 1);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("Lauren", listUsers[0].UserName);
        }

        [TestMethod()]
        public void GetUsersTestByName()
        {
            // Arrange
            string name = "hughes Lauren";
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.GetUsers(name,null ,1 );
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("Lauren", listUsers[0].UserName);
        }

        [TestMethod()]
        public void RegisterUserTest()
        {
            List<User> listUsers = new List<User>();
            User user = new User();
            user.FirstName = "Test";
            user.AdminInd = "N";
            user.Password = "test1234";
            user.Age = 20;
            user.LastName = "Last";
            user.UserName = "testuser";
           
            UserController userController = new UserController();
            Boolean userInd;
            userInd = userController.RegisterUser(user);
            Assert.AreEqual(userInd, true);

            listUsers = userController.GetUsers("Test Last", null, 0);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("testuser", listUsers[0].UserName);


        }

        [TestMethod()]
        public void UpdateUserTest()
        {

            List<User> listUsers = new List<User>(); 
            UserController userController = new UserController();
            Boolean userInd;
            
            listUsers = userController.GetUsers(null, null, 1);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual(1, listUsers[0].UserID);

            User usr = listUsers[0];
            usr.AdminInd = "Y";
            usr.FirstName = "M";
            userInd = userController.UpdateUser(usr);
            Assert.AreEqual(userInd, true);
            listUsers = userController.GetUsers(null, null, 1);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("M", listUsers[0].FirstName);


        }
    }
}