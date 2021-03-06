using FinancialQuiz.DAL;
using FinancialQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialQuiz.Controller
{
    public class GamesController
    {
        GamesDAL gamesDAL;

        public GamesController()
        {
            this.gamesDAL = new GamesDAL();
        }
        
        /// <summary>
        /// Returns the gameID generated upon creating a new game and writing its details to the DB
        /// </summary>
        /// <param name="userID">ID# of the user playing this game</param>
        /// <param name="numberOfQuestions">number of total questions in the quiz</param>
        /// <param name="categoryID">ID# for the selected category</param>
        /// <param name="ageID">ID# for the selected age category</param>
        /// <param name="gameLevelID">ID# for the selected game level</param>
        /// <returns></returns>
        public int InsertQuizGameDetails(int userID, int numberOfQuestions, int categoryID, int ageID)
        {
            return this.gamesDAL.InsertQuizGameDetails(userID, numberOfQuestions, categoryID, ageID);
        }

        public GameStats GetGameStats(int gameID)
        {
            return this.gamesDAL.GetGameStats(gameID);
        }

        /// <summary>
        /// Returns true if successfully ends the quiz
        /// </summary>
        /// <param name="gameId">ID# of the user playing this game</param>
        /// <param name="correctCount">number of total questions in the quiz</param>
        /// <param name="missedCount">ID# for the selected category</param>
        /// <param name="score">ID# for the selected age category</param>
        /// <returns>true</returns>
        public bool EndQuiz(int gameId, int correctCount, int missedCount, int score)
        {
            return this.gamesDAL.EndQuiz(gameId, correctCount, missedCount, score);
        }


    }
}
