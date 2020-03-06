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
using WiodySM.Data.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0001 : BaseForm
    {
        public prj0001()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            prj0002 frm = new prj0002();
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId == 0)
                return;
            if (SystemActive.UserId != dbContext.Project.Find(projectId).CREATED_USER_ID)
            {
                XtraMessageBox.Show("Farklı kullanıcı kayıt müdahelesinde bulunamaz.", "Uyarı!");
                return;
            }
            prj0002 frm = new prj0002(projectId);
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            LoadGrid();
        }
        void LoadGrid()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            projectBindingSource.DataSource = dbContext.Project.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.Project.Remove(dbContext.Project.Find(projectId));
                dbContext.SaveChanges();
                LoadGrid();
            }
        }

        private void btnProjectExplore_Click(object sender, EventArgs e)
        {
            int projectId = gvProject.GetNullableRowCellValue();
            if (projectId == 0)
                return;
            prj0003 frm = new prj0003(projectId);
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
    }
}