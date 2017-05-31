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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = DB.Login(this.Username.Text.Trim(), this.Password.Text.Trim());
            if(user != null)
            {
                MessageBox.Show(string.Format("Hello {0} {1}", user[1], user[2]), "Successfull", MessageBoxButtons.OK);
                if((string)user[3] == "Admin")
                {
                    AdminWindow win = new AdminWindow((int)user[0]);
                    this.Hide();
                    win.ShowDialog();
                    this.Close();
                }
                else
                {
                    UserWindow win = new UserWindow((int)user[0]);
                    this.Hide();
                    win.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username.Clear();
                Password.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DB.Register(signUpFName.Text.Trim(), signUpLName.Text.Trim(), signUpUsername.Text.Trim(), signUpPassword.Text.Trim()))
            {
                MessageBox.Show("Now you can Login", "Successfull", MessageBoxButtons.OK);
                signUpFName.Clear();
                signUpLName.Clear();
                signUpUsername.Clear();
                signUpPassword.Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signUpPassword.Clear();
            }
        }
    }
}
