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
    public partial class prj0012 : BaseForm
    {
        int _projectId = 0;
        int _stockMasterId = 0;

        public prj0012(int stockMasterId)
        {
            InitializeComponent();
            var stockMaster = dbContext.StockMaster.Find(stockMasterId);
            _projectId = stockMaster.STOCKMASTER_REF_ID.Value;
            _stockMasterId = stockMasterId;
            LoadData();
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            var project = dbContext.Project.Find(_projectId);
            activeStockDetailBindingSource.DataSource = StockHelper.GetStoreStocks(project.Company.COMPANY_STORE_ID.Value);
            stockDetailBindingSource.DataSource = dbContext.StockDetail.Where(x => x.STOCKDETAIL_MASTER_ID == _stockMasterId).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                var project = dbContext.Project.Find(_projectId);
                var enterStockDetail = dbContext.StockDetail.Where(x => x.STOCKDETAIL_BARCODE_ID == lueActiveStockDetail.EditValue.ToString() && x.STOCKDETAIL_STORE_ID == project.Company.COMPANY_STORE_ID.Value && x.STOCKDETAIL_QUANTITY > 0).OrderBy(x => x.ID).FirstOrDefault();
                if (txtCableStart.Text != "")
                {
                    double cableStart = Convert.ToDouble(txtCableStart.Text);
                    double cableEnd = Convert.ToDouble(txtCableEnd.Text);
                    if (enterStockDetail.STOCKDETAIL_PRIVATEVALUE1.Value > cableStart)
                    {
                        XtraMessageBox.Show("Kablo ucu başı teslim edilen değerden küçük olamaz.", "HATA");
                        return;
                    }
                    if (enterStockDetail.STOCKDETAIL_PRIVATEVALUE2.Value < cableEnd)
                    {
                        XtraMessageBox.Show("Kablo ucu sonu teslim edilen değerden büyük olamaz.", "HATA");
                        return;
                    }
                    txtQuantity.Text = (cableEnd - cableStart).ToString();
                }

                var existStockDetail = StockHelper.GetBarcodeStocks(lueActiveStockDetail.EditValue.ToString());
                var stockDetail = new StockDetail();
                stockDetail.STOCKDETAIL_BARCODE_ID = existStockDetail.STOCKDETAIL_BARCODE_ID;
                stockDetail.STOCKDETAIL_MASTER_ID = _stockMasterId;
                stockDetail.STOCKDETAIL_STORE_ID = project.Company.COMPANY_STORE_ID.Value;
                stockDetail.STOCKDETAIL_ITEM_ID = existStockDetail.STOCKDETAIL_ITEM_ID;
                stockDetail.STOCKDETAIL_RACK_ID = existStockDetail.STOCKDETAIL_RACK_ID;
                stockDetail.STOCKDETAIL_QUANTITY = Convert.ToDouble(txtQuantity.Text) * -1;
                stockDetail.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : (double)txtCableStart.EditValue;
                stockDetail.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : (double)txtCableEnd.EditValue;
                stockDetail.STOCKDETAIL_REF_ID = _projectId;
                stockDetail.STOCKDETAIL_REF_LINK = "ProjectOutput";
                dbContext.StockDetail.Add(stockDetail);
                txtQuantity.EditValue = "";
                txtCableStart.EditValue = "";
                txtCableEnd.EditValue = "";
                lueActiveStockDetail.EditValue = null;
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int stockDetailId = gvStockDetail.GetNullableRowCellValue();
            if (stockDetailId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.StockDetail.Remove(dbContext.StockDetail.Find(stockDetailId));
                dbContext.SaveChanges();
            }
            LoadData();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueActiveStockDetail.EditNullableIntValue() == 0)
            {
                lueActiveStockDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueActiveStockDetail.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueActiveStockDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueActiveStockDetail.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtCableEnd.Text))
            {
                txtCableEnd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtCableEnd.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtCableEnd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtCableEnd.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtCableStart.Text))
            {
                txtCableStart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtCableStart.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtCableStart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtCableStart.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
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