﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULibrary
{
    class User
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public uint Debt { get; set; }
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

        public User(string firstName,string lastName,string username,string password, string type, int id = 0 ,uint debt = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Type = type;
            Debt = debt;
            ID = id;
        }
    }
}