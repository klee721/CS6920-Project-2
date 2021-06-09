using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using FinancialQuiz.Model;

namespace FinancialQuiz.DAL
{
    /// <summary>
    /// DAL class responsible for interacting with the Users table of the database
    /// </summary>
    public class UserDAL
    {

        public List<User> UserLogin(string username, string password)
        {
            List<User> loggedInUser = new List<User>();

            string selectStatement = "SELECT ID, LastName, FirstName, Age, UserName, passwordHash, Admin_ind from Users " +
                "WHERE userName = @name " +
                "AND passwordHash = @password";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    Byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(password);
                    SHA512 shaM = new SHA512Managed();
                    Byte[] hashedBytes = shaM.ComputeHash(inputBytes);


                    selectCommand.Parameters.AddWithValue("@name", username);
                    selectCommand.Parameters.AddWithValue("@password", hashedBytes);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int IDOrd = reader.GetOrdinal("ID");
                            int AgeOrd = reader.GetOrdinal("Age");

                            User user = new User();

                            user.UserID = reader.GetInt32(IDOrd);
                            user.LastName = reader["LastName"].ToString();
                            user.FirstName = reader["FirstName"].ToString();
                            user.Age = reader.GetInt32(AgeOrd);
                            user.UserName = reader["UserName"].ToString();
                            user.AdminInd = reader["Admin_ind"].ToString();
                            loggedInUser.Add(user);
                        }
                    }
                }
            }
            return loggedInUser;
        }
    }
}

