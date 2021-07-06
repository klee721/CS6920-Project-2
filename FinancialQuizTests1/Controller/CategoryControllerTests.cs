using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialQuiz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;

namespace FinancialQuizTests1.Controller {

    [TestClass()]
    public  class CategoryControllerTests
    {
        [TestMethod()]
        public void GetAllCategoriesTest()
        {
        CategoryController categorySource = new CategoryController();
        List<Category> categoryList = categorySource.GetAllCategories();
        Assert.AreEqual(1, categoryList[0].CategoryID);
        Assert.AreEqual("Setting goals", categoryList[0].Name);
        }
    }
    
}
