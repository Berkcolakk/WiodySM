using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiodySM.Data.Model.Context;
using WiodySM.UI.Forms.Main;

namespace WiodySM.UI
{
    public class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        public WiodySMContext dbContext;
        public BaseForm()
        {
            dbContext = new WiodySMContext();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BaseForm";
            this.ResumeLayout(false);
        }
        // CONTROL + W + C Keys = Shows Which One Forms
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F10))
            {
                if (Form.ActiveForm.ActiveMdiChild != null)
                {
                    XtraMessageBox.Show($"Form Adı : {Form.ActiveForm.ActiveMdiChild.Name}", "Form Adı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return true;
                   
                }
                else
                {
                    XtraMessageBox.Show($"Form Adı : {Form.ActiveForm.Name}", "Form Adı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
