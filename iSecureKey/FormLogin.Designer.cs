namespace SecureKey
{
    partial class FormLogin
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
            this.metroTileOK = new MetroFramework.Controls.MetroTile();
            this.metroTileCancel = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstTimeMsg = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTileOK
            // 
            this.metroTileOK.ActiveControl = null;
            this.metroTileOK.Location = new System.Drawing.Point(224, 280);
            this.metroTileOK.Name = "metroTileOK";
            this.metroTileOK.Size = new System.Drawing.Size(132, 36);
            this.metroTileOK.TabIndex = 0;
            this.metroTileOK.Text = "OK";
            this.metroTileOK.UseSelectable = true;
            this.metroTileOK.Click += new System.EventHandler(this.metroTileOK_Click);
            // 
            // metroTileCancel
            // 
            this.metroTileCancel.ActiveControl = null;
            this.metroTileCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroTileCancel.Location = new System.Drawing.Point(113, 280);
            this.metroTileCancel.Name = "metroTileCancel";
            this.metroTileCancel.Size = new System.Drawing.Size(77, 36);
            this.metroTileCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileCancel.TabIndex = 1;
            this.metroTileCancel.Text = "Cancel";
            this.metroTileCancel.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(7, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 23);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Password";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(7, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "User";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = global::SecureKey.Properties.Resources.eyeX25;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(113, 144);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Enter the password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowButton = true;
            this.txtPassword.Size = new System.Drawing.Size(243, 31);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter the password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPassword_ButtonClick);
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(113, 94);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PromptText = "Enter the user name";
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(243, 31);
            this.txtUser.TabIndex = 11;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMark = "Enter the user name";
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstTimeMsg
            // 
            this.txtFirstTimeMsg.Location = new System.Drawing.Point(113, 186);
            this.txtFirstTimeMsg.Name = "txtFirstTimeMsg";
            this.txtFirstTimeMsg.Size = new System.Drawing.Size(242, 74);
            this.txtFirstTimeMsg.TabIndex = 15;
            this.txtFirstTimeMsg.Visible = false;
            this.txtFirstTimeMsg.WrapToLine = true;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.metroTileOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroTileCancel;
            this.ClientSize = new System.Drawing.Size(402, 361);
            this.Controls.Add(this.txtFirstTimeMsg);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.metroTileCancel);
            this.Controls.Add(this.metroTileOK);
            this.Name = "FormLogin";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Enter yours credentials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileOK;
        private MetroFramework.Controls.MetroTile metroTileCancel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel txtFirstTimeMsg;
    }
}