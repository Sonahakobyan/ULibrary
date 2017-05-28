using System;
using MySql.Data.MySqlClient;

namespace ULibrary
{
    class DBConnection
    {
        //DataBase Connection
        public MySqlConnection Connection { get; set; }

        //DataBase Instance
        private static DBConnection _instance;

        //Instance
        public static DBConnection Instance
        {
            get { return _instance ?? (_instance = new DBConnection()); }
        }

        //Constructor (No Need to Call)
        private DBConnection()
        {
        }

        //If has connection return it else create it
        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(Config.DBName))
                    result = false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Config.DBHost, Config.DBName, Config.DBUsername, Config.DBPassword);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
                result = true;
            }

            return result;
        }

        //Close connection
        public void Close()
        {
            if (Connection != null)
                Connection.Close();
        }
    }
}
