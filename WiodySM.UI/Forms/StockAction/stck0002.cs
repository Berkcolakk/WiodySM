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

namespace WiodySM.UI.Forms.StockAction
{
    public partial class stck0002 : BaseForm
    {
        int _stockMasterId = 0;
        int _stockDetailId = 0;

        public stck0002(int stockMasterId = 0)
        {
            InitializeComponent();
            _stockMasterId = stockMasterId;
            if (_stockMasterId > 0)
            {
                LoadData();
                var stockMaster = dbContext.StockMaster.Find(_stockMasterId);
                lueCompany.EditValue = stockMaster.STOCKMASTER_COMPANY_ID;
                lueSubCompany.EditValue = stockMaster.COMPANY_SUB_COMPANY_ID;
                lueStore.EditValue = stockMaster.STOCKMASTER_SOURCESTORE_ID;
                dtpWayBillDate.EditValue = stockMaster.STOCKMASTER_WAYBILL_DATE.ToString();
                txtWayBillNo.EditValue = stockMaster.STOCKMASTER_WAYBILL_NO.ToString();
                gControlMaster.Enabled = false;
                gControlDetail.Enabled = true;
            }
            else
            {
                gControlMaster.Enabled = true;
                gControlDetail.Enabled = false;
            }
            storeBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
            companyBindingSource.DataSource = dbContext.Company.ToList();
            itemBindingSource.DataSource = dbContext.Item.ToList();
            projectBindingSource.DataSource = dbContext.Project.ToList();
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            stockDetailBindingSource.DataSource = dbContext.StockDetail.Where(x => x.STOCKDETAIL_MASTER_ID == _stockMasterId).ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //if (validationResult() == true)
            //{
                var stockMaster = new StockMaster();
                stockMaster.STOCKMASTER_COMPANY_ID = (int)lueCompany.EditValue;
                stockMaster.STOCKMASTER_SOURCESTORE_ID = (int)lueStore.EditValue;
                stockMaster.STOCKMASTER_TARGETSTORE_ID = (int)lueStore.EditValue;
                stockMaster.STOCKMASTER_TYPE_ID = StaticTypes.Purchase;
                stockMaster.STOCKMASTER_WAYBILL_DATE = dtpWayBillDate.EditValue.ToString();
                stockMaster.STOCKMASTER_WAYBILL_NO = txtWayBillNo.EditValue.ToString();
                if (lueSubCompany.EditValue != string.Empty)
                {
                    stockMaster.COMPANY_SUB_COMPANY_ID = (int)lueSubCompany.EditValue;
                }
                dbContext.StockMaster.Add(stockMaster);
                dbContext.SaveChanges();
                _stockMasterId = stockMaster.ID;
                gControlMaster.Enabled = false;
                gControlDetail.Enabled = true;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (validationResult() == true)
            //{
                if (txtCableStart.Text != "")
                {
                    double cableStart = Convert.ToDouble(txtCableStart.Text);
                    double cableEnd = Convert.ToDouble(txtCableEnd.Text);
                    txtQuantity.Text = (cableEnd - cableStart).ToString();
                }
                double quantity = Convert.ToDouble(txtQuantity.EditValue == "" ? 0 : txtQuantity.EditValue);

                if (_stockDetailId == 0)
                {
                    var stockDetail = new StockDetail();
                    stockDetail.STOCKDETAIL_BARCODE_ID = BarcodeHelper.GenerateBarcode();
                    stockDetail.STOCKDETAIL_MASTER_ID = _stockMasterId;
                    stockDetail.STOCKDETAIL_STORE_ID = (int)lueStore.EditValue;
                    stockDetail.STOCKDETAIL_ITEM_ID = (int)lueItem.EditValue;
                    stockDetail.STOCKDETAIL_RACK_ID = 7;
                    stockDetail.STOCKDETAIL_QUANTITY = quantity;
                    stockDetail.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : Convert.ToDouble(txtCableStart.EditValue);
                    stockDetail.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : Convert.ToDouble(txtCableEnd.EditValue);
                    stockDetail.STOCKDETAIL_SERIALNUMBER = txtSerialNumber.Text;
                    if (lueProject.EditValue != string.Empty)
                    {
                        stockDetail.STOCKDETAIL_REF_ID = (int)lueProject.EditValue;
                    }
                    stockDetail.STOCKDETAIL_REF_LINK = "ProjectImport";

                    dbContext.StockDetail.Add(stockDetail);
                    dbContext.SaveChanges();
                    _stockDetailId = 0;
                    txtQuantity.EditValue = "";
                    txtSerialNumber.EditValue = "";
                    lueItem.EditValue = "";
                    lueProject.EditValue = "";
                    txtCableStart.EditValue = "";
                    txtCableEnd.EditValue = "";
                    btnDelete.Enabled = false;
                    lueItem.Enabled = true;
                }
                else
                {
                    var existStockDetail = dbContext.StockDetail.Find(_stockDetailId);
                    existStockDetail.STOCKDETAIL_QUANTITY = quantity;
                    existStockDetail.STOCKDETAIL_SERIALNUMBER = txtSerialNumber.Text;
                    existStockDetail.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : Convert.ToDouble(txtCableStart.EditValue);
                    existStockDetail.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : Convert.ToDouble(txtCableEnd.EditValue);
                    dbContext.SaveChanges();
                    _stockDetailId = 0;
                    txtQuantity.EditValue = "";
                    txtSerialNumber.EditValue = "";
                    lueItem.EditValue = "";
                    lueProject.EditValue = "";
                    txtCableStart.EditValue = "";
                    txtCableEnd.EditValue = "";
                    btnDelete.Enabled = false;
                    lueItem.Enabled = true;
                }
                LoadData();
            //}
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
                LoadData();
            }
        }

        private void gcStockDetail_DoubleClick(object sender, EventArgs e)
        {
            if (gvStockDetail.GroupCount > 0)
            {
                XtraMessageBox.Show("Gruplu veri üzerinde işlem yapılamaz. Grubu kaldırıp tekrar deneyin.", "Uyarı");
                return;
            }
            int stockDetailId = (int)gvStockDetail.GetRowCellValue(gvStockDetail.FocusedRowHandle, "ID");
            var existStockDetail = dbContext.StockDetail.Find(stockDetailId);
            txtQuantity.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_QUANTITY);
            txtCableStart.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_PRIVATEVALUE1.Value);
            txtCableEnd.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_PRIVATEVALUE2.Value);
            txtSerialNumber.EditValue = existStockDetail.STOCKDETAIL_SERIALNUMBER;
            lueItem.EditValue = existStockDetail.STOCKDETAIL_ITEM_ID;
            if (existStockDetail.STOCKDETAIL_REF_ID.HasValue)
            {
                lueProject.EditValue = existStockDetail.STOCKDETAIL_REF_ID.Value;
            }
            _stockDetailId = stockDetailId;
            btnDelete.Enabled = true;
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            int stockDetailId = (int)gvStockDetail.GetRowCellValue(gvStockDetail.FocusedRowHandle, "ID");
            var stockDetail = dbContext.StockDetail.FirstOrDefault(x => x.ID == stockDetailId);
            BarcodeHelper.PrintBarcode(stockDetail.STOCKDETAIL_BARCODE_ID, stockDetail.Item.ITEM_NAME, stockDetail.Item.ITEM_REF_CODE, stockDetail.STOCKDETAIL_QUANTITY.ToString(), stockDetail.Item.ParameterDetail_Item_Unit.PARAMETERDETAIL_NAME, stockDetail.STOCKDETAIL_SERIALNUMBER);
        }

        private void btnPrintBarcodeAll_Click(object sender, EventArgs e)
        {

        }

        //public bool validationResult()
        //{
        //    bool validationRules = true;
        //    if (String.IsNullOrEmpty(txtCableEnd.Text))
        //    {
        //        txtCableEnd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtCableEnd.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        txtCableEnd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtCableEnd.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (String.IsNullOrEmpty(txtCableStart.Text))
        //    {
        //        txtCableStart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtCableStart.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        txtCableStart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtCableStart.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (String.IsNullOrEmpty(txtQuantity.Text))
        //    {
        //        txtQuantity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtQuantity.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        txtQuantity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtQuantity.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (String.IsNullOrEmpty(txtSerialNumber.Text))
        //    {
        //        txtSerialNumber.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtSerialNumber.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        txtSerialNumber.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtSerialNumber.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (String.IsNullOrEmpty(txtWayBillNo.Text))
        //    {
        //        txtWayBillNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtWayBillNo.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        txtWayBillNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        txtWayBillNo.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (lueCompany.EditNullableIntValue() == 0)
        //    {
        //        lueCompany.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueCompany.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueCompany.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueCompany.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (lueItem.EditNullableIntValue() == 0)
        //    {
        //        lueItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueItem.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueItem.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (lueProject.EditNullableIntValue() == 0)
        //    {
        //        lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (lueStore.EditNullableIntValue() == 0)
        //    {
        //        lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    if (lueSubCompany.EditNullableIntValue() == 0)
        //    {
        //        lueSubCompany.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueSubCompany.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueSubCompany.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueSubCompany.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    return validationRules;
        //}
    }
}