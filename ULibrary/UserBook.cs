using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULibrary
{
    class UserBook
    {
        public int ID { get;}
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IsReturn { get; set; }

        public User User
        {
            get
            {
                return DB.GetUserByID(UserID);
            }
        }

        public Book Book
        {
            get
            {
                return DB.GetBookByID(BookID);
            }
        }

        public UserBook(int userId,int bookId,DateTime startDate,DateTime endDate,int isReturn,int id = 0)
        {
            ID = id;
            UserID = userId;
            BookID = bookId;
            StartDate = startDate;
            EndDate = endDate;
            IsReturn = isReturn;
        }
    }
}
