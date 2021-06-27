using FinancialQuiz.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialQuiz.DAL
{
    public class GameLevelDAL
    {
        /// <summary>
        /// Method to grab and return all of the Game Level categories in the DB
        /// </summary>
        /// <returns></returns>
        public List<GameLevel> GetAllGameLevels()
        {
            List<GameLevel> gameLevelList = new List<GameLevel>();

            string sqlStatement = "SELECT * from game_level ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            GameLevel newLevel = new GameLevel();
                            newLevel.GameLevelID = Convert.ToInt32(reader["ID"].ToString());
                            newLevel.Name = reader["Name"].ToString();
                            newLevel.Description = reader["Description"].ToString();

                            gameLevelList.Add(newLevel);
                        }
                    }
                }
            }
            return gameLevelList;

        }
    }
}

