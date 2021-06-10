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

            //string connectionString =
            //     "Server = tcp:cs6920.database.windows.net,1433; Initial Catalog = CS6920 - Team4; Persist Security Info = False; User ID = cs6920; Password =P@ssw0rd; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
           


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
