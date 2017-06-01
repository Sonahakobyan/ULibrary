using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULibrary
{
    public class Book
    {
        public int ID { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

        public Book(string title,string author,string genre, int id = 0, string description = null)
        {
            ID = id;
            Title = title;
            Author = author;
            Genre = genre;
            Description = description;
        }

    }
}
