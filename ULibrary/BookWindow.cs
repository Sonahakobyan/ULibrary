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

        public BookWindow(int userId, Book book)
        {
            InitializeComponent();
            this.titleLabel.Text = book.Title;
            this.authorLabel.Text = book.Author;
            this.genreLabel.Text = book.Genre;
            this.descriptionLabel.Text = book.Description;
            this.user = DB.GetUserByID(userId);
            if (user.Debt == 0) this.borrowButton.Enabled = true;
            else this.debtLabel.Visible = true;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
