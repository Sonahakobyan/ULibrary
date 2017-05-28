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
    public partial class AdminWindow : Form
    {
        private int userID;

        public AdminWindow(int userId)
        {
            InitializeComponent();
            this.userID = userID;
        }
    }
}
