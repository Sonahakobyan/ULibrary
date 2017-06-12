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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.booksTab = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.titleText = new MetroFramework.Controls.MetroTextBox();
            this.authorText = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.descriptionText = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.genreText = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.booksGrid = new MetroFramework.Controls.MetroGrid();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookHistoryTab = new MetroFramework.Controls.MetroTabPage();
            this.userBookGrid = new MetroFramework.Controls.MetroGrid();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financeTab = new MetroFramework.Controls.MetroTabPage();
            this.debtLabel = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.moneyLabel = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl1.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.bookHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookGrid)).BeginInit();
            this.financeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.bookHistoryTab);
            this.tabControl1.Controls.Add(this.financeTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(1262, 952);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.groupBox1);
            this.booksTab.Controls.Add(this.booksGrid);
            this.booksTab.HorizontalScrollbarBarColor = true;
            this.booksTab.HorizontalScrollbarHighlightOnWheel = false;
            this.booksTab.HorizontalScrollbarSize = 10;
            this.booksTab.Location = new System.Drawing.Point(4, 38);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(1254, 910);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            this.booksTab.VerticalScrollbarBarColor = true;
            this.booksTab.VerticalScrollbarHighlightOnWheel = false;
            this.booksTab.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.titleText);
            this.groupBox1.Controls.Add(this.authorText);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.descriptionText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genreText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 662);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            // 
            // titleText
            // 
            // 
            // 
            // 
            this.titleText.CustomButton.Image = null;
            this.titleText.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.titleText.CustomButton.Name = "";
            this.titleText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titleText.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.titleText.CustomButton.TabIndex = 1;
            this.titleText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleText.CustomButton.UseSelectable = true;
            this.titleText.CustomButton.Visible = false;
            this.titleText.Lines = new string[0];
            this.titleText.Location = new System.Drawing.Point(166, 24);
            this.titleText.MaxLength = 32767;
            this.titleText.Name = "titleText";
            this.titleText.PasswordChar = '\0';
            this.titleText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleText.SelectedText = "";
            this.titleText.SelectionLength = 0;
            this.titleText.SelectionStart = 0;
            this.titleText.ShortcutsEnabled = true;
            this.titleText.Size = new System.Drawing.Size(178, 26);
            this.titleText.TabIndex = 1;
            this.titleText.UseSelectable = true;
            this.titleText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // authorText
            // 
            // 
            // 
            // 
            this.authorText.CustomButton.Image = null;
            this.authorText.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.authorText.CustomButton.Name = "";
            this.authorText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authorText.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.authorText.CustomButton.TabIndex = 1;
            this.authorText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.authorText.CustomButton.UseSelectable = true;
            this.authorText.CustomButton.Visible = false;
            this.authorText.Lines = new string[0];
            this.authorText.Location = new System.Drawing.Point(166, 61);
            this.authorText.MaxLength = 32767;
            this.authorText.Name = "authorText";
            this.authorText.PasswordChar = '\0';
            this.authorText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authorText.SelectedText = "";
            this.authorText.SelectionLength = 0;
            this.authorText.SelectionStart = 0;
            this.authorText.ShortcutsEnabled = true;
            this.authorText.Size = new System.Drawing.Size(178, 26);
            this.authorText.TabIndex = 2;
            this.authorText.UseSelectable = true;
            this.authorText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authorText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(90, 197);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // descriptionText
            // 
            // 
            // 
            // 
            this.descriptionText.CustomButton.Image = null;
            this.descriptionText.CustomButton.Location = new System.Drawing.Point(720, 2);
            this.descriptionText.CustomButton.Name = "";
            this.descriptionText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionText.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.descriptionText.CustomButton.TabIndex = 1;
            this.descriptionText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.descriptionText.CustomButton.UseSelectable = true;
            this.descriptionText.CustomButton.Visible = false;
            this.descriptionText.Lines = new string[0];
            this.descriptionText.Location = new System.Drawing.Point(166, 134);
            this.descriptionText.MaxLength = 32767;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.PasswordChar = '\0';
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionText.SelectedText = "";
            this.descriptionText.SelectionLength = 0;
            this.descriptionText.SelectionStart = 0;
            this.descriptionText.ShortcutsEnabled = true;
            this.descriptionText.Size = new System.Drawing.Size(744, 26);
            this.descriptionText.TabIndex = 8;
            this.descriptionText.UseSelectable = true;
            this.descriptionText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // genreText
            // 
            // 
            // 
            // 
            this.genreText.CustomButton.Image = null;
            this.genreText.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.genreText.CustomButton.Name = "";
            this.genreText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.genreText.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.genreText.CustomButton.TabIndex = 1;
            this.genreText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.genreText.CustomButton.UseSelectable = true;
            this.genreText.CustomButton.Visible = false;
            this.genreText.Lines = new string[0];
            this.genreText.Location = new System.Drawing.Point(166, 100);
            this.genreText.MaxLength = 32767;
            this.genreText.Name = "genreText";
            this.genreText.PasswordChar = '\0';
            this.genreText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genreText.SelectedText = "";
            this.genreText.SelectionLength = 0;
            this.genreText.SelectionStart = 0;
            this.genreText.ShortcutsEnabled = true;
            this.genreText.Size = new System.Drawing.Size(178, 26);
            this.genreText.TabIndex = 7;
            this.genreText.UseSelectable = true;
            this.genreText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.genreText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            this.booksGrid.AllowUserToResizeRows = false;
            this.booksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.booksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.titleColumn,
            this.authorColumn,
            this.genreColumn,
            this.deleteColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.booksGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksGrid.EnableHeadersVisualStyles = false;
            this.booksGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.booksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksGrid.Location = new System.Drawing.Point(3, 3);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.booksGrid.RowTemplate.Height = 28;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(1248, 653);
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
            this.deleteColumn.Width = 90;
            // 
            // bookHistoryTab
            // 
            this.bookHistoryTab.Controls.Add(this.userBookGrid);
            this.bookHistoryTab.HorizontalScrollbarBarColor = true;
            this.bookHistoryTab.HorizontalScrollbarHighlightOnWheel = false;
            this.bookHistoryTab.HorizontalScrollbarSize = 10;
            this.bookHistoryTab.Location = new System.Drawing.Point(4, 38);
            this.bookHistoryTab.Name = "bookHistoryTab";
            this.bookHistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookHistoryTab.Size = new System.Drawing.Size(1254, 910);
            this.bookHistoryTab.TabIndex = 1;
            this.bookHistoryTab.Text = "Book History";
            this.bookHistoryTab.UseVisualStyleBackColor = true;
            this.bookHistoryTab.VerticalScrollbarBarColor = true;
            this.bookHistoryTab.VerticalScrollbarHighlightOnWheel = false;
            this.bookHistoryTab.VerticalScrollbarSize = 10;
            // 
            // userBookGrid
            // 
            this.userBookGrid.AllowUserToAddRows = false;
            this.userBookGrid.AllowUserToDeleteRows = false;
            this.userBookGrid.AllowUserToResizeRows = false;
            this.userBookGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userBookGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userBookGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.TitleCol,
            this.userCol,
            this.startdateCol,
            this.enddateCol,
            this.returndateCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userBookGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.userBookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBookGrid.EnableHeadersVisualStyles = false;
            this.userBookGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userBookGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userBookGrid.Location = new System.Drawing.Point(3, 3);
            this.userBookGrid.Name = "userBookGrid";
            this.userBookGrid.ReadOnly = true;
            this.userBookGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.userBookGrid.RowHeadersVisible = false;
            this.userBookGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userBookGrid.RowTemplate.Height = 28;
            this.userBookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userBookGrid.Size = new System.Drawing.Size(1248, 904);
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
            this.financeTab.HorizontalScrollbarBarColor = true;
            this.financeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.financeTab.HorizontalScrollbarSize = 10;
            this.financeTab.Location = new System.Drawing.Point(4, 38);
            this.financeTab.Name = "financeTab";
            this.financeTab.Padding = new System.Windows.Forms.Padding(3);
            this.financeTab.Size = new System.Drawing.Size(1254, 910);
            this.financeTab.TabIndex = 2;
            this.financeTab.Text = "Finance Management";
            this.financeTab.UseVisualStyleBackColor = true;
            this.financeTab.VerticalScrollbarBarColor = true;
            this.financeTab.VerticalScrollbarHighlightOnWheel = false;
            this.financeTab.VerticalScrollbarSize = 10;
            // 
            // debtLabel
            // 
            this.debtLabel.AutoSize = true;
            this.debtLabel.Location = new System.Drawing.Point(114, 123);
            this.debtLabel.Name = "debtLabel";
            this.debtLabel.Size = new System.Drawing.Size(44, 19);
            this.debtLabel.TabIndex = 3;
            this.debtLabel.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Users Debt: ";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(114, 64);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(44, 19);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Money:";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1032);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "AdminWindow";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl1.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.bookHistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBookGrid)).EndInit();
            this.financeTab.ResumeLayout(false);
            this.financeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage booksTab;
        private MetroFramework.Controls.MetroTabPage bookHistoryTab;
        private MetroFramework.Controls.MetroGrid booksGrid;
        private MetroFramework.Controls.MetroTextBox authorText;
        private MetroFramework.Controls.MetroTextBox titleText;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroTextBox descriptionText;
        private MetroFramework.Controls.MetroTextBox genreText;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroGrid userBookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateCol;
        private MetroFramework.Controls.MetroTabPage financeTab;
        private MetroFramework.Controls.MetroLabel debtLabel;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel moneyLabel;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}