using System;
using System.Collections.Generic;
using FinancialQuiz.Model;
using System.Data.SqlClient;

namespace FinancialQuiz.DAL
{
    public class AgeDAL
    {
        /// <summary>
        /// Method to grab and return all of the Age categories in the DB
        /// </summary>
        /// <returns></returns>
        public List<Age> GetAllAges()
        {
            List<Age> ageList = new List<Age>();

            string sqlStatement = "SELECT * from Age_range ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Age newAge = new Age();
                            newAge.AgeID = Convert.ToInt32(reader["ID"].ToString());
                            newAge.Name = reader["Name"].ToString();
                            newAge.Description = reader["Description"].ToString();

                            ageList.Add(newAge);
                        }
                    }
                }
            }
            return ageList;

        }
    }
}
