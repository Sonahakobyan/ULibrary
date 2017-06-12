using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Fonts;

namespace ULibrary
{
    public partial class AdminWindow : MetroForm
    {
        private User user;

        public AdminWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            addBooksToGrid(DB.GetAllBooks());
        }

        private void addBooksToGrid(List<Book> books)
        {
            booksGrid.Rows.Clear();
            foreach (var book in books)
            {
                booksGrid.Rows.Add(book.ID, book.Title, book.Author, book.Genre, "Delete");
            }
        }

        private void addUserBooksToGrid(List<UserBook> userbooks)
        {
            userBookGrid.Rows.Clear();
            foreach (var userbook in userbooks)
            {
                userBookGrid.Rows.Add(userbook.ID, userbook.Book.Title, userbook.User.Username, userbook.StartDate, userbook.EndDate, userbook.ReturnDate != null ? ((DateTime)userbook.ReturnDate).ToString("dd-MM-yyyy") : "Not Returned");
            }
        }



        private void booksGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var send = sender as DataGridView;
            
            if (send.Columns[e.ColumnIndex] == deleteColumn && e.RowIndex > -1 && send.Rows[e.RowIndex].Cells["idColumn"].Value != null )
            {
                if(DB.DeleteBookByID((int)send.Rows[e.RowIndex].Cells["idColumn"].Value))
                {
                    MessageBox.Show("Book Deleted Successfully");
                    addBooksToGrid(DB.GetAllBooks());
                }
                else
                {
                    MessageBox.Show("Cannot Delete Book, something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleText.Text == "" || authorText.Text == "" || genreText.Text == "" || descriptionText.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Book book = new Book(titleText.Text, authorText.Text, genreText.Text, description:descriptionText.Text);
            if (DB.AddBook(book))
            {
                MessageBox.Show("Book Added Successfully!");
                addBooksToGrid(DB.GetAllBooks());
            }
            else
                MessageBox.Show("Cannot Add Book, something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tb = sender as TabControl;
            if (tb.SelectedTab == booksTab)
            {
                addBooksToGrid(DB.GetAllBooks());
            }
            else if(tb.SelectedTab == bookHistoryTab)
            {
                addUserBooksToGrid(DB.GetUserBooks());
            }
            else if(tb.SelectedTab == financeTab)
            {
                moneyLabel.Text = DB.GetAllDebt().ToString();
                debtLabel.Text = DB.GetAllUsersDebt().ToString();
            }
        }
    }
}
