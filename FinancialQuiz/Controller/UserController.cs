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


    }
}
