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
using WiodySM.UI.ViewModels;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0010 : BaseForm
    {
        int _itemDemandMasterId = 0;
        int _itemDemandDetailId = 0;
        int _stockMasterId = 0;
        int _stockDetailId = 0;
        public List<TransferVM> transferList { get; set; }

        public prj0010(int itemDemandMasterId)
        {
            InitializeComponent();
            _itemDemandMasterId = itemDemandMasterId;
            var demandMaster = dbContext.ItemDemandMaster.Find(_itemDemandMasterId);
            var existStockMaster = dbContext.StockMaster.FirstOrDefault(x => x.STOCKMASTER_REF_ID == _itemDemandMasterId && x.STOCKMASTER_REF_LINK == "ItemDemandMaster");
            if (existStockMaster == null)
            {
                var stockMaster = new StockMaster
                {
                    STOCKMASTER_COMPANY_ID = demandMaster.Project.PROJECT_COMPANY_ID,
                    STOCKMASTER_SOURCESTORE_ID = demandMaster.Project.Company.COMPANY_STORE_ID.Value,
                    STOCKMASTER_TARGETSTORE_ID = demandMaster.Project.Company.COMPANY_STORE_ID.Value,
                    STOCKMASTER_TYPE_ID = StaticTypes.DemandTransfer,
                    STOCKMASTER_REF_ID = _itemDemandMasterId,
                    STOCKMASTER_REF_LINK = "ItemDemandMaster"
                };
                dbContext.StockMaster.Add(stockMaster);
                dbContext.SaveChanges();
                _stockMasterId = stockMaster.ID;
            }
            else
            {
                _stockMasterId = existStockMaster.ID;
            }
            storeBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
            LoadData();
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            stockDetailBindingSource.DataSource = dbContext.StockDetail.Where(x => x.STOCKDETAIL_MASTER_ID == _stockMasterId && x.STOCKDETAIL_QUANTITY < 0).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnMRPList_Click(object sender, EventArgs e)
        {
            prj0011 frm = new prj0011(_itemDemandMasterId, this);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (transferList == null)
                return;
            var demandMaster = dbContext.ItemDemandMaster.Find(_itemDemandMasterId);

            foreach (var item in transferList)
            {
                var existStockDetail = StockHelper.GetBarcodeStocks(item.BarcodeId);
                var stockDetail = new StockDetail();
                stockDetail.STOCKDETAIL_BARCODE_ID = item.BarcodeId;
                stockDetail.STOCKDETAIL_MASTER_ID = _stockMasterId;
                stockDetail.STOCKDETAIL_STORE_ID = existStockDetail.STOCKDETAIL_STORE_ID;
                stockDetail.STOCKDETAIL_ITEM_ID = existStockDetail.STOCKDETAIL_ITEM_ID;
                stockDetail.STOCKDETAIL_RACK_ID = existStockDetail.STOCKDETAIL_RACK_ID;
                stockDetail.STOCKDETAIL_QUANTITY = Convert.ToDouble(item.Quantity) * -1;
                dbContext.StockDetail.Add(stockDetail);
                dbContext.SaveChanges();

                var stockDetailSecond = new StockDetail();
                stockDetailSecond.STOCKDETAIL_BARCODE_ID = item.BarcodeId;
                stockDetailSecond.STOCKDETAIL_MASTER_ID = _stockMasterId;
                stockDetailSecond.STOCKDETAIL_STORE_ID = demandMaster.Project.Company.COMPANY_STORE_ID.Value;
                stockDetailSecond.STOCKDETAIL_ITEM_ID = existStockDetail.STOCKDETAIL_ITEM_ID;
                stockDetailSecond.STOCKDETAIL_RACK_ID = existStockDetail.STOCKDETAIL_RACK_ID;
                stockDetailSecond.STOCKDETAIL_QUANTITY = Convert.ToDouble(item.Quantity);
                stockDetailSecond.STOCKDETAIL_REF_ID = stockDetail.ID;
                dbContext.StockDetail.Add(stockDetailSecond);
                dbContext.SaveChanges();
            }
            LoadData();
            transferList.Clear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int stockDetailId = gvStockDetail.GetNullableRowCellValue();
            if (stockDetailId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.StockDetail.Remove(dbContext.StockDetail.Find(stockDetailId));
                dbContext.StockDetail.Remove(dbContext.StockDetail.FirstOrDefault(x => x.STOCKDETAIL_REF_ID == stockDetailId));
                dbContext.SaveChanges();
            }
            ClearControl();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                var demandMaster = dbContext.ItemDemandMaster.Find(_itemDemandMasterId);
                double quantity = Convert.ToDouble(txtQuantity.EditValue == "" ? 0 : txtQuantity.EditValue);
                if (_stockDetailId == 0)
                {
                    string barcode = BarcodeHelper.BarcodeVerify(txtBarcode.EditValue.ToString());
                    var barcodeStockDetail = StockHelper.GetBarcodeStocksWithStore(barcode, (int)lueStore.EditValue);
                    if (barcodeStockDetail == null)
                    {
                        MessageBox.Show("Ürün Bulunamadı !");
                        txtBarcode.EditValue = "";
                        txtBarcode.Focus();
                        return;
                    }
                    var stockDetail = new StockDetail();
                    stockDetail.STOCKDETAIL_BARCODE_ID = barcode;
                    stockDetail.STOCKDETAIL_MASTER_ID = _stockMasterId;
                    stockDetail.STOCKDETAIL_STORE_ID = (int)lueStore.EditValue;
                    stockDetail.STOCKDETAIL_ITEM_ID = barcodeStockDetail.STOCKDETAIL_ITEM_ID;
                    stockDetail.STOCKDETAIL_RACK_ID = barcodeStockDetail.STOCKDETAIL_RACK_ID;
                    stockDetail.STOCKDETAIL_QUANTITY = quantity * -1;
                    dbContext.StockDetail.Add(stockDetail);
                    dbContext.SaveChanges();

                    var stockDetailSecond = new StockDetail();
                    stockDetailSecond.STOCKDETAIL_BARCODE_ID = barcode;
                    stockDetailSecond.STOCKDETAIL_MASTER_ID = _stockMasterId;
                    stockDetailSecond.STOCKDETAIL_STORE_ID = demandMaster.Project.Company.COMPANY_STORE_ID.Value;
                    stockDetailSecond.STOCKDETAIL_ITEM_ID = barcodeStockDetail.STOCKDETAIL_ITEM_ID;
                    stockDetailSecond.STOCKDETAIL_RACK_ID = barcodeStockDetail.STOCKDETAIL_RACK_ID;
                    stockDetailSecond.STOCKDETAIL_QUANTITY = quantity;
                    stockDetailSecond.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : (double)txtCableStart.EditValue;
                    stockDetailSecond.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : (double)txtCableEnd.EditValue;
                    stockDetailSecond.STOCKDETAIL_REF_ID = stockDetail.ID;
                    dbContext.StockDetail.Add(stockDetailSecond);
                    dbContext.SaveChanges();
                }
                else
                {
                    var existStockDetail = dbContext.StockDetail.FirstOrDefault(x => x.ID == _stockDetailId);
                    existStockDetail.STOCKDETAIL_QUANTITY = quantity * -1;
                    var existStockDetailSecond = dbContext.StockDetail.FirstOrDefault(x => x.STOCKDETAIL_REF_ID == _stockDetailId);
                    existStockDetailSecond.STOCKDETAIL_QUANTITY = quantity;
                    existStockDetailSecond.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : (double)txtCableStart.EditValue;
                    existStockDetailSecond.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : (double)txtCableEnd.EditValue;
                    dbContext.SaveChanges();
                }
                ClearControl();
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
            txtBarcode.EditValue = existStockDetail.STOCKDETAIL_BARCODE_ID;
            txtQuantity.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_QUANTITY);
            txtCableStart.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_PRIVATEVALUE1.Value);
            txtCableEnd.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_PRIVATEVALUE2.Value);
            _stockDetailId = stockDetailId;
            btnDelete.Enabled = true;
        }
        void ClearControl()
        {
            txtBarcode.EditValue = "";
            txtQuantity.EditValue = "";
            txtCableStart.EditValue = "";
            txtCableEnd.EditValue = "";
            txtBarcode.Focus();
            _stockDetailId = 0;
        }

        private void btnItemDemandDetail_Click(object sender, EventArgs e)
        {
            prj0007 frm = new prj0007(_itemDemandMasterId, false);
            frm.Show();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueStore.EditNullableIntValue() == 0)
            {
                lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtBarcode.Text))
            {
                lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
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