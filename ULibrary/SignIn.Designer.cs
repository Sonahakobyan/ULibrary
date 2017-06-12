namespace ULibrary
{
    partial class SignIn
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.signInTab = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.Username = new MetroFramework.Controls.MetroTextBox();
            this.signUpTab = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.signUpPassword = new MetroFramework.Controls.MetroTextBox();
            this.signUpUsername = new MetroFramework.Controls.MetroTextBox();
            this.signUpLName = new MetroFramework.Controls.MetroTextBox();
            this.signUpFName = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl1.SuspendLayout();
            this.signInTab.SuspendLayout();
            this.signUpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.signInTab);
            this.tabControl1.Controls.Add(this.signUpTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(30, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 390);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // signInTab
            // 
            this.signInTab.Controls.Add(this.button1);
            this.signInTab.Controls.Add(this.label2);
            this.signInTab.Controls.Add(this.label1);
            this.signInTab.Controls.Add(this.Password);
            this.signInTab.Controls.Add(this.Username);
            this.signInTab.ForeColor = System.Drawing.Color.Black;
            this.signInTab.HorizontalScrollbarBarColor = true;
            this.signInTab.HorizontalScrollbarHighlightOnWheel = false;
            this.signInTab.HorizontalScrollbarSize = 10;
            this.signInTab.Location = new System.Drawing.Point(4, 38);
            this.signInTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInTab.Name = "signInTab";
            this.signInTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInTab.Size = new System.Drawing.Size(526, 348);
            this.signInTab.TabIndex = 0;
            this.signInTab.Text = "Sign In";
            this.signInTab.VerticalScrollbarBarColor = true;
            this.signInTab.VerticalScrollbarHighlightOnWheel = false;
            this.signInTab.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.button1.Location = new System.Drawing.Point(192, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign In";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(192, 91);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.WaterMark = "Password";
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(252, 26);
            this.Password.TabIndex = 1;
            this.Password.UseSelectable = true;
            this.Password.WaterMark = "Password";
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Username
            // 
            // 
            // 
            // 
            this.Username.CustomButton.Image = null;
            this.Username.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.Username.CustomButton.Name = "";
            this.Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Username.CustomButton.TabIndex = 1;
            this.Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Username.CustomButton.UseSelectable = true;
            this.Username.CustomButton.Visible = false;
            this.Username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Username.Lines = new string[0];
            this.Username.Location = new System.Drawing.Point(192, 25);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.MaxLength = 32767;
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.WaterMark = "Username";
            this.Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Username.SelectedText = "";
            this.Username.SelectionLength = 0;
            this.Username.SelectionStart = 0;
            this.Username.ShortcutsEnabled = true;
            this.Username.Size = new System.Drawing.Size(252, 26);
            this.Username.TabIndex = 0;
            this.Username.UseSelectable = true;
            this.Username.WaterMark = "Username";
            this.Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // signUpTab
            // 
            this.signUpTab.Controls.Add(this.button2);
            this.signUpTab.Controls.Add(this.signUpPassword);
            this.signUpTab.Controls.Add(this.signUpUsername);
            this.signUpTab.Controls.Add(this.signUpLName);
            this.signUpTab.Controls.Add(this.signUpFName);
            this.signUpTab.Controls.Add(this.label6);
            this.signUpTab.Controls.Add(this.label5);
            this.signUpTab.Controls.Add(this.label4);
            this.signUpTab.Controls.Add(this.label3);
            this.signUpTab.HorizontalScrollbarBarColor = true;
            this.signUpTab.HorizontalScrollbarHighlightOnWheel = false;
            this.signUpTab.HorizontalScrollbarSize = 10;
            this.signUpTab.Location = new System.Drawing.Point(4, 38);
            this.signUpTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpTab.Name = "signUpTab";
            this.signUpTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpTab.Size = new System.Drawing.Size(526, 348);
            this.signUpTab.TabIndex = 1;
            this.signUpTab.Text = "Sign Up";
            this.signUpTab.UseVisualStyleBackColor = true;
            this.signUpTab.VerticalScrollbarBarColor = true;
            this.signUpTab.VerticalScrollbarHighlightOnWheel = false;
            this.signUpTab.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sign Up";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // signUpPassword
            // 
            // 
            // 
            // 
            this.signUpPassword.CustomButton.Image = null;
            this.signUpPassword.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.signUpPassword.CustomButton.Name = "";
            this.signUpPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.signUpPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpPassword.CustomButton.TabIndex = 1;
            this.signUpPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signUpPassword.CustomButton.UseSelectable = true;
            this.signUpPassword.CustomButton.Visible = false;
            this.signUpPassword.Lines = new string[0];
            this.signUpPassword.Location = new System.Drawing.Point(204, 215);
            this.signUpPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpPassword.MaxLength = 32767;
            this.signUpPassword.Name = "signUpPassword";
            this.signUpPassword.PasswordChar = '*';
            this.signUpPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.signUpPassword.SelectedText = "";
            this.signUpPassword.SelectionLength = 0;
            this.signUpPassword.SelectionStart = 0;
            this.signUpPassword.ShortcutsEnabled = true;
            this.signUpPassword.Size = new System.Drawing.Size(238, 26);
            this.signUpPassword.TabIndex = 7;
            this.signUpPassword.UseSelectable = true;
            this.signUpPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.signUpPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // signUpUsername
            // 
            // 
            // 
            // 
            this.signUpUsername.CustomButton.Image = null;
            this.signUpUsername.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.signUpUsername.CustomButton.Name = "";
            this.signUpUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.signUpUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpUsername.CustomButton.TabIndex = 1;
            this.signUpUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signUpUsername.CustomButton.UseSelectable = true;
            this.signUpUsername.CustomButton.Visible = false;
            this.signUpUsername.Lines = new string[0];
            this.signUpUsername.Location = new System.Drawing.Point(204, 154);
            this.signUpUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpUsername.MaxLength = 32767;
            this.signUpUsername.Name = "signUpUsername";
            this.signUpUsername.PasswordChar = '\0';
            this.signUpUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.signUpUsername.SelectedText = "";
            this.signUpUsername.SelectionLength = 0;
            this.signUpUsername.SelectionStart = 0;
            this.signUpUsername.ShortcutsEnabled = true;
            this.signUpUsername.Size = new System.Drawing.Size(238, 26);
            this.signUpUsername.TabIndex = 6;
            this.signUpUsername.UseSelectable = true;
            this.signUpUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.signUpUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // signUpLName
            // 
            // 
            // 
            // 
            this.signUpLName.CustomButton.Image = null;
            this.signUpLName.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.signUpLName.CustomButton.Name = "";
            this.signUpLName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.signUpLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpLName.CustomButton.TabIndex = 1;
            this.signUpLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signUpLName.CustomButton.UseSelectable = true;
            this.signUpLName.CustomButton.Visible = false;
            this.signUpLName.Lines = new string[0];
            this.signUpLName.Location = new System.Drawing.Point(204, 92);
            this.signUpLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpLName.MaxLength = 32767;
            this.signUpLName.Name = "signUpLName";
            this.signUpLName.PasswordChar = '\0';
            this.signUpLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.signUpLName.SelectedText = "";
            this.signUpLName.SelectionLength = 0;
            this.signUpLName.SelectionStart = 0;
            this.signUpLName.ShortcutsEnabled = true;
            this.signUpLName.Size = new System.Drawing.Size(238, 26);
            this.signUpLName.TabIndex = 5;
            this.signUpLName.UseSelectable = true;
            this.signUpLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.signUpLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // signUpFName
            // 
            // 
            // 
            // 
            this.signUpFName.CustomButton.Image = null;
            this.signUpFName.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.signUpFName.CustomButton.Name = "";
            this.signUpFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.signUpFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpFName.CustomButton.TabIndex = 1;
            this.signUpFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signUpFName.CustomButton.UseSelectable = true;
            this.signUpFName.CustomButton.Visible = false;
            this.signUpFName.Lines = new string[0];
            this.signUpFName.Location = new System.Drawing.Point(204, 31);
            this.signUpFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpFName.MaxLength = 32767;
            this.signUpFName.Name = "signUpFName";
            this.signUpFName.PasswordChar = '\0';
            this.signUpFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.signUpFName.SelectedText = "";
            this.signUpFName.SelectionLength = 0;
            this.signUpFName.SelectionStart = 0;
            this.signUpFName.ShortcutsEnabled = true;
            this.signUpFName.Size = new System.Drawing.Size(238, 26);
            this.signUpFName.TabIndex = 4;
            this.signUpFName.UseSelectable = true;
            this.signUpFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.signUpFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 513);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Welcome To ULibrary";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.signInTab.ResumeLayout(false);
            this.signInTab.PerformLayout();
            this.signUpTab.ResumeLayout(false);
            this.signUpTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage signInTab;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroTextBox Username;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroTabPage signUpTab;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroTextBox signUpPassword;
        private MetroFramework.Controls.MetroTextBox signUpUsername;
        private MetroFramework.Controls.MetroTextBox signUpLName;
        private MetroFramework.Controls.MetroTextBox signUpFName;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

