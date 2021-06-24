using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.Model;
using System.Data.SqlClient;

namespace FinancialQuiz.DAL
{
   public class CategoryDAL
    {
        /// <summary>
        /// Method to grab all categories in the DB with their ID, name and description
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategories()
        {

            List<Category> categoryList = new List<Category>();

            string sqlStatement = "SELECT * from Category ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Category newCategory = new Category();
                            newCategory.CategoryID = Convert.ToInt32(reader["ID"].ToString());
                            newCategory.Name = reader["Name"].ToString();
                            newCategory.Description = reader["Description"].ToString();

                            categoryList.Add(newCategory);
                        }
                    }
                }
            }

                    return categoryList;
        }



















    }
}
