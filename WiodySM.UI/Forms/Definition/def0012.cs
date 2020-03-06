using System.Data.Entity;
using System.Drawing;
using System.Linq;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0012 : BaseForm
    {
        int _userRoleId = 0;
        public def0012(int userRoleId = 0)
        {
            InitializeComponent();
            _userRoleId = userRoleId;
            userBindingSource.DataSource = dbContext.User.ToList();
            roleBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Role).ToList();
            if (_userRoleId > 0)
            {
                var userrole = dbContext.UserRole.Find(_userRoleId);
                lueUser.EditValue = userrole.USERROLE_USER_ID;
                lueRole.EditValue = userrole.USERROLE_ROLE_ID;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_userRoleId > 0)
                {
                    var data = dbContext.UserRole.Find(_userRoleId);
                    data.USERROLE_ROLE_ID = (int)lueRole.EditValue;
                    data.USERROLE_USER_ID = (int)lueUser.EditValue;

                }
                else
                {
                    dbContext.UserRole.Add(new UserRole
                    {
                        USERROLE_ROLE_ID = (int)lueRole.EditValue,
                        USERROLE_USER_ID = (int)lueUser.EditValue
                    });
                }
                dbContext.SaveChanges();
                this.Close();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueUser.EditNullableIntValue() == 0)
            {
                lueUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueUser.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueUser.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (lueRole.EditNullableIntValue() == 0)
            {
                lueRole.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueRole.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueRole.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueRole.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}