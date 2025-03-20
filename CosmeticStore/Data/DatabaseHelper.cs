using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticStore.Data
{
    public class DatabaseHelper
    {
        private const string connectionString = "server=localhost;Port=3306;Database=shop_management;user=root;Password=;AllowPublicKeyRetrieval=True;SslMode=none;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestDatabaseConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("Database connected successfully!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection failed: " + ex.Message);
                return false;
            }
        }
    }
}
