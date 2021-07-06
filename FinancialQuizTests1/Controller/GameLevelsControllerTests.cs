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
    public class GameLevelsControllerTests
    {
        [TestMethod()]
        public void GetAllGameLevelsTest()
        {
            GameLevelController gamelevelSource = new GameLevelController();
            List<GameLevel> levelList = gamelevelSource.GetAllGameLevels();
            Assert.AreEqual(1, levelList[0].GameLevelID);
            Assert.AreEqual("Beginner", levelList[0].Name);
        }
    }
}
