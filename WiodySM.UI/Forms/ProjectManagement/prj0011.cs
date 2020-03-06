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
    public partial class prj0011 : BaseForm
    {
        int _itemDemandMasterId = 0;
        public prj0010 _parent;

        public prj0011(int itemDemandMasterId, prj0010 parent)
        {
            InitializeComponent();
            _itemDemandMasterId = itemDemandMasterId;
            _parent = parent;
            LoadData();
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
          
            var itemIds = dbContext.ItemDemandDetail.Where(x => x.ITEMDEMANDDETAIL_MASTER_ID == _itemDemandMasterId).Select(x => x.ITEMDEMANDDETAIL_ITEM_ID).ToList();
            stockDetailBindingSource.DataSource = StockHelper.GetItemsStocksDetail(itemIds);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTransferSelecteds_Click(object sender, EventArgs e)
        {
            List<TransferVM> transferList = new List<TransferVM>();
            for (int i = 0; i < gvStockDetail.SelectedRowsCount; i++)
            {
                string rowId = (string)gvStockDetail.GetRowCellValue(gvStockDetail.GetSelectedRows()[i], "STOCKDETAIL_BARCODE_ID");
                double quantity = (double)gvStockDetail.GetRowCellValue(gvStockDetail.GetSelectedRows()[i], "STOCKDETAIL_QUANTITY");
                transferList.Add(new TransferVM {BarcodeId = rowId,Quantity = quantity.ToString() });
            }
            _parent.transferList = transferList;
            this.Close();
        }
      
    }
}