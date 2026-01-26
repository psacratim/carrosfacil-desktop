
using MySql.Data.MySqlClient;
using System.Data;

namespace CarrosFacil.Database
{
    class DbConnection
    {
        private static MySqlConnection connection = null;
        private static string connectionString = @"Persist Security Info=False; Server=localhost; Database=carrosfacil_ti50; uid=root; pwd='';";

        public static MySqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection();
                if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                }
            }

            return connection;
        }

        public static int ExecuteNonQuery(string sql, MySqlParameter[] parameters)
        {
            using (var conn = getConnection())
            {
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteSelect(string sql, MySqlParameter[] parameters = null)
        {
            using (var conn = getConnection())
            {
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    DataTable dt = new DataTable();
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }
    }
}
