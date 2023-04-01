using MetroFramework;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace SecureKey
{
    public enum LoginOptions
    {
        LoginUser = 0,
        ChangeCredentials = 1,
        CheckUser = 2,
    }

    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        
        #region FIELDS
        
        private Boolean FirtTime = false;

        #endregion

        #region PROPERTIES
        private LoginOptions Option
        {
            get;
            set;
        }

        #endregion

        #region CONSTRUCTOR

        public FormLogin()
        {            
            InitializeComponent();            
        }

        #endregion

        #region EVENTS

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
                return;

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "The user or password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                e.Cancel = true;
                return;
            }

            switch (Option)
            {
                case LoginOptions.LoginUser:
                    if (!FirtTime && !CManager.LoadDocument(txtUser.Text, txtPassword.Text))
                    {
                        if (MetroMessageBox.Show(this, "The login failed, do you want try again?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100) == DialogResult.Yes)
                        {
                            this.txtPassword.Text = string.Empty;
                            this.txtUser.Text = string.Empty;
                            e.Cancel = true;
                        }
                        else
                            return;
                    }
                    CManager.UserLogin  =  txtUser.Text;
                    CManager.PassWordLogin  = txtPassword.Text;
                    break;
                case LoginOptions.CheckUser:
                    if (txtUser.Text != CManager.UserLogin || txtPassword.Text != CManager.PassWordLogin)
                    {
                        if(MetroMessageBox.Show(this, "Incorrect credentials, do you want try again?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100)== DialogResult.Yes)
                        {
                            this.txtPassword.Text = string.Empty;
                            this.txtUser.Text = string.Empty;
                            e.Cancel = true;
                        }
                        else
                            return;
                    }
                    
                    break;
                case LoginOptions.ChangeCredentials:
                    CManager.UserLogin  =  txtUser.Text;
                    CManager.PassWordLogin  = txtPassword.Text;        
                    break;
            }

            
        }
        
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void metroTileOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.txtPassword.UseSystemPasswordChar;
        }

        #endregion
        
        #region METHODS
        public DialogResult ShowDialog(IWin32Window owner ,LoginOptions mOption = LoginOptions.LoginUser)
        {
            this.Option = mOption;
            this.txtPassword.UseSystemPasswordChar = true;
            switch (Option)
            {
                case LoginOptions.LoginUser:
                    // get the file to decrypt
                    this.Text = "Enter yours credentials";
                    if (!Directory.Exists(CManager.PATH_DIR_FIELS))
                        Directory.CreateDirectory(CManager.PATH_DIR_FIELS);

                    String[] Files = Directory.GetFiles(CManager.PATH_DIR_FIELS);
                    if (Files.Count() == 0)
                    {
                        FirtTime = true;
                        CManager.CreateFirstFile();
                        MetroMessageBox.Show(this, "This is the first time. Enter new credentials", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                        this.txtUser.Focus();
                        return base.ShowDialog(owner);
                    }
                    else
                        CManager.FileSource = Files.FirstOrDefault();                                            
                        return base.ShowDialog(owner);
                    
                case LoginOptions.ChangeCredentials:
                    this.Text = "Enter the new credentials";                    
                    return base.ShowDialog(owner);
                    
                case LoginOptions.CheckUser:
                    this.Text = "Validate the actual credentials";                    
                    return base.ShowDialog(owner);                    
            }

            return DialogResult.Cancel;
        }

        #endregion

    }
}
