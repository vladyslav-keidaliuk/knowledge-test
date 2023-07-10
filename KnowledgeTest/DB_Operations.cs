using System;
using MySql.Data.MySqlClient;

namespace KnowledgeTest
{
    public class DB_Operations
    {   
        private static string connectionString = 
            "server=YOUR;uid=YOUR_ID;pwd=YOUR_PASSWORD;database=YOUR_DB";

        public static void Add_User_to_DB(string fio, string login, string password, string email)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                
                string sql = "INSERT INTO Users (FIO, Login,Password,Email,Score)" +
                             $"VALUES ('{fio}','{login}','{password}','{email}','-1');";
                MySqlCommand command = new MySqlCommand(sql, conn);
                
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("Error");
            }
        }
        public static bool IsLoginExists(string login)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM users WHERE Login = @login";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@login", login);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (MySqlException)
            {
                Console.WriteLine("Error");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static int GetScore(string login, string password)
        {
            int score = 0;
            string query = $"SELECT Score FROM Users WHERE Login = @login AND Password = @password";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                score = Convert.ToInt32(result.ToString());
            }

            return score;
        }
        public static string GetFIO(string login, string password)
        {
            string fio = string.Empty;
            
            string query = $"SELECT FIO FROM Users WHERE Login = @login AND Password = @password";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                fio = result.ToString();
            }
            return fio;
        }
        public static string GetTopUsers()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT FIO, Login, Score " +
                             "FROM users " +
                             "WHERE Score > -1 " +
                             "ORDER BY Score DESC " +
                             "LIMIT 5";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();

                int counter = 1;
                string result = string.Empty;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string fio = reader.GetString("FIO");
                        string login = reader.GetString("Login");
                        int score = reader.GetInt32("Score");

                        result += $"{counter}. {fio} - {score} балів\n";
                        counter++;
                    }
                    return result;
                }
                else
                {
                    return "Топ ще не сформовано.";
                }
            }
            catch (MySqlException)
            {
                Console.WriteLine("Error");
                return string.Empty;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void UpdateScore(int score, string login, string password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            connection.Open();

            string query = "UPDATE users SET Score = @Score WHERE Login = @Login AND Password = @Password";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Score", score);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                command.ExecuteNonQuery();
            }
        }
        public static string GetEmail(string login, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Email FROM users WHERE Login = @Login AND Password = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
               
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
                
            }
        }
        public static string[] GetTaskByNumber(int number)
        {
            string[] taskData = new string[9]; 
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Tasks WHERE Number = @Number";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Number", number);
            MySqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                for (int i = 0; i < 9; i++)
                {
                    taskData[i] = reader[i].ToString();
                }
            }
            
            return taskData;
        }

        
        
        
    }
}