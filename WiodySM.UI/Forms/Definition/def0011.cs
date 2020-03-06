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

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0011 : BaseForm
    {
        public def0011()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            def0012 frm = new def0012();
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int userRoleId = gvUserRole.GetNullableRowCellValue();
            if (userRoleId == 0)
                return;
            def0012 frm = new def0012(userRoleId);
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
            userRoleBindingSource.DataSource = dbContext.UserRole.ToList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int userRoleId = gvUserRole.GetNullableRowCellValue();
            if (userRoleId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.UserRole.Remove(dbContext.UserRole.Find(userRoleId));
                dbContext.SaveChanges();
                LoadGrid();
            }
        }
    }
}