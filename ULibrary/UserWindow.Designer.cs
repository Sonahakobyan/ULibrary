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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.booksTab = new MetroFramework.Controls.MetroTabPage();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.booksGrid = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenTab = new MetroFramework.Controls.MetroTabPage();
            this.takenBooksGrid = new MetroFramework.Controls.MetroGrid();
            this.takenIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyTab = new MetroFramework.Controls.MetroTabPage();
            this.historyGrid = new MetroFramework.Controls.MetroGrid();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsTab = new MetroFramework.Controls.MetroTabPage();
            this.addTextBox = new MetroFramework.Controls.MetroTextBox();
            this.payTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.payButton = new MetroFramework.Controls.MetroButton();
            this.debt = new MetroFramework.Controls.MetroLabel();
            this.debtLab = new MetroFramework.Controls.MetroLabel();
            this.money = new MetroFramework.Controls.MetroLabel();
            this.moneyLab = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl1.SuspendLayout();
            this.booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.takenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenBooksGrid)).BeginInit();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.paymentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.takenTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Controls.Add(this.paymentsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 652);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.SearchButton);
            this.booksTab.Controls.Add(this.booksGrid);
            this.booksTab.HorizontalScrollbarBarColor = true;
            this.booksTab.HorizontalScrollbarHighlightOnWheel = false;
            this.booksTab.HorizontalScrollbarSize = 10;
            this.booksTab.Location = new System.Drawing.Point(4, 38);
            this.booksTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.booksTab.Size = new System.Drawing.Size(1212, 610);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            this.booksTab.VerticalScrollbarBarColor = true;
            this.booksTab.VerticalScrollbarHighlightOnWheel = false;
            this.booksTab.VerticalScrollbarSize = 10;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1070, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(138, 37);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseSelectable = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            this.booksGrid.AllowUserToResizeRows = false;
            this.booksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.booksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.titleColumn,
            this.authorColumn,
            this.genreColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.booksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGrid.EnableHeadersVisualStyles = false;
            this.booksGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.booksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksGrid.Location = new System.Drawing.Point(4, 5);
            this.booksGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(1204, 600);
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
            this.titleColumn.Width = 95;
            // 
            // authorColumn
            // 
            this.authorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.authorColumn.HeaderText = "Author";
            this.authorColumn.Name = "authorColumn";
            this.authorColumn.ReadOnly = true;
            this.authorColumn.Width = 121;
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
            this.takenTab.HorizontalScrollbarBarColor = true;
            this.takenTab.HorizontalScrollbarHighlightOnWheel = false;
            this.takenTab.HorizontalScrollbarSize = 10;
            this.takenTab.Location = new System.Drawing.Point(4, 38);
            this.takenTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takenTab.Name = "takenTab";
            this.takenTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takenTab.Size = new System.Drawing.Size(1212, 610);
            this.takenTab.TabIndex = 1;
            this.takenTab.Text = "Taken Book";
            this.takenTab.UseVisualStyleBackColor = true;
            this.takenTab.VerticalScrollbarBarColor = true;
            this.takenTab.VerticalScrollbarHighlightOnWheel = false;
            this.takenTab.VerticalScrollbarSize = 10;
            // 
            // takenBooksGrid
            // 
            this.takenBooksGrid.AllowUserToAddRows = false;
            this.takenBooksGrid.AllowUserToDeleteRows = false;
            this.takenBooksGrid.AllowUserToResizeRows = false;
            this.takenBooksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.takenBooksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.takenBooksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.takenBooksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.takenBooksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.takenBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenBooksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takenIDColumn,
            this.takenTitleColumn,
            this.takenAuthorColumn,
            this.startdateColumn,
            this.enddateColumn,
            this.debtColumn});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.takenBooksGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.takenBooksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takenBooksGrid.EnableHeadersVisualStyles = false;
            this.takenBooksGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.takenBooksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.takenBooksGrid.Location = new System.Drawing.Point(4, 5);
            this.takenBooksGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takenBooksGrid.MultiSelect = false;
            this.takenBooksGrid.Name = "takenBooksGrid";
            this.takenBooksGrid.ReadOnly = true;
            this.takenBooksGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.takenBooksGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.takenBooksGrid.RowHeadersVisible = false;
            this.takenBooksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.takenBooksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.takenBooksGrid.Size = new System.Drawing.Size(1204, 600);
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
            this.takenTitleColumn.Width = 62;
            // 
            // takenAuthorColumn
            // 
            this.takenAuthorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.takenAuthorColumn.HeaderText = "Author";
            this.takenAuthorColumn.Name = "takenAuthorColumn";
            this.takenAuthorColumn.ReadOnly = true;
            this.takenAuthorColumn.Width = 77;
            // 
            // startdateColumn
            // 
            this.startdateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startdateColumn.HeaderText = "Start Date";
            this.startdateColumn.Name = "startdateColumn";
            this.startdateColumn.ReadOnly = true;
            this.startdateColumn.Width = 92;
            // 
            // enddateColumn
            // 
            this.enddateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enddateColumn.HeaderText = "End Date";
            this.enddateColumn.Name = "enddateColumn";
            this.enddateColumn.ReadOnly = true;
            this.enddateColumn.Width = 88;
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
            this.historyTab.HorizontalScrollbarBarColor = true;
            this.historyTab.HorizontalScrollbarHighlightOnWheel = false;
            this.historyTab.HorizontalScrollbarSize = 10;
            this.historyTab.Location = new System.Drawing.Point(4, 38);
            this.historyTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(1212, 610);
            this.historyTab.TabIndex = 2;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            this.historyTab.VerticalScrollbarBarColor = true;
            this.historyTab.VerticalScrollbarHighlightOnWheel = false;
            this.historyTab.VerticalScrollbarSize = 10;
            // 
            // historyGrid
            // 
            this.historyGrid.AllowUserToAddRows = false;
            this.historyGrid.AllowUserToDeleteRows = false;
            this.historyGrid.AllowUserToResizeColumns = false;
            this.historyGrid.AllowUserToResizeRows = false;
            this.historyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.historyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historyGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hID,
            this.hTitle,
            this.hAuthor,
            this.hStartDate,
            this.hReturnDate});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.historyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyGrid.EnableHeadersVisualStyles = false;
            this.historyGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.historyGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.historyGrid.Location = new System.Drawing.Point(0, 0);
            this.historyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyGrid.MultiSelect = false;
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.ReadOnly = true;
            this.historyGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.historyGrid.RowHeadersVisible = false;
            this.historyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.historyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyGrid.Size = new System.Drawing.Size(1212, 610);
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
            this.paymentsTab.HorizontalScrollbarBarColor = true;
            this.paymentsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.paymentsTab.HorizontalScrollbarSize = 10;
            this.paymentsTab.Location = new System.Drawing.Point(4, 38);
            this.paymentsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsTab.Name = "paymentsTab";
            this.paymentsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsTab.Size = new System.Drawing.Size(1212, 610);
            this.paymentsTab.TabIndex = 3;
            this.paymentsTab.Text = "Payments";
            this.paymentsTab.UseVisualStyleBackColor = true;
            this.paymentsTab.VerticalScrollbarBarColor = true;
            this.paymentsTab.VerticalScrollbarHighlightOnWheel = false;
            this.paymentsTab.VerticalScrollbarSize = 10;
            // 
            // addTextBox
            // 
            // 
            // 
            // 
            this.addTextBox.CustomButton.Image = null;
            this.addTextBox.CustomButton.Location = new System.Drawing.Point(98, 2);
            this.addTextBox.CustomButton.Name = "";
            this.addTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addTextBox.CustomButton.TabIndex = 1;
            this.addTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addTextBox.CustomButton.UseSelectable = true;
            this.addTextBox.CustomButton.Visible = false;
            this.addTextBox.Lines = new string[0];
            this.addTextBox.Location = new System.Drawing.Point(12, 197);
            this.addTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTextBox.MaxLength = 32767;
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.PasswordChar = '\0';
            this.addTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addTextBox.SelectedText = "";
            this.addTextBox.SelectionLength = 0;
            this.addTextBox.SelectionStart = 0;
            this.addTextBox.ShortcutsEnabled = true;
            this.addTextBox.Size = new System.Drawing.Size(122, 26);
            this.addTextBox.TabIndex = 7;
            this.addTextBox.UseSelectable = true;
            this.addTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.addTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addTextBox_KeyPress);
            // 
            // payTextBox
            // 
            // 
            // 
            // 
            this.payTextBox.CustomButton.Image = null;
            this.payTextBox.CustomButton.Location = new System.Drawing.Point(98, 2);
            this.payTextBox.CustomButton.Name = "";
            this.payTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.payTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.payTextBox.CustomButton.TabIndex = 1;
            this.payTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.payTextBox.CustomButton.UseSelectable = true;
            this.payTextBox.CustomButton.Visible = false;
            this.payTextBox.Lines = new string[0];
            this.payTextBox.Location = new System.Drawing.Point(12, 135);
            this.payTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payTextBox.MaxLength = 32767;
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.PasswordChar = '\0';
            this.payTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.payTextBox.SelectedText = "";
            this.payTextBox.SelectionLength = 0;
            this.payTextBox.SelectionStart = 0;
            this.payTextBox.ShortcutsEnabled = true;
            this.payTextBox.Size = new System.Drawing.Size(122, 26);
            this.payTextBox.TabIndex = 6;
            this.payTextBox.UseSelectable = true;
            this.payTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.payTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.payTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payTextBox_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(146, 194);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 35);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(146, 132);
            this.payButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(93, 35);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "Pay";
            this.payButton.UseSelectable = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // debt
            // 
            this.debt.AutoSize = true;
            this.debt.Location = new System.Drawing.Point(171, 75);
            this.debt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debt.Name = "debt";
            this.debt.Size = new System.Drawing.Size(16, 19);
            this.debt.TabIndex = 3;
            this.debt.Text = "0";
            // 
            // debtLab
            // 
            this.debtLab.AutoSize = true;
            this.debtLab.Location = new System.Drawing.Point(28, 75);
            this.debtLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debtLab.Name = "debtLab";
            this.debtLab.Size = new System.Drawing.Size(101, 19);
            this.debtLab.TabIndex = 2;
            this.debtLab.Text = "Your total debt:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(171, 35);
            this.money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(16, 19);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            // 
            // moneyLab
            // 
            this.moneyLab.AutoSize = true;
            this.moneyLab.Location = new System.Drawing.Point(28, 35);
            this.moneyLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyLab.Name = "moneyLab";
            this.moneyLab.Size = new System.Drawing.Size(114, 19);
            this.moneyLab.TabIndex = 0;
            this.moneyLab.Text = "Your total money:";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 732);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ULibrary";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl1.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.takenTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.takenBooksGrid)).EndInit();
            this.historyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.paymentsTab.ResumeLayout(false);
            this.paymentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage booksTab;
        private MetroFramework.Controls.MetroTabPage takenTab;
        private MetroFramework.Controls.MetroTabPage historyTab;
        private MetroFramework.Controls.MetroGrid booksGrid;
        private MetroFramework.Controls.MetroButton SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreColumn;
        private MetroFramework.Controls.MetroGrid takenBooksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtColumn;
        private MetroFramework.Controls.MetroGrid historyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hReturnDate;
        private MetroFramework.Controls.MetroTabPage paymentsTab;
        private MetroFramework.Controls.MetroLabel debt;
        private MetroFramework.Controls.MetroLabel debtLab;
        private MetroFramework.Controls.MetroLabel money;
        private MetroFramework.Controls.MetroLabel moneyLab;
        private MetroFramework.Controls.MetroTextBox addTextBox;
        private MetroFramework.Controls.MetroTextBox payTextBox;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton payButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}