using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0002 : BaseForm
    {
        int _projectId = 0;
        public prj0002(int projectId = 0)
        {
            InitializeComponent();
            _projectId = projectId;
            companyBindingSource.DataSource = dbContext.Company.Where(x => x.COMPANY_SUBCONTRACTOR).ToList();
            typeBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Type).ToList();
            contractBindingSource.DataSource = dbContext.Contract.ToList();
            if (_projectId > 0)
            {
                var data = dbContext.Project.Find(_projectId);
                txtProjectName.Text = data.PROJECT_NAME;
                txtPYP.Text = data.PROJECT_PYP_NO;
                txtDay.Text = data.PROJECT_DAY.ToString();
                txtDesc.Text = data.PROJECT_DESC;
                txtGroup.Text = data.PROJECT_GROUP;
                txtConstructorPrice.Text = data.PROJECT_CONSTRUCTORPRICE.ToString();
                txtDiscountedPrice.Text = data.PROJECT_DISCOUNTEDPRICE.ToString();
                txtExplorePrice.Text = data.PROJECT_EXPLOREPRICE.ToString();
                txtOwnerPrice.Text = data.PROJECT_OWNERPRICE.ToString();
                dtpWorkOrderDate.EditValue = data.PROJECT_WORKORDERDATE;
                dtpDelivery.EditValue = data.PROJECT_DELIVERYDATE;
                lueCompany.EditValue = data.PROJECT_COMPANY_ID;
                lueType.EditValue = data.PROJECT_TYPE_ID;
                lueContract.EditValue = data.PROJECT_CONTRACT_ID;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_projectId > 0)
                {
                    var data = dbContext.Project.Find(_projectId);
                    data.PROJECT_NAME = txtProjectName.Text;
                    data.PROJECT_PYP_NO = txtPYP.Text;
                    data.PROJECT_DAY = Convert.ToInt32(txtDay.Text);
                    data.PROJECT_COMPANY_ID = (int)lueCompany.EditValue;
                    data.PROJECT_TYPE_ID = (int)lueType.EditValue;
                    data.PROJECT_CONTRACT_ID = (int)lueContract.EditValue;
                    data.PROJECT_DESC = txtDesc.Text;
                    data.PROJECT_GROUP = txtGroup.Text;
                    data.PROJECT_CONSTRUCTORPRICE = double.Parse(txtConstructorPrice.Text);
                    data.PROJECT_DISCOUNTEDPRICE = double.Parse(txtDiscountedPrice.Text);
                    data.PROJECT_EXPLOREPRICE = double.Parse(txtExplorePrice.Text);
                    data.PROJECT_OWNERPRICE = double.Parse(txtOwnerPrice.Text);

                    if (dtpWorkOrderDate.EditValue != null)
                    {
                        data.PROJECT_WORKORDERDATE = (DateTime)dtpWorkOrderDate.EditValue;
                    }
                    if (dtpDelivery.EditValue != null)
                    {
                        data.PROJECT_DELIVERYDATE = (DateTime)dtpDelivery.EditValue;
                    }
                }
                else
                {

                    Project project = new Project();
                    project.PROJECT_NAME = txtProjectName.Text;
                    project.PROJECT_PYP_NO = txtPYP.Text;
                    project.PROJECT_DAY = Convert.ToInt32(txtDay.Text);
                    project.PROJECT_COMPANY_ID = (int)lueCompany.EditValue;
                    project.PROJECT_TYPE_ID = (int)lueType.EditValue;
                    project.PROJECT_CONTRACT_ID = (int)lueContract.EditValue;
                    project.PROJECT_STATE_ID = StaticTypes.NewProject;
                    project.PROJECT_EXPLORESTATE_ID = StaticTypes.ExploreUnConfirmed;
                    project.PROJECT_DESC = txtDesc.Text;
                    project.PROJECT_GROUP = txtGroup.Text;
                    project.PROJECT_CONSTRUCTORPRICE = double.Parse(txtConstructorPrice.Text);
                    project.PROJECT_DISCOUNTEDPRICE = double.Parse(txtDiscountedPrice.Text);
                    project.PROJECT_EXPLOREPRICE = double.Parse(txtExplorePrice.Text);
                    project.PROJECT_OWNERPRICE = double.Parse(txtOwnerPrice.Text);
                    if (dtpWorkOrderDate.EditValue != null)
                    {
                        project.PROJECT_WORKORDERDATE = (DateTime)dtpWorkOrderDate.EditValue;
                    }
                    if (dtpDelivery.EditValue != null)
                    {
                        project.PROJECT_DELIVERYDATE = (DateTime)dtpDelivery.EditValue;
                    }
                    dbContext.Project.Add(project);

                }
                dbContext.SaveChanges();
                this.Close();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtConstructorPrice.Text))
            {
                txtConstructorPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtConstructorPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtConstructorPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtConstructorPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtDay.Text))
            {
                txtDay.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDay.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtDay.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDay.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtDesc.Text))
            {
                txtDesc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDesc.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtDesc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDesc.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtDiscountedPrice.Text))
            {
                txtDiscountedPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDiscountedPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtDiscountedPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDiscountedPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtExplorePrice.Text))
            {
                txtExplorePrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtExplorePrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtExplorePrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtExplorePrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtGroup.Text))
            {
                txtGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtGroup.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtGroup.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtOwnerPrice.Text))
            {
                txtOwnerPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtOwnerPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtOwnerPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtOwnerPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtProjectName.Text))
            {
                txtProjectName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtProjectName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtProjectName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtProjectName.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtOwnerPrice.Text))
            {
                txtOwnerPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtOwnerPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtOwnerPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtOwnerPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtPYP.Text))
            {
                txtPYP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPYP.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtPYP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPYP.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (lueCompany.EditNullableIntValue() == 0)
            {
                lueCompany.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueCompany.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueCompany.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueCompany.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (lueType.EditNullableIntValue() == 0)
            {
                lueType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueType.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueType.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (lueContract.EditNullableIntValue() == 0)
            {
                lueContract.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueContract.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueContract.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueContract.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(dtpWorkOrderDate.Text))
            {
                dtpWorkOrderDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                dtpWorkOrderDate.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                dtpWorkOrderDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                dtpWorkOrderDate.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(dtpDelivery.Text))
            {
                dtpDelivery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                dtpDelivery.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                dtpDelivery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                dtpDelivery.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }

    }
}