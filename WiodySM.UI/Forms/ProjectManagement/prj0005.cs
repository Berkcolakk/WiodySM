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
    public partial class prj0005 : BaseForm
    {
        int _projectId = 0;

        public prj0005()
        {
            InitializeComponent();
            userBindingSource.DataSource = dbContext.User.ToList();
            LoadData();
        }

        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            projectBindingSource.DataSource = dbContext.Project.ToList();
        }

        private void LoadManagerData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            projectManagerBindingSource.DataSource = dbContext.ProjectManager.Where(x => x.PROJECTMANAGER_PROJECT_ID == _projectId).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                dbContext.ProjectManager.Add(new Data.Model.Entity.ProjectManager
                {
                    PROJECTMANAGER_USER_ID = (int)lueUser.EditValue,
                    PROJECTMANAGER_PROJECT_ID = _projectId
                });
                dbContext.SaveChanges();
                LoadManagerData();
                var user = dbContext.User.Find((int)lueUser.EditValue);
                var project = dbContext.Project.Find((_projectId));
                EmailHelper.SendEmail(user.USER_EMAIL, "YENİ PROJE BİLGİLENDİRME", project.PROJECT_PYP_NO + "'lu projede size tanımlandı");
                lueUser.EditValue = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int projectManagerId = gvProjectManager.GetNullableRowCellValue();
            if (projectManagerId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.ProjectManager.Remove(dbContext.ProjectManager.Find(projectManagerId));
                dbContext.SaveChanges();
            }
            LoadManagerData();
        }

        private void gvProject_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId == 0)
                return;
            _projectId = projectId;
            LoadManagerData();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueUser.EditNullableIntValue() == 0)
            {
                lueUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueUser.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueUser.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }

    }
}