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


        /// <summary>
        /// Method that returns the selected user from the user table
        /// </summary>
        /// <param name="name">first name last name</param>
        /// <param name="username">username of the user</param>
        /// <param name="userid">user id</param>
        /// <returns>User object</returns>
        public List<User> GetUsers(string name, string username, int userid)
        {
            List<User> userList = new List<User>();

            string sqlStatement = "SELECT ID, LastName, FirstName, Age, UserName, passwordHash, Admin_ind from Users ";


            if (name != null && name.Length > 0)
            {
                sqlStatement += "where concat(FirstName, ' ', LastName) = @Name";
            }
            
            else if (userid > 0)
            {
                sqlStatement += "where ID = @UserID";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    if (name != null && name.Length > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@Name", name);
                    }
                   
                    else if (userid > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@UserID", userid);
                    }

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();

                            user.UserID = Convert.ToInt32(reader["ID"].ToString());
                            user.LastName = reader["LastName"].ToString();
                            user.FirstName = reader["FirstName"].ToString();
                            user.Age = Convert.ToInt32(reader["Age"].ToString());
                            user.UserName = reader["UserName"].ToString();
                            user.Password = reader["passwordHash"].ToString();
                            user.AdminInd = reader["Admin_ind"].ToString();
                        
                            userList.Add(user);
                        }
                    }
                }
            }

            return userList;
        }

    }
}

