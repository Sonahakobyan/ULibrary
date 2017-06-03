using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULibrary
{
    public class User
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public uint Debt { get; set; }
        public uint Money { get; set; }
        public uint Purchased { get; set; }
        private string _password;
        public string Password
        {
            get
            {
                throw new Exception("you can't get password");
            }
            set
            {
                this._password = value;
            }
        }

        public User(string firstName,string lastName,string username,string password, string type, int id = 0 , uint debt = 0, uint money = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Type = type;
            Debt = debt;
            Money = money;
            ID = id;
        }

        public bool Update()
        {
            return DB.UpdateUser(this);
        }
    }
}
