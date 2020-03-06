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
    public partial class stck0003 : BaseForm
    {
        int _stockMasterId = 0;
        int _stockDetailId = 0;

        public stck0003(int stockMasterId = 0)
        {
            InitializeComponent();
            _stockMasterId = stockMasterId;
            if (_stockMasterId > 0)
            {
                LoadData();
                var stockMaster = dbContext.StockMaster.Find(_stockMasterId);
                lueStore.EditValue = stockMaster.STOCKMASTER_SOURCESTORE_ID;
                lueTargetStore.EditValue = stockMaster.STOCKMASTER_TARGETSTORE_ID;
                gControlMaster.Enabled = false;
                gControlDetail.Enabled = true;
            }
            else
            {
                gControlMaster.Enabled = true;
                gControlDetail.Enabled = false;
            }
            storeBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
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
            var stockMaster = new StockMaster();
            stockMaster.STOCKMASTER_TARGETSTORE_ID = (int)lueTargetStore.EditValue;
            stockMaster.STOCKMASTER_SOURCESTORE_ID = (int)lueStore.EditValue;
            stockMaster.STOCKMASTER_TYPE_ID = StaticTypes.ReturnShipping;
            dbContext.StockMaster.Add(stockMaster);
            dbContext.SaveChanges();
            _stockMasterId = stockMaster.ID;
            gControlMaster.Enabled = false;
            gControlDetail.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_stockDetailId == 0)
                {
                    string barcode = BarcodeHelper.BarcodeVerify(txtBarcode.EditValue.ToString());
                    var barcodeStockDetail = BarcodeHelper.GetBarcodeDetail(barcode, (int)lueStore.EditValue);
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
                    stockDetail.STOCKDETAIL_STORE_ID = (int)lueTargetStore.EditValue;
                    stockDetail.STOCKDETAIL_ITEM_ID = barcodeStockDetail.ItemId;
                    stockDetail.STOCKDETAIL_RACK_ID = barcodeStockDetail.RackId;
                    stockDetail.STOCKDETAIL_QUANTITY = 0;
                    stockDetail.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : Convert.ToDouble(txtCableStart.EditValue);
                    stockDetail.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : Convert.ToDouble(txtCableEnd.EditValue);
                    dbContext.StockDetail.Add(stockDetail);

                }
                else
                {
                    if (txtCableStart.Text != "")
                    {
                        double cableStart = Convert.ToDouble(txtCableStart.Text);
                        double cableEnd = Convert.ToDouble(txtCableEnd.Text);
                        txtQuantity.Text = (cableEnd - cableStart).ToString();
                    }
                    double quantity = Convert.ToDouble(txtQuantity.EditValue == "" ? 0 : txtQuantity.EditValue);
                    var existStockDetail = dbContext.StockDetail.FirstOrDefault(x => x.ID == _stockDetailId);
                    existStockDetail.STOCKDETAIL_QUANTITY = quantity;
                    existStockDetail.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : Convert.ToDouble(txtCableStart.EditValue);
                    existStockDetail.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : Convert.ToDouble(txtCableEnd.EditValue);
                }
                dbContext.SaveChanges();
                LoadData();
                btnDelete.Enabled = false;
                _stockDetailId = 0;
                txtBarcode.EditValue = "";
                txtQuantity.EditValue = "";
                txtCableStart.EditValue = "";
                txtCableEnd.EditValue = "";
                txtBarcode.Focus();
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
                _stockDetailId = 0;
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
            txtBarcode.EditValue = existStockDetail.STOCKDETAIL_BARCODE_ID;
            txtQuantity.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_QUANTITY);
            txtCableStart.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_PRIVATEVALUE1.Value);
            txtCableEnd.EditValue = Math.Abs(existStockDetail.STOCKDETAIL_PRIVATEVALUE2.Value);
            _stockDetailId = stockDetailId;
            btnDelete.Enabled = true;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string barcode = BarcodeHelper.BarcodeVerify(txtBarcode.EditValue.ToString());
                var barcodeStockDetail = BarcodeHelper.GetBarcodeDetail(barcode, (int)lueStore.EditValue);
                if (barcodeStockDetail == null)
                {
                    MessageBox.Show("Ürün Bulunamadı !");
                    txtBarcode.EditValue = "";
                    txtBarcode.Focus();
                    return;
                }
                if (_stockDetailId == 0)
                {
                    var stockDetail = new StockDetail();
                    stockDetail.STOCKDETAIL_BARCODE_ID = barcode;
                    stockDetail.STOCKDETAIL_MASTER_ID = _stockMasterId;
                    stockDetail.STOCKDETAIL_STORE_ID = (int)lueTargetStore.EditValue;
                    stockDetail.STOCKDETAIL_ITEM_ID = barcodeStockDetail.ItemId;
                    stockDetail.STOCKDETAIL_RACK_ID = barcodeStockDetail.RackId;
                    stockDetail.STOCKDETAIL_QUANTITY = 0;
                    stockDetail.STOCKDETAIL_PRIVATEVALUE1 = string.IsNullOrEmpty(txtCableStart.Text) ? 0 : Convert.ToDouble(txtCableStart.EditValue);
                    stockDetail.STOCKDETAIL_PRIVATEVALUE2 = string.IsNullOrEmpty(txtCableEnd.Text) ? 0 : Convert.ToDouble(txtCableEnd.EditValue);
                    dbContext.StockDetail.Add(stockDetail);
                    dbContext.SaveChanges();
                }
                LoadData();
                btnDelete.Enabled = false;
                _stockDetailId = 0;
                txtBarcode.EditValue = "";
                txtQuantity.EditValue = "";
                txtCableStart.EditValue = "";
                txtCableEnd.EditValue = "";
                txtBarcode.Focus();
            }
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtBarcode.Text))
            {
                txtBarcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtBarcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtBarcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtBarcode.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
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