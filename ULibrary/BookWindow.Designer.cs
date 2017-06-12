namespace ULibrary
{
    partial class BookWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookWindow));
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.Author = new MetroFramework.Controls.MetroLabel();
            this.authorLabel = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.genreLabel = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.borrowButton = new MetroFramework.Controls.MetroButton();
            this.debtLabel = new MetroFramework.Controls.MetroLabel();
            this.end_dateTime = new MetroFramework.Controls.MetroDateTime();
            this.returnButton = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title: ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(272, 148);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 19);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "text";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(166, 197);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(49, 19);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(272, 197);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(30, 19);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 751);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(272, 243);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(44, 19);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(272, 285);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(44, 19);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "label5";
            // 
            // borrowButton
            // 
            this.borrowButton.Enabled = false;
            this.borrowButton.Location = new System.Drawing.Point(171, 417);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(134, 43);
            this.borrowButton.TabIndex = 9;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseSelectable = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // debtLabel
            // 
            this.debtLabel.AutoSize = true;
            this.debtLabel.Location = new System.Drawing.Point(166, 365);
            this.debtLabel.Name = "debtLabel";
            this.debtLabel.Size = new System.Drawing.Size(251, 19);
            this.debtLabel.TabIndex = 10;
            this.debtLabel.Text = "You have debt, please pay in BookHistory";
            // 
            // end_dateTime
            // 
            this.end_dateTime.Location = new System.Drawing.Point(482, 355);
            this.end_dateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.end_dateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.end_dateTime.Name = "end_dateTime";
            this.end_dateTime.Size = new System.Drawing.Size(298, 29);
            this.end_dateTime.TabIndex = 11;
            this.end_dateTime.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.Location = new System.Drawing.Point(340, 417);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(134, 43);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "Return";
            this.returnButton.UseSelectable = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 742);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.end_dateTime);
            this.Controls.Add(this.debtLabel);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookWindow";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Show Book";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private MetroFramework.Controls.MetroLabel Author;
        private MetroFramework.Controls.MetroLabel authorLabel;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel genreLabel;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroButton borrowButton;
        private MetroFramework.Controls.MetroLabel debtLabel;
        private MetroFramework.Controls.MetroDateTime end_dateTime;
        private MetroFramework.Controls.MetroButton returnButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}