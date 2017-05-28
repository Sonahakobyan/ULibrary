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
            var user = DB.Login(this.Username.Text, this.Password.Text);
            if(user != null)
            {
                MessageBox.Show(string.Format("Hello {0} {1}", user[1], user[2]), "Successfull", MessageBoxButtons.OK);
                if((string)user[3] == "Admin")
                {
                    AdminWindow win = new AdminWindow((int)user[0]);
                    win.Show();
                    this.Close();
                }
                else
                {
                    UserWindow win = new UserWindow((int)user[0]);
                    win.Show();
                    this.Close();
                }
            }
        }
    }
}
