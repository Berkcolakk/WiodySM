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

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0013 : BaseForm
    {
        int _projectId = 0;
        int _projectExploreId = 0;

        public prj0013(int projectId = 0)
        {
            InitializeComponent();
            _projectId = projectId;
            itemBindingSource.DataSource = dbContext.Item.ToList();
            projectExploreBindingSource.DataSource = dbContext.ProjectExplore.Where(x => x.PROJECTEXPLORE_PROJECT_ID == _projectId && x.PROJECTEXPLORE_PLACEITEMQUANTITY != 0).ToList();
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            projectExploreBindingSource.DataSource = dbContext.ProjectExplore.Where(x => x.PROJECTEXPLORE_PROJECT_ID == _projectId && x.PROJECTEXPLORE_PLACEITEMQUANTITY != 0).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_projectExploreId > 0)
            {
                var data = dbContext.ProjectExplore.Find(_projectExploreId);
                data.PROJECTEXPLORE_PLACEITEMQUANTITY = Convert.ToDouble(txtQuantity.Text);
                data.PROJECTEXPLORE_PLACEITEMPRICE = Convert.ToDouble(txtItemPrice.Text);
                data.PROJECTEXPLORE_PLACEITEMASSMPRICE = Convert.ToDouble(txtAssmPrice.Text);
                data.PROJECTEXPLORE_PLACEITEMDEASSMPRICE = Convert.ToDouble(txtDeAssmPrice.Text);
                data.PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE = Convert.ToDouble(txtDMMPrice.Text);
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.ProjectExplore.Add(new Data.Model.Entity.ProjectExplore
                {
                    PROJECTEXPLORE_PLACEITEMQUANTITY = Convert.ToDouble(txtQuantity.Text),
                    PROJECTEXPLORE_PLACEITEMPRICE = Convert.ToDouble(txtItemPrice.Text),
                    PROJECTEXPLORE_PLACEITEMASSMPRICE = Convert.ToDouble(txtAssmPrice.Text),
                    PROJECTEXPLORE_PLACEITEMDEASSMPRICE = Convert.ToDouble(txtDeAssmPrice.Text),
                    PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE = Convert.ToDouble(txtDMMPrice.Text),
                    PROJECTEXPLORE_ITEM_ID = (int)lueItem.EditValue,
                    PROJECTEXPLORE_PROJECT_ID = _projectId
                });
            }
            var project = dbContext.Project.Find(_projectId);
            project.PROJECT_ISDELIVERYEXPLORE = true;
            txtQuantity.EditValue = "";
            txtItemPrice.EditValue = "";
            txtAssmPrice.EditValue = "";
            txtDeAssmPrice.EditValue = "";
            txtDMMPrice.EditValue = "";
            lueItem.EditValue = null;
            _projectExploreId = 0;
            dbContext.SaveChanges();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void gcProjectExplore_DoubleClick(object sender, EventArgs e)
        {
            if (gvProjectExplore.GroupCount > 0)
            {
                XtraMessageBox.Show("Gruplu veri üzerinde işlem yapılamaz. Grubu kaldırıp tekrar deneyin.", "Uyarı");
                return;
            }
            int projectExploreId = (int)gvProjectExplore.GetRowCellValue(gvProjectExplore.FocusedRowHandle, "ID");
            var existProjectExplore = dbContext.ProjectExplore.Find(projectExploreId);
            txtQuantity.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_PLACEITEMQUANTITY);
            txtItemPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_PLACEITEMPRICE);
            txtAssmPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_PLACEITEMASSMPRICE);
            txtDeAssmPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_PLACEITEMDEASSMPRICE);
            txtDMMPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE);
            lueItem.EditValue = existProjectExplore.PROJECTEXPLORE_ITEM_ID;
            _projectExploreId = projectExploreId;
            btnDelete.Enabled = true;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                var excelDatas = ExcelHelper.ReadExcelExpore(txtFilePath.Text);
                foreach (var row in excelDatas)
                {
                    var existProjectExplore = dbContext.ProjectExplore.FirstOrDefault(x => x.PROJECTEXPLORE_PROJECT_ID == _projectId && (x.Item.ITEM_CODE == row.Code || x.Item.ITEM_ASSM_CODE == row.Code || x.Item.ITEM_DEASSM_CODE == row.Code || x.Item.ITEM_DEASSMDE_CODE == row.Code) && x.PROJECTEXPLORE_CODE == row.Code);
                    if (existProjectExplore != null)
                    {
                        existProjectExplore.PROJECTEXPLORE_CODE = row.Code;
                        existProjectExplore.PROJECTEXPLORE_PLACEITEMQUANTITY = Math.Round(Convert.ToDouble(row.Quantity), 2);
                        existProjectExplore.PROJECTEXPLORE_PLACEITEMPRICE = row.ItemPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemPrice), 2);
                        existProjectExplore.PROJECTEXPLORE_PLACEITEMASSMPRICE = row.ItemAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemAssmPrice), 2);
                        existProjectExplore.PROJECTEXPLORE_PLACEITEMDEASSMPRICE = row.ItemDeAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmPrice), 2);
                        existProjectExplore.PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE = row.ItemDeAssmDePrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmDePrice), 2);
                    }
                    else
                    {
                        var item = dbContext.Item.FirstOrDefault(x => x.ITEM_CODE == row.Code || x.ITEM_ASSM_CODE == row.Code || x.ITEM_DEASSM_CODE == row.Code || x.ITEM_DEASSMDE_CODE == row.Code);
                        if (item == null)
                        {
                            XtraMessageBox.Show("Ürün buluamadı. Kod : " + row.Code, "HATA");
                            return;
                        }
                        ProjectExplore projectExplore = new ProjectExplore();
                        projectExplore.PROJECTEXPLORE_PROJECT_ID = _projectId;
                        projectExplore.PROJECTEXPLORE_ITEM_ID = item.ID;
                        projectExplore.PROJECTEXPLORE_CODE = row.Code;
                        projectExplore.PROJECTEXPLORE_PLACEITEMQUANTITY = Math.Round(Convert.ToDouble(row.Quantity), 2);
                        projectExplore.PROJECTEXPLORE_PLACEITEMPRICE = row.ItemPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemPrice), 2);
                        projectExplore.PROJECTEXPLORE_PLACEITEMASSMPRICE = row.ItemAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemAssmPrice), 2);
                        projectExplore.PROJECTEXPLORE_PLACEITEMDEASSMPRICE = row.ItemDeAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmPrice), 2);
                        projectExplore.PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE = row.ItemDeAssmDePrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmDePrice), 2);
                        dbContext.ProjectExplore.Add(projectExplore);
                    }
                }
                var project = dbContext.Project.Find(_projectId);
                project.PROJECT_ISDELIVERYEXPLORE = true;
                dbContext.SaveChanges();
                LoadData();
                var user = dbContext.User.Find(project.CREATED_USER_ID);
                EmailHelper.SendEmail(user.USER_EMAIL, "YENİ PROJE YER TESLİM KEŞFİ BİLGİLENDİRME", project.PROJECT_PYP_NO + "'lu projede yer teslim keşfi tanımlandı");
                EmailHelper.SendEmail("mkartal@anadoluelektrik.com.tr", "YENİ PROJE YER TESLİM KEŞFİ BİLGİLENDİRME", project.PROJECT_PYP_NO + "'lu projede yer teslim keşfi tanımlandı");
                XtraMessageBox.Show("Kayıtlar Başarıyla Aktarıldı !", "ONAY");
            }
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            var result = excelFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = excelFileDialog.FileName;
            }
        }

        private void btnProjectExplore_Click(object sender, EventArgs e)
        {
            prj0003 frm = new prj0003(_projectId, false);
            frm.Show();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueItem.EditNullableIntValue() == 0)
            {
                lueItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueItem.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueItem.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtAssmPrice.Text))
            {
                txtAssmPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtAssmPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtAssmPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtAssmPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtDeAssmPrice.Text))
            {
                txtDeAssmPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDeAssmPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtDeAssmPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDeAssmPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtDMMPrice.Text))
            {
                txtDMMPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDMMPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtDMMPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtDMMPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
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
            if (String.IsNullOrEmpty(txtItemPrice.Text))
            {
                txtItemPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtItemPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtItemPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtItemPrice.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtQuantity.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtQuantity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtQuantity.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }

    }
}