using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULibrary
{
    public partial class UserWindow : Form
    {
        private int userID;

        public UserWindow(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            addBooksToGrid(DB.GetAllBooks());
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            addBooksToGrid(DB.GetAllBooks());
        }

        private void addBooksToGrid(List<Book> books)
        {
            booksGrid.Rows.Clear();
            foreach (var book in books)
            {
                booksGrid.Rows.Add(book.Title, book.Author, book.Genre);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchWindow swin = new SearchWindow();
            swin.ShowDialog();
            addBooksToGrid(DB.searchBooksBy(swin.SearchText, swin.RadioChecked));
        }
    }
}
