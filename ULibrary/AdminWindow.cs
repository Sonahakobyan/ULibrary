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
        private User user;

        public AdminWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
