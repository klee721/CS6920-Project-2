using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;
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

        /// <summary>
        /// Method that returns a selected question from the questions table
        /// </summary>
        /// <param name="questionid">question id</param>
        /// <returns>Question object</returns>
        public List<Question> GetQuestions(int questionid)
        {
            List<Question> questionList = new List<Question>();

            string sqlStatement = "SELECT ID, Age_range_id, Game_Level_ID, Category_ID, Description, OptionA, OptionB, OptionC, OptionD, Explanation, Correct_Option from Questions ";

            if (questionid > 0)
            {
                sqlStatement += "where ID = @QuestionID";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    if (questionid > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@QuestionID", questionid);
                    }

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Question question = new Question();

                            question.QuestionID = Convert.ToInt32(reader["ID"].ToString());
                            question.AgeRangeID = Convert.ToInt32(reader["Age_range_id"].ToString());
                            question.GameLevelID = Convert.ToInt32(reader["Game_Level_ID"].ToString());
                            question.CategoryID = Convert.ToInt32(reader["Category_ID"].ToString());
                            question.Description = reader["Description"].ToString();
                            question.OptionA = reader["OptionA"].ToString();
                            question.OptionB = reader["OptionB"].ToString();
                            question.OptionC = reader["OptionC"].ToString();
                            question.OptionD = reader["OptionD"].ToString();
                            question.Explanation = reader["Explanation"].ToString();
                            question.CorrectOption = reader["Correct_Option"].ToString();

                            questionList.Add(question);
                        }
                    }
                }
            }

            return questionList;
        }


        /// <summary>
        /// Updates the question in the Questions table.
        /// </summary>
        /// <param name="question">Question object</param>
        /// <returns>true if question is updated successfully</returns>
        public static bool UpdateQuestion(Question question)
        {

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string sqlStatement = "UPDATE Questions" +
                " SET Age_range_id = @AgeRangeId, Game_Level_ID = @GameLevelID, Category_ID = @CategoryID, " +
                "Description = @Description, OptionA = @OptionA, OptionB = @OptionB, " +
                "OptionC = @OptionC, OptionD = @OptionD, Explanation = @Explanation, Correct_Option = @CorrectOption " +
                "WHERE ID = @QuestionID";
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(sqlStatement, connection))
                {
                    updateCommand.Connection = connection;
                    updateCommand.Parameters.AddWithValue("@QuestionID", question.QuestionID);
                    updateCommand.Parameters.AddWithValue("@AgeRangeId", question.AgeRangeID);
                    updateCommand.Parameters.AddWithValue("@GameLevelID", question.GameLevelID);
                    updateCommand.Parameters.AddWithValue("@CategoryID", question.CategoryID);
                    updateCommand.Parameters.AddWithValue("@Description", question.Description);
                    updateCommand.Parameters.AddWithValue("@OptionA", question.OptionA);
                    updateCommand.Parameters.AddWithValue("@OptionB", question.OptionB);
                    updateCommand.Parameters.AddWithValue("@OptionC", question.OptionC);
                    updateCommand.Parameters.AddWithValue("@OptionD", question.OptionD);
                    updateCommand.Parameters.AddWithValue("@Explanation", question.Explanation);
                    updateCommand.Parameters.AddWithValue("@CorrectOption", question.CorrectOption);

                    updateCommand.ExecuteNonQuery();
                    return true;
                }
            }
        }

        /// <summary>
        /// Method that returns the quiz question
        /// </summary>
        /// <param name="questionid">question id</param>
        /// <returns>Question object</returns>
        public Question GetQuizQuestion(int gameId, int questionNumber)
        {
            Question question = new Question();



            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();


                using (SqlCommand selectCommand = new SqlCommand("GetGameQuestion", connection))
                {
                    selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    if (gameId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@gameId", gameId);
                    }

                    if (questionNumber > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@questionNumber", questionNumber);
                    }



                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            question.QuestionID = Convert.ToInt32(reader["ID"].ToString());
                            question.Description = reader["Description"].ToString();
                            question.OptionA = reader["OptionA"].ToString();
                            question.OptionB = reader["OptionB"].ToString();
                            question.OptionC = reader["OptionC"].ToString();
                            question.OptionD = reader["OptionD"].ToString();
                            question.CorrectOption = reader["Correct_Option"].ToString();


                        }
                    }
                }
            }

            return question;
        }

        /// <summary>
        /// Method that returns the quiz question
        /// </summary>
        /// <param name="questionid">question id</param>
        /// <returns>Question object</returns>
        public int InsertQuizQuestion(int userId, int total_questions, int categoryId, int AgeGroupId)
        {


            int gameId = 0;
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();


                using (SqlCommand selectCommand = new SqlCommand("InsertQuizGameDetails", connection))
                {
                    selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    if (userId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@UserId", userId);
                    }

                    if (total_questions > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@Total_questions", total_questions);
                    }

                    if (categoryId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                    }

                    if (AgeGroupId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@AgeGroupId", AgeGroupId);
                    }


                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            gameId = Convert.ToInt32(reader["gameId"].ToString());

                        }
                    }
                }
            }

            return gameId;
        }

        /// <summary>
        /// Method that returns the quiz question
        /// </summary>
        /// <param name="questionid">question id</param>
        /// <returns>Question object</returns>
        public string UpdateUserQuestionAnswer(int gameId, int questionId, string userOption)
        {
            string useranswer = "";



            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();


                using (SqlCommand selectCommand = new SqlCommand("UpdateUserQuestionAnswer", connection))
                {
                    selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    if (gameId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@gameId", gameId);
                    }

                    if (questionId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@questionId", questionId);
                    }


                    selectCommand.Parameters.AddWithValue("@userOption", userOption);




                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            useranswer = reader["userOption"].ToString();

                        }
                    }
                }
            }

            return useranswer;
        }

        /// <summary>
        /// Adds a new question to the Questions table of the database using a parameterized query.
        /// </summary>
        /// <param name="question">Question object with required properties added to the DB</param>
        public static bool AddQuestion(Question question)
        {

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                //INSERT INTO Questions (Age_range_id, Game_Level_ID, Category_ID, Description,
                //OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES 
                string insertStatement =
               "INSERT INTO questions " +
                "(Age_range_id, Game_Level_ID, Category_ID, Description, OptionA, OptionB, OptionC, OptionD, Explanation" +
                "Correct_Option) " +

                "VALUES (@AgeRangeId, @GameLevelID, @CategoryID, " +
                "@Description, @OptionA, @OptionB, " +
                "@OptionC, @OptionD, @Explanation, @CorrectOption ); " +
                "SELECT CAST(scope_identity() AS int)";

                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AgeRangeId", question.AgeRangeID);
                    insertCommand.Parameters.AddWithValue("@GameLevelID", question.GameLevelID);
                    insertCommand.Parameters.AddWithValue("@CategoryID", question.CategoryID);
                    insertCommand.Parameters.AddWithValue("@Description", question.Description);
                    insertCommand.Parameters.AddWithValue("@OptionA", question.OptionA);
                    insertCommand.Parameters.AddWithValue("@OptionB", question.OptionB);
                    insertCommand.Parameters.AddWithValue("@OptionC", question.OptionC);
                    insertCommand.Parameters.AddWithValue("@OptionD", question.OptionD);
                    insertCommand.Parameters.AddWithValue("@Explanation", question.Explanation);
                    insertCommand.Parameters.AddWithValue("@CorrectOption", question.CorrectOption);
                    question.QuestionID = Convert.ToInt32(insertCommand.ExecuteScalar());

                    return true;
                }
            }

        }

        /// <summary>
        /// Method to retrieve a list of questionIDs that correspond with the players favorited question list
        /// </summary>
        /// <param name="userID">the user whos favorites are being pulled</param>
        /// <returns>an integer list of all favorited questions</returns>
        public List<int> GetFavoritesList(int userID)
        {
            List<int> favList = new List<int>();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string sqlStatement = "SELECT questionId FROM UserFavorites " +
                    "WHERE userId = @userID";

                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userId", userID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            favList.Add((int)reader["questionId"]);
                        }
                    }
                    return favList;
                }


            }


        }

        /// <summary>
        /// Adds a user/question value pair to the favorites table, indicating the user has favorited this question
        /// </summary>
        /// <param name="userID">logged in user</param>
        /// <param name="questionID">the current question they are favoriting</param>
        /// <returns>true when the query succeeds</returns>
        public bool AddQuestionToFavorites(int userID, int questionID)
        {

            using (SqlConnection connection = DBConnection.GetConnection())
            {

                string insertStatement =
               "INSERT INTO UserFavorites " +
               "VALUES (@userId, @questionID)";
                

                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@userId", userID);
                    insertCommand.Parameters.AddWithValue("@questionID", questionID);
                    int result = insertCommand.ExecuteNonQuery();

                    // Check Error
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public bool RemoveQuestionFromFavorites(int userID, int questionID)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {

                string deleteStatement =
               "DELETE FROM UserFavorites " +
               "WHERE userId = @userId " +
               "AND questionId = @questionID";


                connection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@userId", userID);
                    deleteCommand.Parameters.AddWithValue("@questionID", questionID);
                    int result = deleteCommand.ExecuteNonQuery();

                    // Check Error
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }


        }


    }
}
