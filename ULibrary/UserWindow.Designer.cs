namespace ULibrary
{
    partial class UserWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.SearchButton = new System.Windows.Forms.Button();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenTab = new System.Windows.Forms.TabPage();
            this.takenBooksGrid = new System.Windows.Forms.DataGridView();
            this.takenIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.historyGrid = new System.Windows.Forms.DataGridView();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsTab = new System.Windows.Forms.TabPage();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.debt = new System.Windows.Forms.Label();
            this.debtLab = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.moneyLab = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.takenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenBooksGrid)).BeginInit();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.paymentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.takenTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Controls.Add(this.paymentsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 476);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.SearchButton);
            this.booksTab.Controls.Add(this.booksGrid);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(832, 450);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Location = new System.Drawing.Point(734, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(92, 24);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            this.booksGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.titleColumn,
            this.authorColumn,
            this.genreColumn});
            this.booksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGrid.Location = new System.Drawing.Point(3, 3);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(826, 444);
            this.booksGrid.TabIndex = 0;
            this.booksGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksGrid_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // titleColumn
            // 
            this.titleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleColumn.HeaderText = "Title";
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.ReadOnly = true;
            this.titleColumn.Width = 66;
            // 
            // authorColumn
            // 
            this.authorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.authorColumn.HeaderText = "Author";
            this.authorColumn.Name = "authorColumn";
            this.authorColumn.ReadOnly = true;
            this.authorColumn.Width = 83;
            // 
            // genreColumn
            // 
            this.genreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreColumn.HeaderText = "Genre";
            this.genreColumn.Name = "genreColumn";
            this.genreColumn.ReadOnly = true;
            // 
            // takenTab
            // 
            this.takenTab.Controls.Add(this.takenBooksGrid);
            this.takenTab.Location = new System.Drawing.Point(4, 22);
            this.takenTab.Name = "takenTab";
            this.takenTab.Padding = new System.Windows.Forms.Padding(3);
            this.takenTab.Size = new System.Drawing.Size(832, 450);
            this.takenTab.TabIndex = 1;
            this.takenTab.Text = "Taken Book";
            this.takenTab.UseVisualStyleBackColor = true;
            // 
            // takenBooksGrid
            // 
            this.takenBooksGrid.AllowUserToAddRows = false;
            this.takenBooksGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.takenBooksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.takenBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenBooksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takenIDColumn,
            this.takenTitleColumn,
            this.takenAuthorColumn,
            this.startdateColumn,
            this.enddateColumn,
            this.debtColumn});
            this.takenBooksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takenBooksGrid.Location = new System.Drawing.Point(3, 3);
            this.takenBooksGrid.MultiSelect = false;
            this.takenBooksGrid.Name = "takenBooksGrid";
            this.takenBooksGrid.ReadOnly = true;
            this.takenBooksGrid.RowHeadersVisible = false;
            this.takenBooksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.takenBooksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.takenBooksGrid.Size = new System.Drawing.Size(826, 444);
            this.takenBooksGrid.TabIndex = 0;
            this.takenBooksGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.takenBooksGrid_CellMouseDoubleClick);
            // 
            // takenIDColumn
            // 
            this.takenIDColumn.HeaderText = "ID";
            this.takenIDColumn.Name = "takenIDColumn";
            this.takenIDColumn.ReadOnly = true;
            this.takenIDColumn.Visible = false;
            // 
            // takenTitleColumn
            // 
            this.takenTitleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.takenTitleColumn.HeaderText = "Title";
            this.takenTitleColumn.Name = "takenTitleColumn";
            this.takenTitleColumn.ReadOnly = true;
            this.takenTitleColumn.Width = 66;
            // 
            // takenAuthorColumn
            // 
            this.takenAuthorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.takenAuthorColumn.HeaderText = "Author";
            this.takenAuthorColumn.Name = "takenAuthorColumn";
            this.takenAuthorColumn.ReadOnly = true;
            this.takenAuthorColumn.Width = 83;
            // 
            // startdateColumn
            // 
            this.startdateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startdateColumn.HeaderText = "Start Date";
            this.startdateColumn.Name = "startdateColumn";
            this.startdateColumn.ReadOnly = true;
            this.startdateColumn.Width = 102;
            // 
            // enddateColumn
            // 
            this.enddateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enddateColumn.HeaderText = "End Date";
            this.enddateColumn.Name = "enddateColumn";
            this.enddateColumn.ReadOnly = true;
            this.enddateColumn.Width = 96;
            // 
            // debtColumn
            // 
            this.debtColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.debtColumn.HeaderText = "Debt";
            this.debtColumn.Name = "debtColumn";
            this.debtColumn.ReadOnly = true;
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.historyGrid);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(832, 450);
            this.historyTab.TabIndex = 2;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // historyGrid
            // 
            this.historyGrid.AllowUserToAddRows = false;
            this.historyGrid.AllowUserToDeleteRows = false;
            this.historyGrid.AllowUserToResizeColumns = false;
            this.historyGrid.AllowUserToResizeRows = false;
            this.historyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hID,
            this.hTitle,
            this.hAuthor,
            this.hStartDate,
            this.hReturnDate});
            this.historyGrid.Location = new System.Drawing.Point(0, 0);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.RowHeadersVisible = false;
            this.historyGrid.Size = new System.Drawing.Size(785, 313);
            this.historyGrid.TabIndex = 0;
            // 
            // hID
            // 
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.ReadOnly = true;
            this.hID.Visible = false;
            // 
            // hTitle
            // 
            this.hTitle.HeaderText = "Title";
            this.hTitle.Name = "hTitle";
            this.hTitle.ReadOnly = true;
            // 
            // hAuthor
            // 
            this.hAuthor.HeaderText = "Author";
            this.hAuthor.Name = "hAuthor";
            this.hAuthor.ReadOnly = true;
            // 
            // hStartDate
            // 
            this.hStartDate.HeaderText = "Start Date";
            this.hStartDate.Name = "hStartDate";
            this.hStartDate.ReadOnly = true;
            // 
            // hReturnDate
            // 
            this.hReturnDate.HeaderText = "Return Date";
            this.hReturnDate.Name = "hReturnDate";
            this.hReturnDate.ReadOnly = true;
            // 
            // paymentsTab
            // 
            this.paymentsTab.Controls.Add(this.addTextBox);
            this.paymentsTab.Controls.Add(this.payTextBox);
            this.paymentsTab.Controls.Add(this.addButton);
            this.paymentsTab.Controls.Add(this.payButton);
            this.paymentsTab.Controls.Add(this.debt);
            this.paymentsTab.Controls.Add(this.debtLab);
            this.paymentsTab.Controls.Add(this.money);
            this.paymentsTab.Controls.Add(this.moneyLab);
            this.paymentsTab.Location = new System.Drawing.Point(4, 22);
            this.paymentsTab.Name = "paymentsTab";
            this.paymentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.paymentsTab.Size = new System.Drawing.Size(832, 450);
            this.paymentsTab.TabIndex = 3;
            this.paymentsTab.Text = "Payments";
            this.paymentsTab.UseVisualStyleBackColor = true;
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(8, 128);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(83, 20);
            this.addTextBox.TabIndex = 7;
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(8, 88);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(83, 20);
            this.payTextBox.TabIndex = 6;
            this.payTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payTextBox_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(97, 126);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(97, 86);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(62, 23);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // debt
            // 
            this.debt.AutoSize = true;
            this.debt.Location = new System.Drawing.Point(114, 49);
            this.debt.Name = "debt";
            this.debt.Size = new System.Drawing.Size(13, 13);
            this.debt.TabIndex = 3;
            this.debt.Text = "0";
            // 
            // debtLab
            // 
            this.debtLab.AutoSize = true;
            this.debtLab.Location = new System.Drawing.Point(19, 49);
            this.debtLab.Name = "debtLab";
            this.debtLab.Size = new System.Drawing.Size(79, 13);
            this.debtLab.TabIndex = 2;
            this.debtLab.Text = "Your total debt:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(114, 23);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(13, 13);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            // 
            // moneyLab
            // 
            this.moneyLab.AutoSize = true;
            this.moneyLab.Location = new System.Drawing.Point(19, 23);
            this.moneyLab.Name = "moneyLab";
            this.moneyLab.Size = new System.Drawing.Size(89, 13);
            this.moneyLab.TabIndex = 0;
            this.moneyLab.Text = "Your total money:";
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ULibrary";
            this.tabControl1.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.takenTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.takenBooksGrid)).EndInit();
            this.historyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.paymentsTab.ResumeLayout(false);
            this.paymentsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage takenTab;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreColumn;
        private System.Windows.Forms.DataGridView takenBooksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtColumn;
        private System.Windows.Forms.DataGridView historyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hReturnDate;
        private System.Windows.Forms.TabPage paymentsTab;
        private System.Windows.Forms.Label debt;
        private System.Windows.Forms.Label debtLab;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label moneyLab;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button payButton;
    }
}