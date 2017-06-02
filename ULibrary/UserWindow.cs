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
        private User user;

        public UserWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            this.user.Debt = CalculateDebt(this.user);
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
                booksGrid.Rows.Add(book.ID, book.Title, book.Author, book.Genre);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchWindow swin = new SearchWindow();
            swin.ShowDialog();
            addBooksToGrid(DB.SearchBooksBy(swin.SearchText, swin.RadioChecked));
        }

        private void booksGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = (int)booksGrid.Rows[e.RowIndex].Cells[0].Value;
                var book = DB.GetBookByID(id);
                BookWindow bwin = new BookWindow(user, book);
                bwin.ShowDialog();
            }
        }

        private uint CalculateDebt(User user)
        {
            var userbooks = DB.GetNotReturnedUserBooks(user.ID);
            uint debt = 0;
            foreach (var userbook in userbooks)
            {
                if (DateTime.Today.CompareTo(userbook.EndDate) > 0)
                {
                    debt += (uint)(DateTime.Today - userbook.EndDate).Days * 100;
                }

            }
            return debt;
        }
    }
}
