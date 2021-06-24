using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Category> GetAllCategories()
        {
            return this.categoryDAL.GetAllCategories();
        }




    }
}
