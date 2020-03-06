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
    public partial class prj0009 : BaseForm
    {
        int _projectId = 0;

        public prj0009()
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
            itemDemandMasterBindingSource.DataSource = dbContext.ItemDemandMaster.ToList();
        }

        private void btnItemDemandDetail_Click(object sender, EventArgs e)
        {
            int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            if (itemDemandMasterId == 0)
                return;
            prj0007 frm = new prj0007(itemDemandMasterId,false);
            frm.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            if (itemDemandMasterId == 0)
                return;
            prj0010 frm = new prj0010(itemDemandMasterId);
            frm.Show();
        }
    }
}