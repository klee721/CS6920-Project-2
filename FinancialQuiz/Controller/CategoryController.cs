using System;
using System.Collections.Generic;
using FinancialQuiz.DAL;
using FinancialQuiz.Model;



namespace FinancialQuiz.Controller
{
    public class CategoryController
    {
        CategoryDAL categoryDAL;

        public CategoryController()
        {
            categoryDAL = new CategoryDAL();
        }
        /// <summary>
        /// Grabs and returns all question Categories from the DB
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategories()
        {
            return this.categoryDAL.GetAllCategories();
        }




    }
}
