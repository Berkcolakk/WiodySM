using System.Data;
using System.Linq;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.StockAction
{
    public partial class stck0001 : BaseForm
    {
        public stck0001()
        {
            InitializeComponent();
            stockMasterBindingSource.DataSource = dbContext.StockMaster.OrderByDescending(x => x.ID).ToList();
        }

        private void btnNewImport_Click(object sender, System.EventArgs e)
        {
            stck0002 frm = new stck0002(0);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            int stockMasterId = (int)gvStockMaster.GetRowCellValue(gvStockMaster.FocusedRowHandle, "ID");
            var stockMaster = dbContext.StockMaster.Find(stockMasterId);
            if (stockMaster.STOCKMASTER_TYPE_ID == StaticTypes.Purchase)
            {
                stck0002 frm = new stck0002(stockMasterId);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (stockMaster.STOCKMASTER_TYPE_ID == StaticTypes.ReturnShipping)
            {
                stck0003 frm = new stck0003(stockMasterId);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (stockMaster.STOCKMASTER_TYPE_ID == StaticTypes.Entry || stockMaster.STOCKMASTER_TYPE_ID == StaticTypes.Output)
            {
                stck0004 frm = new stck0004(stockMasterId);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            stck0003 frm = new stck0003(0);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            stck0004 frm = new stck0004();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}