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
            string username = "jane";
            string password = "test1234";
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.UserLogin(username, password);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("jane", listUsers[0].UserName);
            
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
            string name = "wilson Sam";
            UserController userController = new UserController();
            List<User> listUsers = new List<User>();
            listUsers = userController.GetUsers(name,null ,0 );
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("Sam", listUsers[0].UserName);
        }

        /// <summary>
        /// Generates a random alphanumeric string.
        /// </summary>
        /// <param name="length">The desired length of the string</param>
        /// <returns>The string which has been generated</returns>
        public static string GenerateRandomAlphanumericString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        /*
        [TestMethod()]
        public void RegisterUserTest()
        {
            List<User> listUsers = new List<User>();
            User user = new User();                ;
            const string alphanumericCharacters =
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
        "abcdefghijklmnopqrstuvwxyz" +
        "0123456789";
            user.FirstName = "Test";
            user.AdminInd = "N";
            user.Password = "test1234";
            user.Age = 20;
            user.LastName = GenerateRandomAlphanumericString(10);
            user.UserName = "testuser";
           
            UserController userController = new UserController();
            Boolean userInd;
            userInd = userController.RegisterUser(user);
            Assert.AreEqual(userInd, true);

            listUsers = userController.GetUsers("Test Last", null, 0);
            Assert.AreEqual(1, listUsers.Count);
            Assert.AreEqual("testuser", listUsers[0].UserName);
        }
        */

        
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