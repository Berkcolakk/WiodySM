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
    public partial class prj0007 : BaseForm
    {
        int _itemDemandMasterId = 0;
        int _itemDemandDetailId = 0;

        public prj0007(int itemDemandMasterId = 0, bool editable = true)
        {
            InitializeComponent();
            _itemDemandMasterId = itemDemandMasterId;
            var itemDemandMaster = dbContext.ItemDemandMaster.Find(_itemDemandMasterId);
            var projectExplore = dbContext.ProjectExplore.Where(x => x.PROJECTEXPLORE_PROJECT_ID == itemDemandMaster.ITEMDEMANDMASTER_PROJECT_ID).Select(x => x.PROJECTEXPLORE_ITEM_ID).ToList();
            itemBindingSource.DataSource = dbContext.Item.Where(x => projectExplore.Contains(x.ID)).ToList();
            LoadData();
            if (!editable)
            {
                gcInsert.Enabled = false;
            }
        }
        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            itemDemandDetailBindingSource.DataSource = dbContext.ItemDemandDetail.Where(x => x.ITEMDEMANDDETAIL_MASTER_ID == _itemDemandMasterId).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                if (_itemDemandDetailId > 0)
                {
                    var data = dbContext.ItemDemandDetail.SingleOrDefault(x => x.ID == _itemDemandDetailId);
                    data.ITEMDEMANDDETAIL_QUANTITY = Convert.ToDouble(txtQuantity.Text);
                    var projectExploreQuantity = dbContext.ProjectExplore.Find(data.ITEMDEMANDDETAIL_ITEM_ID).PROJECTEXPLORE_ITEMQUANTITY;
                    var itemDemandMasterConfirmation = dbContext.ItemDemandMaster.SingleOrDefault(x => x.ID == _itemDemandMasterId).ITEMDEMANDMASTER_ITEMCONFIRMATION;
                    if (Convert.ToDouble(txtQuantity.Text) > projectExploreQuantity)
                    {
                        data.ITEMDEMANDDETAIL_ITEM_CONFIRMATION = true;
                        itemDemandMasterConfirmation = true;
                        XtraMessageBox.Show("Talep Edilen Miktar Keşif Miktarından Büyük Olduğu İçin Koordinator Onay Vermesini Bekleyiniz.!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        data.ITEMDEMANDDETAIL_ITEM_CONFIRMATION = false;
                        itemDemandMasterConfirmation = false;
                    }
                    data.ITEMDEMANDDETAIL_ITEM_ID = (int)lueItem.EditValue;
                }
                else
                {
                    ItemDemandDetail itemDemandDetail = new ItemDemandDetail();
                    itemDemandDetail.ITEMDEMANDDETAIL_QUANTITY = Convert.ToDouble(txtQuantity.Text);
                    itemDemandDetail.ITEMDEMANDDETAIL_ITEM_ID = (int)lueItem.EditValue;
                    itemDemandDetail.ITEMDEMANDDETAIL_MASTER_ID = _itemDemandMasterId;
                    dbContext.ItemDemandDetail.Add(itemDemandDetail);
                    dbContext.SaveChanges();
                    var projectExploreQuantity = dbContext.ProjectExplore.SingleOrDefault(x => x.PROJECTEXPLORE_ITEM_ID == itemDemandDetail.ITEMDEMANDDETAIL_ITEM_ID).PROJECTEXPLORE_ITEMQUANTITY;
                    var itemDemandMasterConfirmation = dbContext.ItemDemandMaster.SingleOrDefault(x => x.ID == _itemDemandMasterId);
                    if (Convert.ToDouble(txtQuantity.Text) > projectExploreQuantity)
                    {
                        itemDemandDetail.ITEMDEMANDDETAIL_ITEM_CONFIRMATION = true;
                        itemDemandMasterConfirmation.ITEMDEMANDMASTER_ITEMCONFIRMATION = true;
                        XtraMessageBox.Show("Talep Edilen Miktar Keşif Miktarından Büyük Olduğu İçin Koordinator Onay Vermesini Bekleyiniz.!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        itemDemandDetail.ITEMDEMANDDETAIL_ITEM_CONFIRMATION = false;
                        itemDemandMasterConfirmation.ITEMDEMANDMASTER_ITEMCONFIRMATION = true;
                    }
                }
                txtQuantity.EditValue = "";
                lueItem.EditValue = null;
                _itemDemandDetailId = 0;
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void gcItemDemandDetail_DoubleClick(object sender, EventArgs e)
        {
            if (gvItemDemandDetail.GroupCount > 0)
            {
                XtraMessageBox.Show("Gruplu veri üzerinde işlem yapılamaz. Grubu kaldırıp tekrar deneyin.", "Uyarı");
                return;
            }
            int itemDemandDetailId = (int)gvItemDemandDetail.GetRowCellValue(gvItemDemandDetail.FocusedRowHandle, "ID");
            var existItemDemandDetail = dbContext.ItemDemandDetail.Find(itemDemandDetailId);
            txtQuantity.EditValue = Math.Abs(existItemDemandDetail.ITEMDEMANDDETAIL_QUANTITY);
            lueItem.EditValue = existItemDemandDetail.ITEMDEMANDDETAIL_ITEM_ID;
            _itemDemandDetailId = itemDemandDetailId;
            btnDelete.Enabled = true;
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
            if (String.IsNullOrEmpty(txtQuantity.Text))
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