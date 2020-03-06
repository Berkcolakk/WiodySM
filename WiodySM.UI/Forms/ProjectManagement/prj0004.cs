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
using WiodySM.Data.Model.Context;
using WiodySM.UI.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0004 : BaseForm
    {
        public prj0004()
        {
            InitializeComponent();
            var states = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == 10).ToList();
            stateBindingSource.DataSource = states;
            lueProjectState.EditValue = states.First().ID;
            LoadGrid();
        }
        void LoadGrid()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            projectBindingSource.DataSource = dbContext.Project.Where(x => x.PROJECT_STATE_ID == (int)lueProjectState.EditValue).ToList().OrderByDescending(x => x.CREATED_DATE);
        }

        private void btnProjectExplore_Click(object sender, EventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId == 0)
                return;
            prj0003 frm = new prj0003(projectId);
            frm.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId > 0)
            {
                var data = dbContext.Project.Find(projectId);
                data.PROJECT_STATE_ID = StaticTypes.Confirmed;
                dbContext.SaveChanges();
                LoadGrid();
            }
            else
            {
                XtraMessageBox.Show("Lütfen proje seçimi yapın.");
            }
        }

        private void btnUnConfirm_Click(object sender, EventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId > 0)
            {
                var data = dbContext.Project.Find(projectId);
                data.PROJECT_STATE_ID = StaticTypes.NewProject;
                dbContext.SaveChanges();
                LoadGrid();
            }
            else
            {
                XtraMessageBox.Show("Lütfen proje seçimi yapın.");
            }
        }

        private void lueProjectState_EditValueChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}