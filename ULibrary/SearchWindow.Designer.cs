namespace ULibrary
{
    partial class SearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindow));
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.radioTitle = new MetroFramework.Controls.MetroRadioButton();
            this.radioAuthor = new MetroFramework.Controls.MetroRadioButton();
            this.radioGenre = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            // 
            // 
            // 
            this.searchBox.CustomButton.Image = null;
            this.searchBox.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.searchBox.CustomButton.Name = "";
            this.searchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.searchBox.CustomButton.TabIndex = 1;
            this.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchBox.CustomButton.UseSelectable = true;
            this.searchBox.CustomButton.Visible = false;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(54, 191);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(184, 26);
            this.searchBox.TabIndex = 0;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Location = new System.Drawing.Point(208, 61);
            this.radioTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(46, 15);
            this.radioTitle.TabIndex = 1;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseSelectable = true;
            this.radioTitle.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChange);
            // 
            // radioAuthor
            // 
            this.radioAuthor.AutoSize = true;
            this.radioAuthor.Location = new System.Drawing.Point(208, 97);
            this.radioAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioAuthor.Name = "radioAuthor";
            this.radioAuthor.Size = new System.Drawing.Size(60, 15);
            this.radioAuthor.TabIndex = 2;
            this.radioAuthor.TabStop = true;
            this.radioAuthor.Text = "Author";
            this.radioAuthor.UseSelectable = true;
            this.radioAuthor.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChange);
            // 
            // radioGenre
            // 
            this.radioGenre.AutoSize = true;
            this.radioGenre.Location = new System.Drawing.Point(208, 132);
            this.radioGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioGenre.Name = "radioGenre";
            this.radioGenre.Size = new System.Drawing.Size(54, 15);
            this.radioGenre.TabIndex = 3;
            this.radioGenre.TabStop = true;
            this.radioGenre.Text = "Genre";
            this.radioGenre.UseSelectable = true;
            this.radioGenre.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.Location = new System.Drawing.Point(54, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioGenre);
            this.Controls.Add(this.radioAuthor);
            this.Controls.Add(this.radioTitle);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWindow";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SearchWindow";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox searchBox;
        private MetroFramework.Controls.MetroRadioButton radioTitle;
        private MetroFramework.Controls.MetroRadioButton radioAuthor;
        private MetroFramework.Controls.MetroRadioButton radioGenre;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}