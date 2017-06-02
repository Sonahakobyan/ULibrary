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

        private uint CalculateDebtOfBook(UserBook userbook)
        {
                if (DateTime.Today.CompareTo(userbook.EndDate) > 0)
                {
                    return (uint)(DateTime.Today - userbook.EndDate).Days * 100;
                }
            return 0;
        }

        private void addBooksToTakenBooksGrid(List<UserBook> userbooks)
        {
            takenBooksGrid.Rows.Clear();
            foreach (var userbook in userbooks)
            {
                if (userbook.ReturnDate == null)
                {
                    Book book = DB.GetBookByID(userbook.BookID);


                    var index = takenBooksGrid.Rows.Add(userbook.ID, book.Title, book.Author, userbook.StartDate.ToString("dd-MM-yyyy"), userbook.EndDate.ToString("dd-MM-yyyy"), CalculateDebtOfBook(userbook));
                    var row = takenBooksGrid.Rows[index];
                    if((DateTime.Today - userbook.EndDate).Days >= 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if ((userbook.EndDate - DateTime.Today).Days <= 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }

                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tb = sender as TabControl;
            if(tb.SelectedTab == takenTab)
            {
                    addBooksToTakenBooksGrid(DB.GetNotReturnedUserBooks(user.ID));
            }
            else if(tb.SelectedTab == booksTab)
            {
                addBooksToGrid(DB.GetAllBooks());
            }
        }

        private void takenBooksGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = (int)booksGrid.Rows[e.RowIndex].Cells[0].Value;
                var book = DB.GetBookByID(id);
                BookWindow bwin = new BookWindow(user, book);
                bwin.ShowDialog();
            }
        }
    }
}
