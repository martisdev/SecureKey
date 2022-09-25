using MetroFramework;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using MSC.WolfSslNet;

namespace SecureKey
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        #region FIELDS

        private CDataEncrypt CurrentData = null;
        #endregion

        #region CONSTRUCTOR

        public MainForm()
        {
            InitializeComponent();

            FormLogin DialogLogin = new FormLogin();
            DialogLogin.TopMost = true;

            if (DialogLogin.ShowDialog(this,LoginOptions.LoginUser) == DialogResult.Cancel)
                Environment.Exit(0);
            
        }

        #endregion

        #region EVENTS

        private void metroTileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(LbNew.Visible)
            {                
                LbNew.Visible = false;
                RefreshComboBox();
            }
            else
            {
                
                ComboBoxList.Items.Clear();
                ComboBoxList.Enabled = false;
                LbNew.Visible = true;
                btnNew.Text = "Cancel";
                ClearForm();                
                CurrentData = null;
            }
            
        }
  
        private void txtData_TextChanged(object sender, EventArgs e)
        {            
            if(LbNew.Visible)
            {
                btnSave.Enabled = true;
                return;
            }                

            if (ComboBoxList.SelectedItem == null)
                return;

            string NameCurrentData = ComboBoxList.SelectedItem.ToString();
            Control ctl = sender as Control;
                        
            PropertyInfo info  = CManager.ListFiles.SingleOrDefault(x => x.Name == NameCurrentData).GetType().GetProperty(ctl.Tag.ToString());

            if(info != null)
            {
                string OldValue = info.GetValue(CManager.ListFiles.SingleOrDefault(x => x.Name == NameCurrentData), null).ToString();
                if (OldValue != ctl.Text)
                    btnSave.Enabled = true;                
            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CurrentData != null)
            {
                //Update
                CurrentData.Name = this.txtName.Text;
                CurrentData.Description = this.txtDescription.Text;
                CurrentData.URL = this.txtURL.Text;
                CurrentData.User = this.txtUser.Text;
                CurrentData.Password = this.txtPassword.Text;
                CurrentData.OtherText = this.txtOtherText.Text;

                var Index = CManager.ListFiles.FindIndex(x => x.Name == CurrentData.Name);
                CManager.ListFiles[Index] = CurrentData;
            }
            else
            {
                //New
                CDataEncrypt NewData = new CDataEncrypt(this.txtName.Text, this.txtDescription.Text,
                                            this.txtUser.Text, this.txtPassword.Text,
                                            this.txtURL.Text, this.txtOtherText.Text);

                CManager.ListFiles.Add(NewData);                
            }

            btnSave.Enabled = false;
            CManager.SaveDocument();
            RefreshComboBox();
            MetroMessageBox.Show(this, "The file has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);            
        }

        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            LbNew.Visible = false;
            btnSave.Enabled = false;

            string NameCurrentData = ComboBoxList.SelectedItem.ToString();
            CurrentData = CManager.ListFiles.First(x => x.Name == NameCurrentData) as CDataEncrypt;

            if (CurrentData != null)
            {
                this.txtName.Text       = CurrentData.Name;
                this.txtDescription.Text = CurrentData.Description;
                this.txtURL.Text        = CurrentData.URL;
                this.txtUser.Text       = CurrentData.User;
                this.txtPassword.Text   = CurrentData.Password;
                this.txtOtherText.Text  = CurrentData.OtherText;                
            }            
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtName.Text       = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtURL.Text        = string.Empty;
            this.txtUser.Text       = string.Empty;
            this.txtPassword.Text   = string.Empty;
            this.txtOtherText.Text  = string.Empty;            
            CManager.ListFiles.Remove(CurrentData);
            RefreshComboBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LbVersion.Text = string.Format("Version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            RefreshComboBox();                    
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

        }

        private void txtURL_ButtonClick(object sender, EventArgs e)
        {
            if(txtURL.Text.Length>3)
            {
                string Url = txtURL.Text;
                Uri uriResult;
                bool result = Uri.TryCreate(Url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if(result)
                    Process.Start(Url);
                else
                    MetroMessageBox.Show(this, "Address is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }

        }

        private void LinkChangeCredentials_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Sure, do you want change the credentials?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 100) == DialogResult.Cancel)
                return;

            FormLogin DialogLogin = new FormLogin();
            DialogLogin.ShowDialog(this,LoginOptions.CheckUser);
            
            //Enter the credentials
            if (DialogLogin.DialogResult == DialogResult.OK)
            {
                DialogLogin.Dispose();
                
                FormLogin DialogChange = new FormLogin();
                if (DialogChange.ShowDialog(this, LoginOptions.ChangeCredentials) == DialogResult.OK)
                    btnSave.Enabled = true;
                
                else
                    MetroMessageBox.Show(this, "No changes in the credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
                
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(btnSave.Enabled)
            {
                if (MetroMessageBox.Show(this, "there are changes pending saving, are you sure you want to exit?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 100) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

            }
        }

        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
                btnSave.TileTextFontWeight = MetroTileTextWeight.Bold;
            
            else
                btnSave.TileTextFontWeight = MetroTileTextWeight.Light;
        }
       
        private void btnGeneratePsw_Click(object sender, EventArgs e)
        {
            CRng keys = new CRng();

            byte[] PASS = new byte[4];
            if( keys.GenerateKey(out PASS, PASS.Length) != CWolfSsl.ReturnCode.Ok)
            {
                MetroMessageBox.Show(this, "Error generating password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return;
            }

            string strPassword = BitConverter.ToString(PASS).Replace("-", "");
            if (MetroMessageBox.Show(this, string.Format("Do you like this password {0} ?", strPassword), "New Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) == DialogResult.Yes)
                txtPassword.Text = strPassword;
        }

        private void LinkMenu_Click(object sender, EventArgs e)
        {
            MnuPopUp.Show(Cursor.Position);
        }

        #endregion

        #region METHODS

        private void RefreshComboBox()
        {            
            ComboBoxList.Items.Clear();
            ComboBoxList.Enabled = true;
            foreach (CDataEncrypt DataEncrypt in CManager.ListFiles.OrderBy( x => x.Name))
                this.ComboBoxList.Items.Add(DataEncrypt.ToString());
            
            if (ComboBoxList.Items.Count > 0)
                ComboBoxList.SelectedIndex = 0;

            if (!LbNew.Visible)
                btnNew.Text = "New";
        }

        private void ClearForm()
        {            
            this.txtDescription.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtOtherText.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtURL.Text = string.Empty;
            this.txtUser.Text = string.Empty;

        }



        #endregion
        
    }
}
