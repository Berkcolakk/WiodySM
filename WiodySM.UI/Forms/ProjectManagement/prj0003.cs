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
    public partial class prj0003 : BaseForm
    {
        int _projectId = 0;
        int _projectExploreId = 0;

        public prj0003(int projectId = 0, bool isEditable = true)
        {
            InitializeComponent();
            _projectId = projectId;
            itemBindingSource.DataSource = dbContext.Item.ToList();
            projectExploreBindingSource.DataSource = dbContext.ProjectExplore.Where(x => x.PROJECTEXPLORE_PROJECT_ID == _projectId).ToList();
            if (isEditable)
            {
                gcInsertGroup.Enabled = true;
            }
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            projectExploreBindingSource.DataSource = dbContext.ProjectExplore.Where(x => x.PROJECTEXPLORE_PROJECT_ID == _projectId).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_projectExploreId > 0)
                {
                    var data = dbContext.ProjectExplore.Find(_projectExploreId);
                    data.PROJECTEXPLORE_ITEMQUANTITY = Convert.ToDouble(txtQuantity.Text);
                    data.PROJECTEXPLORE_ITEMPRICE = Convert.ToDouble(txtItemPrice.Text);
                    data.PROJECTEXPLORE_ITEMASSMPRICE = Convert.ToDouble(txtAssmPrice.Text);
                    data.PROJECTEXPLORE_ITEMDEASSMPRICE = Convert.ToDouble(txtDeAssmPrice.Text);
                    data.PROJECTEXPLORE_ITEMDEASSMDEPRICE = Convert.ToDouble(txtDMMPrice.Text);
                    data.PROJECTEXPLORE_ITEM_ID = (int)lueItem.EditValue;
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.ProjectExplore.Add(new Data.Model.Entity.ProjectExplore
                    {
                        PROJECTEXPLORE_ITEMQUANTITY = Convert.ToDouble(txtQuantity.Text),
                        PROJECTEXPLORE_ITEMPRICE = Convert.ToDouble(txtItemPrice.Text),
                        PROJECTEXPLORE_ITEMASSMPRICE = Convert.ToDouble(txtAssmPrice.Text),
                        PROJECTEXPLORE_ITEMDEASSMPRICE = Convert.ToDouble(txtDeAssmPrice.Text),
                        PROJECTEXPLORE_ITEMDEASSMDEPRICE = Convert.ToDouble(txtDMMPrice.Text),
                        PROJECTEXPLORE_ITEM_ID = (int)lueItem.EditValue,
                        PROJECTEXPLORE_PROJECT_ID = _projectId
                    });
                }
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
            txtQuantity.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_ITEMQUANTITY);
            txtItemPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_ITEMPRICE);
            txtAssmPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_ITEMASSMPRICE);
            txtDeAssmPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_ITEMDEASSMPRICE);
            txtDMMPrice.EditValue = Math.Abs(existProjectExplore.PROJECTEXPLORE_ITEMDEASSMDEPRICE);
            lueItem.EditValue = existProjectExplore.PROJECTEXPLORE_ITEM_ID;
            _projectExploreId = projectExploreId;
            btnDelete.Enabled = true;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            var excelDatas = ExcelHelper.ReadExcelExpore(txtFilePath.Text);
            foreach (var row in excelDatas)
            {
                var existProjectExplore = dbContext.ProjectExplore.FirstOrDefault(x => x.PROJECTEXPLORE_PROJECT_ID == _projectId && (x.Item.ITEM_CODE == row.Code || x.Item.ITEM_ASSM_CODE == row.Code || x.Item.ITEM_DEASSM_CODE == row.Code || x.Item.ITEM_DEASSMDE_CODE == row.Code) && x.PROJECTEXPLORE_CODE == row.Code);
                if (existProjectExplore != null)
                {
                    existProjectExplore.PROJECTEXPLORE_CODE = row.Code;
                    existProjectExplore.PROJECTEXPLORE_ITEMQUANTITY = Math.Round(Convert.ToDouble(row.Quantity), 2);
                    existProjectExplore.PROJECTEXPLORE_ITEMPRICE = row.ItemPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemPrice), 2);
                    existProjectExplore.PROJECTEXPLORE_ITEMASSMPRICE = row.ItemAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemAssmPrice), 2);
                    existProjectExplore.PROJECTEXPLORE_ITEMDEASSMPRICE = row.ItemDeAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmPrice), 2);
                    existProjectExplore.PROJECTEXPLORE_ITEMDEASSMDEPRICE = row.ItemDeAssmDePrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmDePrice), 2);
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
                    projectExplore.PROJECTEXPLORE_ITEMQUANTITY = Math.Round(Convert.ToDouble(row.Quantity), 2);
                    projectExplore.PROJECTEXPLORE_ITEMPRICE = row.ItemPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemPrice), 2);
                    projectExplore.PROJECTEXPLORE_ITEMASSMPRICE = row.ItemAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemAssmPrice), 2);
                    projectExplore.PROJECTEXPLORE_ITEMDEASSMPRICE = row.ItemDeAssmPrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmPrice), 2);
                    projectExplore.PROJECTEXPLORE_ITEMDEASSMDEPRICE = row.ItemDeAssmDePrice == "" ? 0 : Math.Round(Convert.ToDouble(row.ItemDeAssmDePrice), 2);
                    dbContext.ProjectExplore.Add(projectExplore);
                }
            }
            dbContext.SaveChanges();
            LoadData();
            var project = dbContext.Project.Find(_projectId);
            EmailHelper.SendEmail("mkartal@anadoluelektrik.com.tr", "YENİ PROJE KEŞFİ BİLGİLENDİRME", project.PROJECT_PYP_NO + "'lu projede keşfi tanımlandı");
            XtraMessageBox.Show("Kayıtlar Başarıyla Aktarıldı !", "ONAY");
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            var result = excelFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = excelFileDialog.FileName;
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
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
            return validationRules;
        }

    }
}