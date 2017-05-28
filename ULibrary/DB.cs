using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ULibrary
{
    static class DB
    {
        private static DBConnection db;

        static DB()
        {
            db = DBConnection.Instance;
        }

        public static ArrayList Login(string username, string password)
        {
            if (db.IsConnect())
            {
                string query = "SELECT id,FirstName,LastName,Type FROM users WHERE username=@username and password=@password";
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", CalculateMD5Hash(password));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ArrayList user = new ArrayList
                            {
                                reader.GetInt32(0),
                                reader["FirstName"],
                                reader["LastName"],
                                reader["Type"]
                            };
                            return user;
                        }

                    }
                }
            }
            return null;
        }

        private static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            var md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            // step 3, return string
            return sb.ToString();
        }

        public static void Close()
        {
            db.Close();
        }

    }
}
