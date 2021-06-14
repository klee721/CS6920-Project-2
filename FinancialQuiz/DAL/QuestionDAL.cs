using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FinancialQuiz.DAL
{
    /// <summary>
    /// DAL class responsible for interacting with the Questions table of the database.
    /// Gets the list of questions and answers.
    /// </summary>
    public class QuestionDAL
    {

        /// <summary>
        /// Method for retrieving the first question from the DB table for demo and development purposes
        /// </summary>
        /// <returns>A question object with only the bare minimum fields filled</returns>
        public Question GetSampleQuestion()
        {
            Question sampleQuestion = new Question();

            string selectStatement = "SELECT ID, Age_range_id, Game_level_id, Category_ID, Description, OptionA, OptionB, OptionC, OptionD, Correct_option from Questions " +
                "WHERE ID = 1";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sampleQuestion.Description = reader["Description"].ToString();
                            sampleQuestion.OptionA = reader["OptionA"].ToString();
                            sampleQuestion.OptionB = reader["OptionB"].ToString();
                            sampleQuestion.OptionC = reader["Optionc"].ToString();
                            sampleQuestion.OptionD = reader["OptionD"].ToString();

                        }
                    }
                    return sampleQuestion;
                }

            }
        }
    }
}
