using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialQuiz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;
namespace FinancialQuizTests1.Controller
{
    [TestClass()]
    public class AgeControllerTests
    {

        [TestMethod()]
        public void GetAllAgesTest()
        {
            AgeController ageSource = new AgeController();
            List<Age> ageList = ageSource.GetAllAges();
            Assert.AreEqual(1, ageList[0].AgeID);
            Assert.AreEqual("8-11", ageList[0].Name);

        }

    }
}
