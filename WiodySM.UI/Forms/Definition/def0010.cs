using System.Data.Entity;
using System.Drawing;
using System.Linq;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0010 : BaseForm
    {
        int _menuRoleId = 0;
        public def0010(int menuRolId = 0)
        {
            InitializeComponent();
            _menuRoleId = menuRolId;
            menuBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Menu).ToList();
            roleBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Role).ToList();
            if (_menuRoleId > 0)
            {
                var menurole = dbContext.MenuRole.Find(_menuRoleId);
                lueMenu.EditValue = menurole.MENUROLE_MENU_ID;
                lueRole.EditValue = menurole.MENUROLE_ROLE_ID;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_menuRoleId > 0)
                {
                    var data = dbContext.MenuRole.Find(_menuRoleId);
                    data.MENUROLE_MENU_ID = (int)lueRole.EditValue;
                    data.MENUROLE_ROLE_ID = (int)lueRole.EditValue;

                }
                else
                {
                    dbContext.MenuRole.Add(new MenuRole
                    {
                        MENUROLE_ROLE_ID = (int)lueRole.EditValue,
                        MENUROLE_MENU_ID = (int)lueMenu.EditValue
                    });
                }

                dbContext.SaveChanges();
                this.Close();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueMenu.EditNullableIntValue() == 0)
            {
                lueMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueMenu.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueMenu.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
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