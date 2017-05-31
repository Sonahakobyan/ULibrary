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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.radioAuthor = new System.Windows.Forms.RadioButton();
            this.radioGenre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(5, 96);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(124, 20);
            this.searchBox.TabIndex = 0;
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Location = new System.Drawing.Point(108, 12);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(45, 17);
            this.radioTitle.TabIndex = 1;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            this.radioTitle.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChange);
            // 
            // radioAuthor
            // 
            this.radioAuthor.AutoSize = true;
            this.radioAuthor.Location = new System.Drawing.Point(108, 35);
            this.radioAuthor.Name = "radioAuthor";
            this.radioAuthor.Size = new System.Drawing.Size(56, 17);
            this.radioAuthor.TabIndex = 2;
            this.radioAuthor.TabStop = true;
            this.radioAuthor.Text = "Author";
            this.radioAuthor.UseVisualStyleBackColor = true;
            this.radioAuthor.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChange);
            // 
            // radioGenre
            // 
            this.radioGenre.AutoSize = true;
            this.radioGenre.Location = new System.Drawing.Point(108, 58);
            this.radioGenre.Name = "radioGenre";
            this.radioGenre.Size = new System.Drawing.Size(54, 17);
            this.radioGenre.TabIndex = 3;
            this.radioGenre.TabStop = true;
            this.radioGenre.Text = "Genre";
            this.radioGenre.UseVisualStyleBackColor = true;
            this.radioGenre.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(1, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioGenre);
            this.Controls.Add(this.radioAuthor);
            this.Controls.Add(this.radioTitle);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWindow";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton radioTitle;
        private System.Windows.Forms.RadioButton radioAuthor;
        private System.Windows.Forms.RadioButton radioGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}