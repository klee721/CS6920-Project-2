using FinancialQuiz.DAL;
using FinancialQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialQuiz.Controller
{
    
    public class GameLevelController
    {
        GameLevelDAL gameLevelDAL;

        public GameLevelController()
        {
            this.gameLevelDAL = new GameLevelDAL();
        }

        /// <summary>
        /// Grabs and returns all Game Levels from the DB
        /// </summary>
        /// <returns></returns>
        public List<GameLevel> GetAllGameLevels()
        {
            return this.gameLevelDAL.GetAllGameLevels();
        }

    }
}
