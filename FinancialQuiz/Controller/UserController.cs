using FinancialQuiz.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
