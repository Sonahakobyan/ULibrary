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
                BookWindow bwin = new BookWindow(userID, book);
                bwin.ShowDialog();
            }
        }
    }
}
