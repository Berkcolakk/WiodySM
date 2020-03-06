using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WiodySM.Data.Model.Context;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0002 : BaseForm
    {
        int _companyId = 0;
        public def0002(int companyId = 0)
        {
            InitializeComponent();
            _companyId = companyId;
            if (_companyId > 0)
            {
                var company = dbContext.Company.Find(_companyId);
                txtCompanyName.Text = company.COMPANY_COMPANY_NAME;
                txtAddress.Text = company.COMPANY_ADRESS;
                txtFax.Text = company.COMPANY_FAX;
                txtPhone.Text = company.COMPANY_PHONE;
                txtTaxName.Text = company.COMPANY_TAXNAME;
                txtTaxNo.Text = company.COMPANY_TAXNUMBER;
                chkSubcontractor.EditValue = company.COMPANY_SUBCONTRACTOR;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_companyId > 0)
                {
                    var data = dbContext.Company.Find(_companyId);
                    var parameterDetail = dbContext.ParameterDetail.Find(data.COMPANY_STORE_ID);
                    parameterDetail.PARAMETERDETAIL_NAME = txtCompanyName.Text + " " + "DEPO";
                    parameterDetail.PARAMETERDETAIL_MASTER_ID = StaticTypes.Store;
                    dbContext.Entry(parameterDetail).State = EntityState.Modified;

                    data.COMPANY_COMPANY_NAME = txtCompanyName.Text;
                    data.COMPANY_TAXNAME = txtTaxName.Text;
                    data.COMPANY_TAXNUMBER = txtTaxNo.Text;
                    data.COMPANY_PHONE = txtPhone.Text;
                    data.COMPANY_FAX = txtFax.Text;
                    data.COMPANY_ADRESS = txtAddress.Text;
                    data.COMPANY_STORE_ID = parameterDetail.ID;
                    data.COMPANY_SUBCONTRACTOR = (bool)chkSubcontractor.EditValue;
                    dbContext.Entry(data).State = EntityState.Modified;
                }
                else
                {
                    var parameterDetail = dbContext.ParameterDetail.Add(new ParameterDetail
                    {
                        ISACTIVE = true,
                        PARAMETERDETAIL_NAME = txtCompanyName.Text + " " + "DEPO",
                        PARAMETERDETAIL_MASTER_ID = StaticTypes.Store

                    });
                    dbContext.Company.Add(new Company
                    {
                        COMPANY_COMPANY_NAME = txtCompanyName.Text,
                        COMPANY_TAXNAME = txtTaxName.Text,
                        COMPANY_TAXNUMBER = txtTaxNo.Text,
                        COMPANY_PHONE = txtPhone.Text,
                        COMPANY_FAX = txtFax.Text,
                        COMPANY_ADRESS = txtAddress.Text,
                        COMPANY_STORE_ID = parameterDetail.ID,
                        COMPANY_SUBCONTRACTOR = (bool)chkSubcontractor.EditValue
                    });
                }

                dbContext.SaveChanges();
                this.Close();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtAddress.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtAddress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtAddress.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtCompanyName.Text))
            {
                txtCompanyName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtCompanyName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtCompanyName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtCompanyName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtFax.Text))
            {
                txtFax.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtFax.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtFax.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtFax.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPhone.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtPhone.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPhone.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtTaxName.Text))
            {
                txtTaxName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtTaxName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtTaxName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtTaxName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtTaxNo.Text))
            {
                txtTaxNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtTaxNo.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtTaxNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtTaxNo.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}