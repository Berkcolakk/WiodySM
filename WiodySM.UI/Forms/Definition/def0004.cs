using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0004 : BaseForm
    {
        int _userId = 0;
        public def0004(int userId = 0)
        {
            InitializeComponent();
            _userId = userId;

            if (_userId > 0)
            {
                var user = dbContext.User.Find(_userId);
                txtUserName.Text = user.USER_ACCESSNAME;
                txtPassword.Text = user.USER_ACCESSPASSWORD;
                txtNameSurname.Text = user.USER_NAME_SURNAME;
                txtEmail.Text = user.USER_EMAIL;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_userId > 0)
                {
                    var data = dbContext.User.Find(_userId);
                    data.USER_ACCESSNAME = txtUserName.Text;
                    data.USER_ACCESSPASSWORD = txtPassword.Text;
                    data.USER_NAME_SURNAME = txtNameSurname.Text;
                    data.USER_EMAIL = txtEmail.Text;
                    dbContext.Entry(data).State = EntityState.Modified;

                }
                else
                {
                    dbContext.User.Add(new User
                    {
                        USER_ACCESSNAME = txtUserName.Text,
                        USER_ACCESSPASSWORD = txtPassword.Text,
                        USER_NAME_SURNAME = txtNameSurname.Text,
                        USER_EMAIL = txtEmail.Text
                    });
                }
                dbContext.SaveChanges();
                this.Close();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtEmail.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtEmail.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtNameSurname.Text))
            {
                txtNameSurname.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtNameSurname.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtNameSurname.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtNameSurname.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPassword.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPassword.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtUserName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtUserName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}