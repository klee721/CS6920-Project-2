using System;
using System.Collections.Generic;
using FinancialQuiz.DAL;
using FinancialQuiz.Model;

namespace FinancialQuiz.Controller
{


    public class AgeController
    {
        AgeDAL ageDAL;

        public AgeController()
        {
            this.ageDAL = new AgeDAL();
        }

        /// <summary>
        /// Grabs and returns all Age categories from the DB
        /// </summary>
        /// <returns></returns>
        public List<Age> GetAllAges()
        {
            return this.ageDAL.GetAllAges();
        }






        
    }
}
