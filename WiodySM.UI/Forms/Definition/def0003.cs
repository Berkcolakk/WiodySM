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
    public partial class def0003 : BaseForm
    {
        public def0003()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            def0004 frm = new def0004();
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int userId = gvUser.GetNullableRowCellValue();
            if (userId == 0)
                return;
            def0004 frm = new def0004(userId);
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
            userBindingSource.DataSource = dbContext.User.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int userId = gvUser.GetNullableRowCellValue();
            if (userId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.User.Remove(dbContext.User.Find(userId));
                dbContext.SaveChanges();
                LoadGrid();
            }
        }
    }
}