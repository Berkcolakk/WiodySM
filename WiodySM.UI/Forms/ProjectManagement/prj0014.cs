using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0014 : BaseForm
    {
        public prj0014()
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
            itemDemandMasterBindingSource.DataSource = dbContext.ItemDemandMaster.Where(x => x.ITEMDEMANDMASTER_ITEMCONFIRMATION == true).ToList();
        }

        private void btnItemDemandDetail_Click(object sender, EventArgs e)
        {
            int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            if (itemDemandMasterId == 0)
                return;
            prj0007 frm = new prj0007(itemDemandMasterId, false);
            frm.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            var messageBox = XtraMessageBox.Show("Onaylanacak Emin Misiniz?", "Onay Bekleniyor !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (messageBox == DialogResult.Yes)
            {
                ItemDemandMaster itemDemandMaster = dbContext.ItemDemandMaster.SingleOrDefault(x => x.ID == itemDemandMasterId);
                itemDemandMaster.ITEMDEMANDMASTER_ITEMCONFIRMATION = false;
                List<ItemDemandDetail> itemDemandDetail = dbContext.ItemDemandDetail.Where(x => x.ITEMDEMANDDETAIL_MASTER_ID == itemDemandMaster.ID).ToList();
                for (int i = 0; i < itemDemandDetail.Count; i++)
                {
                    itemDemandDetail[i].ITEMDEMANDDETAIL_ITEM_CONFIRMATION = false;
                    dbContext.SaveChanges();
                }
                LoadData();
            }
            else if (messageBox == DialogResult.No)
            {
            }
        }

    private void btnDecline_Click(object sender, EventArgs e)
    {
        var messageBox = XtraMessageBox.Show("İşaretlenmiş Olan Kayıtlar Silinmiştir !", "Kayıtlar Silinmiştir !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
        if (messageBox == DialogResult.Yes)
        {
            ItemDemandMaster itemDemandMaster = dbContext.ItemDemandMaster.SingleOrDefault(x => x.ID == itemDemandMasterId);
            List<ItemDemandDetail> itemDemandDetail = dbContext.ItemDemandDetail.Where(x => x.ITEMDEMANDDETAIL_MASTER_ID == itemDemandMaster.ID).ToList();
            dbContext.ItemDemandMaster.Remove(itemDemandMaster);
            dbContext.ItemDemandDetail.RemoveRange(itemDemandDetail);
            dbContext.SaveChanges();
            LoadData();
        }
        else if (messageBox == DialogResult.No)
        {
        }
    }

        private void prj0014_Load(object sender, EventArgs e)
        {

        }
    }
}