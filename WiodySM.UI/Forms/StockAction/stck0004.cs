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
using WiodySM.Data.Utilities;

namespace WiodySM.UI.Forms.StockAction
{
    public partial class stck0004 : BaseForm
    {
        int _stockMasterId = 0;
        int _stockDetailId = 0;
        int _stockMasterIdEntry = 0;
        public stck0004(int stockMasterId = 0)
        {
            InitializeComponent();
            _stockMasterId = stockMasterId;
            if (_stockMasterId > 0)
            {
                LoadData();
                var stockMaster = dbContext.StockMaster.Find(_stockMasterId);
                lueSourceStore.EditValue = stockMaster.STOCKMASTER_SOURCESTORE_ID;
                lueTargetStore.EditValue = stockMaster.STOCKMASTER_TARGETSTORE_ID;
                stockDetailDropdown.DataSource = StockHelper.GetStoreStocks(stockMaster.STOCKMASTER_TARGETSTORE_ID).Where(x => x.STOCKDETAIL_QUANTITY > 0);
                gControlMaster.Enabled = false;
            }
            else
            {
                gControlDetail.Enabled = false;
            }
            targetStoreBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
            sourceStoreBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            stockDetailBindingSource.DataSource = dbContext.StockDetail.Include(x => x.Item)
                .Where(x => x.STOCKDETAIL_MASTER_ID == _stockMasterId).Where(x => x.STOCKDETAIL_REF_LINK == "StockDetail").ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int targetStore = (int)lueTargetStore.EditValue;
            int sourceStore = (int)lueSourceStore.EditValue;
            stockDetailDropdown.DataSource = StockHelper.GetStoreStocks(targetStore).Where(x => x.STOCKDETAIL_QUANTITY > 0);
            StockMaster stockMaster2 = new StockMaster()
            {
                STOCKMASTER_TARGETSTORE_ID = targetStore,
                STOCKMASTER_SOURCESTORE_ID = sourceStore,
                STOCKMASTER_TYPE_ID = StaticTypes.Entry,
            };
            dbContext.StockMaster.Add(stockMaster2);
            dbContext.SaveChanges();
            StockMaster stockMaster = new StockMaster()
            {
                STOCKMASTER_TARGETSTORE_ID = targetStore,
                STOCKMASTER_SOURCESTORE_ID = sourceStore,
                STOCKMASTER_TYPE_ID = StaticTypes.Output,
                STOCKMASTER_REF_ID = stockMaster2.ID,
                STOCKMASTER_REF_LINK = "StockMaster"
            };

            dbContext.StockMaster.Add(stockMaster);
            dbContext.SaveChanges();
            _stockMasterId = stockMaster.ID;
            _stockMasterIdEntry = stockMaster2.ID;
            lueTargetStore.Enabled = false;
            lueSourceStore.Enabled = false;
            gControlDetail.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int targetStore = (int)lueTargetStore.EditValue;
            int sourceStore = (int)lueSourceStore.EditValue;
            string stockDetail = (string)lueStockDetail.EditValue;
            double quantity = Convert.ToDouble(txtQuantity.EditValue == "" ? 0 : txtQuantity.EditValue);
            if (_stockDetailId == 0)
            {
                var selectedStock = StockHelper.GetBarcodeStocks(stockDetail);
                StockDetail entryDetail = new StockDetail()
                {
                    STOCKDETAIL_ITEM_ID = selectedStock.STOCKDETAIL_ITEM_ID,
                    STOCKDETAIL_RACK_ID = selectedStock.STOCKDETAIL_RACK_ID,
                    STOCKDETAIL_BARCODE_ID = selectedStock.STOCKDETAIL_BARCODE_ID,
                    STOCKDETAIL_STORE_ID = sourceStore,
                    STOCKDETAIL_QUANTITY = quantity,
                    STOCKDETAIL_MASTER_ID = _stockMasterIdEntry,


                };
                dbContext.StockDetail.Add(entryDetail);
                dbContext.SaveChanges();
                dbContext.StockDetail.Add(new StockDetail
                {
                    STOCKDETAIL_ITEM_ID = selectedStock.STOCKDETAIL_ITEM_ID,
                    STOCKDETAIL_RACK_ID = selectedStock.STOCKDETAIL_RACK_ID,
                    STOCKDETAIL_BARCODE_ID = selectedStock.STOCKDETAIL_BARCODE_ID,
                    STOCKDETAIL_STORE_ID = targetStore,
                    STOCKDETAIL_QUANTITY = quantity * -1,
                    STOCKDETAIL_MASTER_ID = _stockMasterId,
                    STOCKDETAIL_REF_ID = entryDetail.ID,
                    STOCKDETAIL_REF_LINK = "StockDetail"
                });
            }
            else
            {
                StockDetail existStockDetail = dbContext.StockDetail.Find(_stockDetailId);
                existStockDetail.STOCKDETAIL_ITEM_ID = existStockDetail.STOCKDETAIL_ITEM_ID;
                existStockDetail.STOCKDETAIL_RACK_ID = existStockDetail.STOCKDETAIL_RACK_ID;
                existStockDetail.STOCKDETAIL_BARCODE_ID = existStockDetail.STOCKDETAIL_BARCODE_ID;
                existStockDetail.STOCKDETAIL_STORE_ID = targetStore;
                existStockDetail.STOCKDETAIL_QUANTITY = quantity;
                existStockDetail.STOCKDETAIL_MASTER_ID = _stockMasterId;
                StockDetail existStockDetail2 = dbContext.StockDetail.SingleOrDefault(x => x.ID == existStockDetail.STOCKDETAIL_REF_ID);
                existStockDetail2.STOCKDETAIL_QUANTITY = quantity * -1;
                existStockDetail2.STOCKDETAIL_ITEM_ID = existStockDetail.STOCKDETAIL_ITEM_ID;
                existStockDetail2.STOCKDETAIL_RACK_ID = existStockDetail.STOCKDETAIL_RACK_ID;
                existStockDetail2.STOCKDETAIL_BARCODE_ID = existStockDetail.STOCKDETAIL_BARCODE_ID;
                existStockDetail2.STOCKDETAIL_STORE_ID = targetStore;
                existStockDetail2.STOCKDETAIL_MASTER_ID = _stockMasterId;
                _stockDetailId = 0;
            }
            dbContext.SaveChanges();
            lueStockDetail.EditValue = "";
            txtQuantity.Text = "";
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int stockDetailId = gvStockDetail.GetNullableRowCellValue();
            if (stockDetailId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                var outputFindDetail = dbContext.StockDetail.Find(stockDetailId);
                var entryFindDetail = dbContext.StockDetail.SingleOrDefault(x => x.ID == outputFindDetail.STOCKDETAIL_REF_ID);
                dbContext.StockDetail.Remove(entryFindDetail);
                dbContext.StockDetail.Remove(outputFindDetail);
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
            lueStockDetail.EditValue = existStockDetail.STOCKDETAIL_BARCODE_ID;
            txtQuantity.EditValue = existStockDetail.STOCKDETAIL_QUANTITY;
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
        //    if (lueSourceStore.EditNullableIntValue() == 0)
        //    {
        //        lueSourceStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueSourceStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueSourceStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueSourceStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
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
        //    if (lueTargetStore.EditNullableIntValue() == 0)
        //    {
        //        lueTargetStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueTargetStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
        //        validationRules = false;
        //    }
        //    else
        //    {
        //        lueTargetStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        //        lueTargetStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
        //        validationRules = true;
        //    }
        //    return validationRules;
        //}
    }
}