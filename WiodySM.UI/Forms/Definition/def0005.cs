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
    public partial class def0005 : BaseForm
    {
        public def0005()
        {
            InitializeComponent();
            LoadGrid();
           
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            def0006 frm = new def0006();
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int itemId = gvItem.GetNullableRowCellValue();
            if (itemId == 0)
                return;
            def0006 frm = new def0006(itemId);
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
            itemBindingSource.DataSource = dbContext.Item.ToList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int itemId = gvItem.GetNullableRowCellValue();
            if (itemId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.Item.Remove(dbContext.Item.Find(itemId));
                dbContext.SaveChanges();
                LoadGrid();
            }
        }
    }
}