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
    }
}
