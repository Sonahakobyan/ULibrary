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

namespace ULibrary
{
    public partial class SearchWindow : MetroForm
    {
        public string SearchText;
        public string RadioChecked;

        public SearchWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.searchBox.Text != "" && (this.radioAuthor.Checked != false || this.radioGenre.Checked != false || this.radioTitle.Checked != false))
            {
                this.SearchText = this.searchBox.Text;
                this.Close();
            }
        }

        private void radioButtons_CheckedChange(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb != null && rb.Checked == true)
            {
                this.RadioChecked = rb.Name;
            }

        }
    }
}
