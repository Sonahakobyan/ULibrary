namespace ULibrary
{
    partial class AdminWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.authorText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookHistoryTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.userBookGrid = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financeTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.debtLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.bookHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookGrid)).BeginInit();
            this.financeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.bookHistoryTab);
            this.tabControl1.Controls.Add(this.financeTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1302, 1032);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.addButton);
            this.booksTab.Controls.Add(this.descriptionText);
            this.booksTab.Controls.Add(this.genreText);
            this.booksTab.Controls.Add(this.label4);
            this.booksTab.Controls.Add(this.label3);
            this.booksTab.Controls.Add(this.label2);
            this.booksTab.Controls.Add(this.label1);
            this.booksTab.Controls.Add(this.authorText);
            this.booksTab.Controls.Add(this.titleText);
            this.booksTab.Controls.Add(this.booksGrid);
            this.booksTab.Location = new System.Drawing.Point(4, 29);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(1294, 999);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(67, 789);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(100, 26);
            this.authorText.TabIndex = 2;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(67, 752);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(178, 26);
            this.titleText.TabIndex = 1;
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.titleColumn,
            this.authorColumn,
            this.genreColumn,
            this.deleteColumn});
            this.booksGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksGrid.Location = new System.Drawing.Point(3, 3);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowTemplate.Height = 28;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.booksGrid.Size = new System.Drawing.Size(1288, 687);
            this.booksGrid.TabIndex = 0;
            this.booksGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksGrid_CellMouseClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // titleColumn
            // 
            this.titleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleColumn.HeaderText = "Title";
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.ReadOnly = true;
            // 
            // authorColumn
            // 
            this.authorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorColumn.HeaderText = "Author";
            this.authorColumn.Name = "authorColumn";
            this.authorColumn.ReadOnly = true;
            // 
            // genreColumn
            // 
            this.genreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreColumn.HeaderText = "Genre";
            this.genreColumn.Name = "genreColumn";
            this.genreColumn.ReadOnly = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Text = "Delete";
            this.deleteColumn.Width = 92;
            // 
            // bookHistoryTab
            // 
            this.bookHistoryTab.Controls.Add(this.userBookGrid);
            this.bookHistoryTab.Location = new System.Drawing.Point(4, 29);
            this.bookHistoryTab.Name = "bookHistoryTab";
            this.bookHistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookHistoryTab.Size = new System.Drawing.Size(1294, 999);
            this.bookHistoryTab.TabIndex = 1;
            this.bookHistoryTab.Text = "Book History";
            this.bookHistoryTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 755);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 792);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 831);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 865);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(67, 828);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 26);
            this.genreText.TabIndex = 7;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(67, 862);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(100, 26);
            this.descriptionText.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(14, 928);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userBookGrid
            // 
            this.userBookGrid.AllowUserToAddRows = false;
            this.userBookGrid.AllowUserToDeleteRows = false;
            this.userBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.TitleCol,
            this.userCol,
            this.startdateCol,
            this.enddateCol,
            this.returndateCol});
            this.userBookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBookGrid.Location = new System.Drawing.Point(3, 3);
            this.userBookGrid.Name = "userBookGrid";
            this.userBookGrid.ReadOnly = true;
            this.userBookGrid.RowTemplate.Height = 28;
            this.userBookGrid.Size = new System.Drawing.Size(1288, 993);
            this.userBookGrid.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // TitleCol
            // 
            this.TitleCol.HeaderText = "Title";
            this.TitleCol.Name = "TitleCol";
            this.TitleCol.ReadOnly = true;
            // 
            // userCol
            // 
            this.userCol.HeaderText = "User";
            this.userCol.Name = "userCol";
            this.userCol.ReadOnly = true;
            // 
            // startdateCol
            // 
            this.startdateCol.HeaderText = "Start Date";
            this.startdateCol.Name = "startdateCol";
            this.startdateCol.ReadOnly = true;
            // 
            // enddateCol
            // 
            this.enddateCol.HeaderText = "End Date";
            this.enddateCol.Name = "enddateCol";
            this.enddateCol.ReadOnly = true;
            // 
            // returndateCol
            // 
            this.returndateCol.HeaderText = "Return Date";
            this.returndateCol.Name = "returndateCol";
            this.returndateCol.ReadOnly = true;
            // 
            // financeTab
            // 
            this.financeTab.Controls.Add(this.debtLabel);
            this.financeTab.Controls.Add(this.label7);
            this.financeTab.Controls.Add(this.moneyLabel);
            this.financeTab.Controls.Add(this.label5);
            this.financeTab.Location = new System.Drawing.Point(4, 29);
            this.financeTab.Name = "financeTab";
            this.financeTab.Padding = new System.Windows.Forms.Padding(3);
            this.financeTab.Size = new System.Drawing.Size(1294, 999);
            this.financeTab.TabIndex = 2;
            this.financeTab.Text = "Finance Management";
            this.financeTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Money:";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(114, 64);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(51, 20);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Users Debt: ";
            // 
            // debtLabel
            // 
            this.debtLabel.AutoSize = true;
            this.debtLabel.Location = new System.Drawing.Point(114, 123);
            this.debtLabel.Name = "debtLabel";
            this.debtLabel.Size = new System.Drawing.Size(51, 20);
            this.debtLabel.TabIndex = 3;
            this.debtLabel.Text = "label8";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1032);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.tabControl1.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.bookHistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBookGrid)).EndInit();
            this.financeTab.ResumeLayout(false);
            this.financeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage bookHistoryTab;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userBookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateCol;
        private System.Windows.Forms.TabPage financeTab;
        private System.Windows.Forms.Label debtLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label label5;
    }
}