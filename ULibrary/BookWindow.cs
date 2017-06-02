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
    public partial class BookWindow : Form
    {
        private User user;
        private Book book;

        public BookWindow(User user, Book book)
        {
            InitializeComponent();
            this.titleLabel.Text = book.Title;
            this.authorLabel.Text = book.Author;
            this.genreLabel.Text = book.Genre;
            this.descriptionLabel.Text = book.Description;
            this.user = user;
            this.book = book;
            UserBook user_book = DB.GetNotReturnedUserBook(user.ID, book.ID);
            if (user_book != null)
            {
                this.debtLabel.Text = String.Format("You have already borrowed this book from {0} to {1}", user_book.StartDate.ToString("dd-MM-yyyy"), user_book.EndDate.ToString("dd-MM-yyyy"));
            }
            else
            {
                if (user.Debt == 0)
                {
                    this.debtLabel.Text = "Borrow from today to: ";
                    this.end_dateTime.Visible = true;
                    this.end_dateTime.MinDate = DateTime.Today.AddDays(1);
                    this.end_dateTime.MaxDate = DateTime.Today.AddDays(30);
                    this.borrowButton.Enabled = true;
                }
                else
                {
                    this.debtLabel.Text = "You have to pay your debt";
                }
            }
            
        }

        
        private void borrowButton_Click(object sender, EventArgs e)
        {
            var start_time = DateTime.Today;
            var end_time = this.end_dateTime.Value;
            var book = new UserBook(this.user.ID, this.book.ID, start_time, end_time, null);
            if (DB.BorrowBook(book))
            {
                this.borrowButton.Enabled = false;
                MessageBox.Show("You have borrowed this book!");
            }
            else
                MessageBox.Show("Error!");
        }

    }
}
