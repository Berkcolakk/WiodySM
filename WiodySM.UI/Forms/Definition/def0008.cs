using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0008 : BaseForm
    {
        int _contractId = 0;
        public def0008(int contractId = 0)
        {
            InitializeComponent();
            _contractId = contractId;
            masterContractBindingSource.DataSource = dbContext.Contract.ToList();
            if (_contractId > 0)
            {
                var contract = dbContext.Contract.Find(_contractId);
                txtContractName.Text = contract.CONTRACT_NAME;
                txtTotalPrice.Text = contract.CONTRACT_TOTALPRICE.ToString();
                txtPriceCut.Text = contract.CONTRACT_PRICECUTRATE.ToString();
                deContractDate.EditValue = contract.CONTRACT_DATE;
                lueMasterContract.EditValue = contract.CONTRACT_MASTER_ID;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_contractId > 0)
                {
                    var data = dbContext.Contract.Find(_contractId);
                    data.CONTRACT_NAME = txtContractName.Text;
                    data.CONTRACT_TOTALPRICE = double.Parse(txtTotalPrice.Text);
                    data.CONTRACT_PRICECUTRATE = double.Parse(txtPriceCut.Text);
                    data.CONTRACT_MASTER_ID = lueMasterContract.EditNullableIntValue();
                    if (deContractDate.EditValue != null)
                    {
                        data.CONTRACT_DATE = (DateTime)deContractDate.EditValue;
                    }
                }
                else
                {
                    var contract = new Contract();
                    contract.CONTRACT_NAME = txtContractName.Text;
                    contract.CONTRACT_TOTALPRICE = double.Parse(txtTotalPrice.Text);
                    contract.CONTRACT_PRICECUTRATE = double.Parse(txtPriceCut.Text);
                    contract.CONTRACT_MASTER_ID = lueMasterContract.EditNullableIntValue();
                    if (deContractDate.EditValue != null)
                    {
                        contract.CONTRACT_DATE = (DateTime)deContractDate.EditValue;
                    }
                    dbContext.Contract.Add(contract);
                }
                dbContext.SaveChanges();
                this.Close();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtContractName.Text))
            {
                txtContractName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtContractName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtContractName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtContractName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtPriceCut.Text))
            {
                txtPriceCut.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPriceCut.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtPriceCut.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPriceCut.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtTotalPrice.Text))
            {
                txtTotalPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtTotalPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtTotalPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtTotalPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (deContractDate.EditValue == null)
            {
                deContractDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                deContractDate.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                deContractDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                deContractDate.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (lueMasterContract.EditNullableIntValue() == 0)
            {
                lueMasterContract.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueMasterContract.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueMasterContract.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueMasterContract.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }

    }
}