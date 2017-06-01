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

        public static bool Register(string FirstName, string LastName, string Username, string Password)
        {
            if (FirstName != "" && LastName != "" && Username != "" & Password != "" && db.IsConnect())
            {
                string query = "INSERT INTO `users`(`FirstName`, `LastName`, `Username`, `Password`, `Type`) VALUES(@FirstName, @LastName, @Username, @Password, 'User')";
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", CalculateMD5Hash(Password));
                    if (cmd.ExecuteNonQuery() >= 1)
                        return true;
                }
            }
            return false;
        }

        public static List<Book> GetAllBooks()
        {
            if(db.IsConnect())
            {
                List<Book> books = new List<Book>();
                string query = "SELECT id,Title,Author,Genre FROM `books`";
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book((string)reader["Title"], (string)reader["Author"], (string)reader["Genre"], reader.GetInt32(0)));
                        }  
                    }
                }
                return books;
            }
            return null;
        }

        public static Book GetBookByID(int id)
        {
            if (db.IsConnect())
            {
                string query = "SELECT * FROM `books` WHERE id=@id";
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Book((string)reader["Title"], (string)reader["Author"], (string)reader["Genre"], reader.GetInt32(0), (string)reader["Description"]);
                        }
                    }
                }
            }
            return null;
        }

        public static List<Book> SearchBooksBy(string searched, string searchby)
        {
            if (db.IsConnect())
            {
                string query = "";
                switch (searchby)
                {
                    case "radioTitle":
                        query = "SELECT id,Title,Author,Genre FROM `books` WHERE `Title` COLLATE UTF8_UNICODE_CI LIKE @searched";
                        break;
                    case "radioAuthor":
                        query = "SELECT id,Title,Author,Genre FROM `books` WHERE `Author` COLLATE UTF8_UNICODE_CI LIKE @searched";
                        break;
                    case "radioGenre":
                        query = "SELECT id,Title,Author,Genre FROM `books` WHERE `Genre` COLLATE UTF8_UNICODE_CI LIKE @searched";
                        break;
                    default:
                        query = "SELECT id,Title,Author,Genre FROM `books` WHERE `Title` COLLATE UTF8_UNICODE_CI LIKE @searched";
                        break;
                }
                List<Book> books = new List<Book>();
                using (var cmd = new MySqlCommand(query,db.Connection))
                {
                    cmd.Parameters.AddWithValue("@searched","%"+searched+"%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book((string)reader["Title"], (string)reader["Author"], (string)reader["Genre"], reader.GetInt32(0)));
                        }
                    }
                }
                return books;
            }
            return null;
        }

        public static User GetUserByID(int id)
        {
            if (db.IsConnect())
            {
                string query = "SELECT * FROM `users` WHERE id=@id";
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User((string)reader["FirstName"], (string)reader["LastName"], (string)reader["Username"], (string)reader["Password"], (string)reader["Type"],reader.GetInt32(0), (uint)reader.GetInt32("Debt"));
                        }
                    }
                }
            }
            return null;
        }
        public static UserBook GetNotReturnedUserBook(int userID, int bookID)
        {
            if (db.IsConnect())
            {
                string query = "SELECT * FROM `user_books` WHERE user_id=@userid AND book_id=@bookid AND is_return=0";
                using (var cmd = new MySqlCommand(query,db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userid",userID);
                    cmd.Parameters.AddWithValue("@bookid",bookID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserBook((int)reader.GetInt32("user_id"), (int)reader.GetInt32("book_id"), (DateTime)reader["start_date"], (DateTime)reader["end_date"], (int)reader.GetInt32("is_return"));
                        }
                    }
                }
            }
            return null;
        }

        public static bool BorrowBook(UserBook book)
        {
            if (db.IsConnect())
            {
                string query = "INSERT INTO `user_books`(`user_id`, `book_id`, `start_date`, `end_date`,`is_return`) VALUES(@UserID, @BookID, @StartDate, @EndDate, 0)";
                using (var cmd = new MySqlCommand(query,db.Connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", book.UserID);
                    cmd.Parameters.AddWithValue("@BookID", book.BookID);
                    cmd.Parameters.AddWithValue("@StartDate", book.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", book.EndDate);
                    if (cmd.ExecuteNonQuery() >= 1)
                        return true;
                }
            }
            return false;
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
