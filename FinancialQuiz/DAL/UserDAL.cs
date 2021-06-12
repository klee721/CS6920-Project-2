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
        /// <summary>
        /// Public method to find a PLAYER user from the Users table by username and password
        /// </summary>
        /// <param name="username">the entered username</param>
        /// <param name="password">the entered password</param>
        /// <returns></returns>
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
        /// Public method to find an ADMIN user from the Users table by username and password
        /// </summary>
        /// <param name="username">the entered username</param>
        /// <param name="password">the entered password</param>
        /// <returns></returns>
        public List<User> AdminLogin(string username, string password)
        {
            List<User> loggedInUser = new List<User>();

            string selectStatement = "SELECT ID, LastName, FirstName, Age, UserName, passwordHash, Admin_ind from Users " +
                "WHERE userName = @name " +
                "AND passwordHash = @password " +
                "AND Admin_ind = 'Y'";


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
            else if (username != null && username.Length > 0)
            {
                sqlStatement += "where UserName = @Username";
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
                    else if (username != null && username.Length > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@Username", username);
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

        /// <summary>
        /// Adds a new user to the Users table of the database using a parameterized query.
        /// </summary>
        /// <param name="user">User object with required properties added to the DB</param>
        public static bool RegisterUser(User user)
        {
            var convertedPassword = System.Text.Encoding.UTF8.GetBytes(user.Password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(convertedPassword);


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string insertStatement =
               "INSERT INTO users " +
                "(LastName, FirstName, Age, UserName, passwordHash, Admin_ind) " +

                "VALUES (@last_name, @first_name, @age, @username,  @password, @admin_status); " +
                "SELECT CAST(scope_identity() AS int)";


                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@last_name", user.LastName);
                    insertCommand.Parameters.AddWithValue("@first_name", user.FirstName);
                    insertCommand.Parameters.AddWithValue("@age", user.Age);
                    insertCommand.Parameters.AddWithValue("@username", user.UserName);
                    insertCommand.Parameters.AddWithValue("@password", hashedBytes);
                    insertCommand.Parameters.AddWithValue("@admin_status", user.AdminInd);
                    user.UserID = Convert.ToInt32(insertCommand.ExecuteScalar());

                    return true;
                }
            }
        }
    }
}

