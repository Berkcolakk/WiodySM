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
using WiodySM.Data.Model.Context;
using WiodySM.Data.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0006 : BaseForm
    {

        public prj0006()
        {
            InitializeComponent();
            projectBindingSource.DataSource = dbContext.Project.ToList();
            LoadData();
        }

        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            itemDemandMasterBindingSource.DataSource = dbContext.ItemDemandMaster.Where(x => x.ITEMDEMANDMASTER_USER_ID == SystemActive.UserId).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                var project = dbContext.Project.Find((int)lueProject.EditValue);
                if (!project.PROJECT_ISDELIVERYEXPLORE)
                {
                    XtraMessageBox.Show("Yer teslim keşfi girilmeden malzeme talebi yapılamaz !", "UYARI");
                    return;
                }
                dbContext.ItemDemandMaster.Add(new Data.Model.Entity.ItemDemandMaster
                {
                    ITEMDEMANDMASTER_PROJECT_ID = (int)lueProject.EditValue,
                    ITEMDEMANDMASTER_USER_ID = SystemActive.UserId,
                    ITEMDEMANDMASTER_STATE_ID = StaticTypes.Wait
                });
                lueProject.EditValue = null;
                dbContext.SaveChanges();
                LoadData();
                var user = dbContext.User.Find(SystemActive.UserId);

                EmailHelper.SendEmail("mkartal@anadoluelektrik.com.tr", "YENİ MALZEME TALEBİ BİLGİLENDİRME", project.PROJECT_PYP_NO + "'lu projeden  yeni malzeme talebi tanımlandı. Tanımlayan : " + user.USER_NAME_SURNAME);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            if (itemDemandMasterId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.ItemDemandMaster.Remove(dbContext.ItemDemandMaster.Find(itemDemandMasterId));
                dbContext.SaveChanges();
            }
            LoadData();
        }

        private void btnItemDemandDetail_Click(object sender, EventArgs e)
        {
            int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            if (itemDemandMasterId == 0)
                return;
            prj0007 frm = new prj0007(itemDemandMasterId);
            frm.Show();
        }

        private void btnProjectExplore_Click(object sender, EventArgs e)
        {
            if (lueProject.EditValue == null || lueProject.EditValue == "")
            {
                XtraMessageBox.Show("Lütfen proje seçin !", "UYARI");
                return;
            }
            prj0013 frm = new prj0013((int)lueProject.EditValue);
            frm.Show();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueProject.EditNullableIntValue() == 0)
            {
                lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}