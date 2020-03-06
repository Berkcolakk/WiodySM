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

namespace WiodySM.UI.Forms.Definition
{
    public partial class def0007 : BaseForm
    {
        public def0007()
        {
            InitializeComponent();
            LoadGrid();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            def0008 frm = new def0008();
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            frm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int contractId = gvContract.GetNullableRowCellValue();
            if (contractId == 0)
                return;
            if (SystemActive.UserId != dbContext.Contract.Find(contractId).CREATED_USER_ID)
            {
                XtraMessageBox.Show("Farklı kullanıcı kayıt müdahelesinde bulunamaz.", "Uyarı!");
                return;
            }
            def0008 frm = new def0008(contractId);
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
            contractBindingSource.DataSource = dbContext.Contract.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int contractId = gvContract.GetNullableRowCellValue();
            if (contractId == 0)
                return;
            DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dbContext.Contract.Remove(dbContext.Contract.Find(contractId));
                dbContext.SaveChanges();
                LoadGrid();
            }
        }
        
    }
}