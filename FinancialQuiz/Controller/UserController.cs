using FinancialQuiz.DAL;
using FinancialQuiz.Model;
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

        public List<User> UserLogin(string username, string password)
        {
            return this.userDAL.UserLogin(username, password);
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

    }
}
