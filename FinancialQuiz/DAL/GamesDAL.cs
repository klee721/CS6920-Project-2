using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;
using System.Data.SqlClient;

namespace FinancialQuiz.DAL
{
    public class GamesDAL
    {
        int generatedID = 0;
        

        public int InsertQuizGameDetails(int userID, int numberOfQuestions, int categoryID, int ageID)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();


                using (SqlCommand selectCommand = new SqlCommand("InsertQuizGameDetails", connection))
                {
                    selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    if (userID > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@UserID", userID);
                    }
                    if (numberOfQuestions > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@Total_questions", numberOfQuestions);
                    }
                    if (categoryID > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                    }
                    if (ageID > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@AgeGroupID", ageID);
                    }
                    


                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            generatedID = (int)reader["gameId"];

                        }
                    }
                }
            }



            return generatedID;
        }

        public GameStats GetGameStats(int gameID)
        {
            GameStats myGame = new GameStats();

            string selectStatement = "SELECT userID, Total_questions, Completed_ind, questionsCorrect, questionsMissed, score " +
                "FROM Games " +
                "WHERE ID = @gameID ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@gameID", gameID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                            myGame.userID = reader["userID"] as int? ?? default(int);
                            myGame.totalQuestions = reader["Total_questions"] as int? ?? default(int);
                            myGame.compIndex = reader["Completed_ind"].ToString();
                            myGame.questionsCorrect = reader["questionsCorrect"] as int? ?? default(int);
                            myGame.questionsMissed = myGame.questionsCorrect = reader["questionsMissed"] as int? ?? default(int);
                            myGame.score = myGame.questionsCorrect = reader["score"] as int? ?? default(int);


                        }
                    }
                    return myGame;
                }

            }


        }

    }
}
