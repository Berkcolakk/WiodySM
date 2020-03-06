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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace WiodySM.UI.Forms.Definition
{
    public partial class rprt0003 : BaseForm
    {
        public rprt0003()
        {
            InitializeComponent();
            storeBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                if (lueStore.EditValue != null)
                {
                    if (lueStore.EditValue != "")
                    {
                        stockDetailBindingSource.DataSource = StockHelper.GetStoreStocksDetail((int)lueStore.EditValue);
                    }
                }
            }
        }
     
        public bool validationResult()
        {
            bool validationRules = true;

            if (lueStore.EditNullableIntValue() == 0)
            {
                lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueStore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueStore.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }

    }
}