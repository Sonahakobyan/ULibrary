using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace ULibrary
{
    public partial class UserWindow : MetroForm
    {
        private User user;

        public UserWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            this.user.Debt = CalculateDebt(this.user);
            this.user.Update();
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
                Book book = DB.GetBookByID(userbook.BookID);
                var index = takenBooksGrid.Rows.Add(userbook.ID, book.Title, book.Author, userbook.StartDate.ToString("dd-MM-yyyy"), userbook.EndDate.ToString("dd-MM-yyyy"), CalculateDebtOfBook(userbook));
                var row = takenBooksGrid.Rows[index];
                if ((DateTime.Today - userbook.EndDate).Days >= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if ((userbook.EndDate - DateTime.Today).Days <= 3)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tb = sender as TabControl;
            if (tb.SelectedTab == takenTab)
            {
                addBooksToTakenBooksGrid(DB.GetNotReturnedUserBooks(user.ID));
            }
            else if (tb.SelectedTab == booksTab)
            {
                addBooksToGrid(DB.GetAllBooks());
            }
            else if (tb.SelectedTab == historyTab)
            {
                addBooksToHistoryGrid(DB.GetReturnedUserBooks(user.ID));
            }
            else if (tb.SelectedTab == paymentsTab)
            {
                money.Text = user.Money.ToString();
                debt.Text = user.Debt.ToString();
                updatePayments(user);
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
                addBooksToTakenBooksGrid(DB.GetNotReturnedUserBooks(user.ID));
            }
        }
        private void addBooksToHistoryGrid(List<UserBook> userbooks)
        {
            historyGrid.Rows.Clear();
            foreach (var userbook in userbooks)
            {
                Book book = DB.GetBookByID(userbook.BookID);
                historyGrid.Rows.Add(userbook.ID, book.Title, book.Author, userbook.StartDate.ToString("dd-MM-yyyy"), userbook.ReturnDate.Value.ToString("dd-MM-yyyy"));
            }
        }

        private void updatePayments(User user)
        {
            money.Text = user.Money.ToString();
            debt.Text = user.Debt.ToString();
            payTextBox.Clear();
            addTextBox.Clear();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (payTextBox.Text != null)
            {
                uint value;
                if (uint.TryParse(payTextBox.Text, out value))
                {
                    if (user.Debt < value)
                    {
                        MetroMessageBox.Show(this, "Please don't give us tipp");
                        return;
                    }
                    else  if (user.Debt != UInt32.MinValue )
                    {
                        if (user.Money >= value)
                        {
                            if (DB.AddToDebt(value) == null)
                            {
                                MetroMessageBox.Show(this, "Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            user.Money -= value;
                            user.Debt -= value;
                            user.Update();
                            MetroMessageBox.Show(this, string.Format("Thank you for your {0} payment!", value), "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updatePayments(user);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Sorry, you don't have enough money in your account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            payTextBox.Clear();
                        }
                    }
                    
                    else
                    {
                        MetroMessageBox.Show(this, "No Debt");
                        updatePayments(user);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addTextBox.Text != null)
            {
                uint value;
                if (uint.TryParse(addTextBox.Text, out value))
                {
                    user.Money += value;
                    user.Update();
                    MetroMessageBox.Show(this, "Thank you, the money has been successfully added!");
                    addTextBox.Clear();
                    money.Text = user.Money.ToString();
                }
            }
        }

        private void payTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void addTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
