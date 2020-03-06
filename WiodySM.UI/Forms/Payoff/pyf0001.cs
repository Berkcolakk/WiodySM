using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;
using WiodySM.Data.Model.Context;
using WiodySM.Data.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class pyf0001 : BaseForm
    {
        int _projectId = 0;

        public pyf0001()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            var projects = dbContext.ProjectManager.Where(x => x.PROJECTMANAGER_USER_ID == SystemActive.UserId).Select(x => x.Project).ToList();
            projectBindingSource.DataSource = projects;
            payoffMasterBindingSource.DataSource = dbContext.PayoffMaster/*Where(x => projects.Select(y=>y.ID).ToList().Contains(x.PAYOFFMASTER_PROJECT_ID))*/.ToList();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                var selectedProject = dbContext.Project.Find(lueProject.EditValue);
                var payoffMaster = new PayoffMaster
                {
                    PAYOFFMASTER_PROJECT_ID = selectedProject.ID,
                    PAYOFFMASTER_PARAMETERCODE = Math.Round(((100 - selectedProject.Contract.CONTRACT_PRICECUTRATE) / 100), 3)
                };
                dbContext.PayoffMaster.Add(payoffMaster);
                lueProject.EditValue = null;
                dbContext.SaveChanges();
                var excelDatas = ExcelHelper.ReadExcel(txtFilePath.Text);
                foreach (var row in excelDatas)
                {
                    if (row.PAYOFFDEFAULT_DEF1 != "")
                    {
                        var payoffdef = new PayoffDefault();
                        payoffdef.PAYOFFDEFAULT_DEF1 = row.PAYOFFDEFAULT_DEF1;
                        payoffdef.PAYOFFDEFAULT_DEF2 = row.PAYOFFDEFAULT_DEF3;
                        payoffdef.PAYOFFDEFAULT_DEF3 = row.PAYOFFDEFAULT_DEF4;
                        payoffdef.PAYOFFDEFAULT_DEF4 = row.PAYOFFDEFAULT_DEF5;
                        payoffdef.PAYOFFDEFAULT_DEF5 = row.PAYOFFDEFAULT_DEF6;
                        payoffdef.PAYOFFDEFAULT_DEF6 = row.PAYOFFDEFAULT_DEF7;
                        payoffdef.PAYOFFDEFAULT_DEF7 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF8 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF9 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF10 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF11 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF12 = row.PAYOFFDEFAULT_DEF13;
                        payoffdef.PAYOFFDEFAULT_DEF13 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF14 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF15 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF16 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF17 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF18 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF19 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_DEF20 = row.PAYOFFDEFAULT_DEF8;
                        payoffdef.PAYOFFDEFAULT_PAYOFFMASTER_ID = payoffMaster.ID;
                        dbContext.PayoffDefault.Add(payoffdef);
                    }
                }
                dbContext.SaveChanges();
                foreach (var item in dbContext.PayoffDefault.Where(x => x.PAYOFFDEFAULT_PAYOFFMASTER_ID == payoffMaster.ID).ToList())
                {
                    PayoffControl payoffControlVM = new PayoffControl();
                    payoffControlVM.PAYOFFCONTROL_LB = item.PAYOFFDEFAULT_DEF2;
                    payoffControlVM.PAYOFFCONTROL_ITEMNAME = item.PAYOFFDEFAULT_DEF5;
                    payoffControlVM.PAYOFFCONTROL_UNIT = item.PAYOFFDEFAULT_DEF6;
                    payoffControlVM.PAYOFFCONTROL_SAP = item.PAYOFFDEFAULT_DEF4;
                    payoffControlVM.PAYOFFCONTROL_TENSIZUP = Math.Round((Convert.ToDouble(item.PAYOFFDEFAULT_DEF8) / payoffMaster.PAYOFFMASTER_PARAMETERCODE), 2);
                    payoffControlVM.PAYOFFCONTROL_TENUP = Convert.ToDouble(item.PAYOFFDEFAULT_DEF8);
                    payoffControlVM.PAYOFFCONTROL_QUANTITY = Convert.ToDouble(item.PAYOFFDEFAULT_DEF12);
                    payoffControlVM.PAYOFFCONTROL_TOTALTENUP = payoffControlVM.PAYOFFCONTROL_QUANTITY * payoffControlVM.PAYOFFCONTROL_TENUP;
                    payoffControlVM.PAYOFFCONTROL_TOTALTENSIZUP = payoffControlVM.PAYOFFCONTROL_QUANTITY * payoffControlVM.PAYOFFCONTROL_TENSIZUP;
                    payoffControlVM.PAYOFFCONTROL_PAYOFFMASTER_ID = payoffMaster.ID;
                    payoffControlVM.PAYOFFCONTROL_TYPE_ID = 0;
                    dbContext.PayoffControl.Add(payoffControlVM);
                }
                dbContext.SaveChanges();
                foreach (var item in dbContext.PayoffDefault.Where(x => x.PAYOFFDEFAULT_PAYOFFMASTER_ID == payoffMaster.ID && (x.PAYOFFDEFAULT_DEF2 == "MON" || x.PAYOFFDEFAULT_DEF2 == "DM")).ToList())
                {
                    PayoffControl payoffControlVM = new PayoffControl();
                    payoffControlVM.PAYOFFCONTROL_LB = item.PAYOFFDEFAULT_DEF2;
                    payoffControlVM.PAYOFFCONTROL_ITEMNAME = item.PAYOFFDEFAULT_DEF5;
                    payoffControlVM.PAYOFFCONTROL_UNIT = item.PAYOFFDEFAULT_DEF6;
                    payoffControlVM.PAYOFFCONTROL_SAP = item.PAYOFFDEFAULT_DEF4;
                    payoffControlVM.PAYOFFCONTROL_TENSIZUP = Math.Round((Convert.ToDouble(item.PAYOFFDEFAULT_DEF8) / payoffMaster.PAYOFFMASTER_PARAMETERCODE), 2);
                    payoffControlVM.PAYOFFCONTROL_TENUP = Convert.ToDouble(item.PAYOFFDEFAULT_DEF8);
                    payoffControlVM.PAYOFFCONTROL_QUANTITY = Convert.ToDouble(item.PAYOFFDEFAULT_DEF12);
                    payoffControlVM.PAYOFFCONTROL_TOTALTENUP = payoffControlVM.PAYOFFCONTROL_QUANTITY * payoffControlVM.PAYOFFCONTROL_TENUP;
                    payoffControlVM.PAYOFFCONTROL_TOTALTENSIZUP = payoffControlVM.PAYOFFCONTROL_QUANTITY * payoffControlVM.PAYOFFCONTROL_TENSIZUP;
                    payoffControlVM.PAYOFFCONTROL_PAYOFFMASTER_ID = payoffMaster.ID;
                    payoffControlVM.PAYOFFCONTROL_TYPE_ID = 1;
                    dbContext.PayoffControl.Add(payoffControlVM);
                }
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            //if (itemDemandMasterId == 0)
            //    return;
            //DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialog == DialogResult.Yes)
            //{
            //    dbContext.ItemDemandMaster.Remove(dbContext.ItemDemandMaster.Find(itemDemandMasterId));
            //    dbContext.SaveChanges();
            //}
            //LoadData();
        }


        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            var result = excelFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = excelFileDialog.FileName;
            }
        }

        private void btnPayoffBuild_Click(object sender, EventArgs e)
        {
            int payoffMasterId = gvPayoffMaster.GetNullableRowCellValue();
            if (payoffMasterId == 0)
                return;
            pyf0002 frm = new pyf0002(payoffMasterId);
            frm.Show();
        }

        public bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtFilePath.Text))
            {
                txtFilePath.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtFilePath.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtFilePath.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtFilePath.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (lueProject.EditNullableIntValue() == 0)
            {
                lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}