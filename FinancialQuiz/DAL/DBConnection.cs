using System.Data.SqlClient;

namespace FinancialQuiz.DAL
{
    class DBConnection
    {
        /// <summary>
        /// The static getConnection for database connection
        /// </summary>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=CS6920-Team4;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
