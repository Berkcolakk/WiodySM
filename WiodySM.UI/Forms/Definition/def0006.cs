using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0006 : BaseForm
    {
        int _itemId = 0;
        public def0006(int itemId = 0)
        {
            InitializeComponent();
            _itemId = itemId;
            if (_itemId > 0)
            {
                var item = dbContext.Item.Find(_itemId);
                txtitemName.Text = item.ITEM_NAME;
                txtitemDescribe.Text = item.ITEM_DESCRIPTION;
                txtitemDEASSMASSMcode.Text = item.ITEM_DEASSMDE_CODE;
                txtitemDEASSMcode.Text = item.ITEM_DEASSM_CODE;
                txtitemCode.Text = item.ITEM_CODE;
                txtitemASSMcode.Text = item.ITEM_ASSM_CODE;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_itemId > 0)
                {
                    var data = dbContext.Item.Find(_itemId);
                    data.ITEM_NAME = txtitemName.Text;
                    data.ITEM_CODE = txtitemCode.Text;
                    data.ITEM_ASSM_CODE = txtitemASSMcode.Text;
                    data.ITEM_DEASSM_CODE = txtitemDEASSMcode.Text;
                    data.ITEM_DEASSMDE_CODE = txtitemDEASSMASSMcode.Text;
                    data.ITEM_DESCRIPTION = txtitemDescribe.Text;

                }
                else
                {
                    dbContext.Item.Add(new Item
                    {
                        ITEM_NAME = txtitemName.Text,
                        ITEM_CODE = txtitemCode.Text,
                        ITEM_ASSM_CODE = txtitemASSMcode.Text,
                        ITEM_DEASSM_CODE = txtitemDEASSMcode.Text,
                        ITEM_DEASSMDE_CODE = txtitemDEASSMASSMcode.Text,
                        ITEM_DESCRIPTION = txtitemDescribe.Text,
                    });
                }
                dbContext.SaveChanges();
                this.Close();
            }

        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtitemASSMcode.Text))
            {
                txtitemASSMcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemASSMcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtitemASSMcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemASSMcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtitemCode.Text))
            {
                txtitemCode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemCode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtitemCode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemCode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtitemDEASSMASSMcode.Text))
            {
                txtitemDEASSMASSMcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemDEASSMASSMcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtitemDEASSMASSMcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemDEASSMASSMcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtitemDEASSMcode.Text))
            {
                txtitemDEASSMcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemDEASSMcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtitemDEASSMcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemDEASSMcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtitemDescribe.Text))
            {
                txtitemDescribe.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemDescribe.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtitemDescribe.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemDescribe.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtitemName.Text))
            {
                txtitemName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtitemName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtitemName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }

    }
}