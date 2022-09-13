namespace iSecureKey
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ComboBoxList = new MetroFramework.Controls.MetroComboBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtURL = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtOtherText = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.LbNew = new MetroFramework.Controls.MetroLabel();
            this.LinkChangeCredentials = new MetroFramework.Controls.MetroLink();
            this.LbVersion = new MetroFramework.Controls.MetroLabel();
            this.btnGeneratePsw = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ComboBoxList
            // 
            this.ComboBoxList.FormattingEnabled = true;
            this.ComboBoxList.ItemHeight = 23;
            this.ComboBoxList.Location = new System.Drawing.Point(377, 31);
            this.ComboBoxList.MaximumSize = new System.Drawing.Size(478, 0);
            this.ComboBoxList.Name = "ComboBoxList";
            this.ComboBoxList.Size = new System.Drawing.Size(255, 29);
            this.ComboBoxList.TabIndex = 0;
            this.ComboBoxList.UseSelectable = true;
            this.ComboBoxList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxList_SelectedIndexChanged);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(199, 79);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter a name for descrition this item";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(433, 31);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter a name for descrition this item";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(198, 126);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Enter a short description";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(433, 31);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Tag = "Description";
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Enter a short description";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(48, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(48, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtURL
            // 
            // 
            // 
            // 
            this.txtURL.CustomButton.Image = global::iSecureKey.Properties.Resources.globeX25;
            this.txtURL.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txtURL.CustomButton.Name = "";
            this.txtURL.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtURL.CustomButton.TabIndex = 1;
            this.txtURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtURL.CustomButton.UseSelectable = true;
            this.txtURL.Lines = new string[0];
            this.txtURL.Location = new System.Drawing.Point(198, 174);
            this.txtURL.MaxLength = 32767;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.PromptText = "Enter a adress web";
            this.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.ShortcutsEnabled = true;
            this.txtURL.ShowButton = true;
            this.txtURL.Size = new System.Drawing.Size(433, 31);
            this.txtURL.TabIndex = 3;
            this.txtURL.Tag = "URL";
            this.txtURL.UseSelectable = true;
            this.txtURL.WaterMark = "Enter a adress web";
            this.txtURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtURL.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtURL_ButtonClick);
            this.txtURL.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(48, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Url";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(198, 221);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PromptText = "Enter the user name";
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(433, 31);
            this.txtUser.TabIndex = 4;
            this.txtUser.Tag = "User";
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMark = "Enter the user name";
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(48, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "User";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(48, 275);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 23);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Password";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(48, 328);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 23);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Others";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOtherText
            // 
            // 
            // 
            // 
            this.txtOtherText.CustomButton.Image = null;
            this.txtOtherText.CustomButton.Location = new System.Drawing.Point(355, 1);
            this.txtOtherText.CustomButton.Name = "";
            this.txtOtherText.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.txtOtherText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOtherText.CustomButton.TabIndex = 1;
            this.txtOtherText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOtherText.CustomButton.UseSelectable = true;
            this.txtOtherText.CustomButton.Visible = false;
            this.txtOtherText.Lines = new string[0];
            this.txtOtherText.Location = new System.Drawing.Point(198, 328);
            this.txtOtherText.MaxLength = 32767;
            this.txtOtherText.Multiline = true;
            this.txtOtherText.Name = "txtOtherText";
            this.txtOtherText.PasswordChar = '\0';
            this.txtOtherText.PromptText = "Enter some text to save";
            this.txtOtherText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOtherText.SelectedText = "";
            this.txtOtherText.SelectionLength = 0;
            this.txtOtherText.SelectionStart = 0;
            this.txtOtherText.ShortcutsEnabled = true;
            this.txtOtherText.Size = new System.Drawing.Size(433, 79);
            this.txtOtherText.TabIndex = 6;
            this.txtOtherText.Tag = "OtherText";
            this.txtOtherText.UseSelectable = true;
            this.txtOtherText.WaterMark = "Enter some text to save";
            this.txtOtherText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOtherText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOtherText.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(198, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.EnabledChanged += new System.EventHandler(this.btnSave_EnabledChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(485, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 51);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.Location = new System.Drawing.Point(24, 430);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(142, 50);
            this.btnNew.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.UseStyleColors = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = global::iSecureKey.Properties.Resources.eyeX25;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(199, 275);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Enter the user name";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowButton = true;
            this.txtPassword.Size = new System.Drawing.Size(433, 31);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Tag = "Password";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter the user name";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPassword_ButtonClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // LbNew
            // 
            this.LbNew.BackColor = System.Drawing.Color.White;
            this.LbNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbNew.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LbNew.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LbNew.Location = new System.Drawing.Point(279, 23);
            this.LbNew.Name = "LbNew";
            this.LbNew.Size = new System.Drawing.Size(64, 45);
            this.LbNew.Style = MetroFramework.MetroColorStyle.Orange;
            this.LbNew.TabIndex = 17;
            this.LbNew.Text = "NEW";
            this.LbNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbNew.UseStyleColors = true;
            this.LbNew.Visible = false;
            // 
            // LinkChangeCredentials
            // 
            this.LinkChangeCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkChangeCredentials.Location = new System.Drawing.Point(24, 488);
            this.LinkChangeCredentials.Name = "LinkChangeCredentials";
            this.LinkChangeCredentials.Size = new System.Drawing.Size(142, 23);
            this.LinkChangeCredentials.TabIndex = 18;
            this.LinkChangeCredentials.Text = "Change credentials";
            this.LinkChangeCredentials.UseSelectable = true;
            this.LinkChangeCredentials.Click += new System.EventHandler(this.LinkChangeCredentials_Click);
            // 
            // LbVersion
            // 
            this.LbVersion.Location = new System.Drawing.Point(416, 489);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(216, 21);
            this.LbVersion.TabIndex = 19;
            this.LbVersion.Text = "Version 1.2";
            this.LbVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnGeneratePsw
            // 
            this.btnGeneratePsw.ActiveControl = null;
            this.btnGeneratePsw.Location = new System.Drawing.Point(656, 275);
            this.btnGeneratePsw.Name = "btnGeneratePsw";
            this.btnGeneratePsw.Size = new System.Drawing.Size(30, 30);
            this.btnGeneratePsw.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnGeneratePsw.TabIndex = 20;
            this.btnGeneratePsw.TileImage = global::iSecureKey.Properties.Resources.key_16;
            this.btnGeneratePsw.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePsw.UseSelectable = true;
            this.btnGeneratePsw.UseTileImage = true;
            this.btnGeneratePsw.Click += new System.EventHandler(this.btnGeneratePsw_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveControl = null;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(656, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.TileImage = ((System.Drawing.Image)(resources.GetObject("btnExit.TileImage")));
            this.btnExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseTileImage = true;
            this.btnExit.Click += new System.EventHandler(this.metroTileExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(695, 518);
            this.Controls.Add(this.btnGeneratePsw);
            this.Controls.Add(this.LbVersion);
            this.Controls.Add(this.LinkChangeCredentials);
            this.Controls.Add(this.LbNew);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOtherText);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ComboBoxList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(695, 518);
            this.MinimumSize = new System.Drawing.Size(695, 518);
            this.Name = "MainForm";
            this.Text = "Save secure information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboBoxList;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtURL;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtOtherText;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel LbNew;
        private MetroFramework.Controls.MetroLink LinkChangeCredentials;
        private MetroFramework.Controls.MetroLabel LbVersion;
        private MetroFramework.Controls.MetroTile btnGeneratePsw;
    }
}

