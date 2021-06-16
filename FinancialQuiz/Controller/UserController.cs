using FinancialQuiz.DAL;
using FinancialQuiz.Model;
using System;
using System.Collections.Generic;

namespace FinancialQuiz.Controller
{
     
    /// <summary>
    /// This class interacts with the DAL layer and implements functions for User
    /// </summary>

   public class UserController
    {
        UserDAL userDAL;
        // <summary>
        /// Class controller
        /// </summary>
        public UserController()
        {
            this.userDAL = new UserDAL();
        }
        /// <summary>
        /// Accesses associated DAL method and returns a List of Users (players) that match the username and password
        /// </summary>
        /// <param name="username">the entered username</param>
        /// <param name="password">the entered password</param>
        /// <returns></returns>
        public List<User> UserLogin(string username, string password)
        {
            return this.userDAL.UserLogin(username, password);
        }
        /// <summary>
        /// Accesses associated DAL method and returns a List of Users (admins) that match the username and password
        /// </summary>
        /// <param name="username">the entered username</param>
        /// <param name="password">the entered password</param>
        /// <returns></returns>
        public List<User> AdminLogin(string username, string password)
        {
            return this.userDAL.AdminLogin(username, password);
        }

        /// <summary>
        /// Method that returns the selected user from the user table
        /// </summary>
        /// <param name="name">first name last name of the user</param>
        /// <param name="username">username</param>
        /// <param name="userId">user id of the user</param>
        /// <returns>User object</returns>
        public List<User> GetUsers(string name, string username, int userId)
        {
            return this.userDAL.GetUsers(name, username, userId);
        }

        /// <summary>
        /// Adds a user to the database through the DAL class.
        /// </summary>
        /// <param name="user">User</param>
        public Boolean RegisterUser(User user)
        {
            return UserDAL.RegisterUser(user);
        }

        /// <summary>
        /// Updates the user in the Users table.
        /// </summary>
        /// <param name="user">User object</param>
        /// <returns>true if user is updated successfully</returns>
        public bool UpdateUser(User user)
        {
            return UserDAL.UpdateUser(user);
        }

    }
}
