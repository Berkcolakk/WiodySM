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
    public partial class rprt0001 : BaseForm
    {
        public rprt0001()
        {
            InitializeComponent();
            storeBindingSource.DataSource = dbContext.ParameterDetail.Where(x => x.PARAMETERDETAIL_MASTER_ID == StaticTypes.Store).ToList();
            itemBindingSource.DataSource = dbContext.Item.ToList();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                if (lueItem.EditValue != null)
                {
                    if (lueItem.EditValue != "")
                    {
                        stockDetailBindingSource.DataSource = StockHelper.GetItemStocksDetail((int)lueItem.EditValue);
                    }
                }
                if (lueStore.EditValue != null)
                {
                    if (lueStore.EditValue != "")
                    {
                        stockDetailBindingSource.DataSource = StockHelper.GetStoreStocksDetail((int)lueStore.EditValue);
                    }
                }
                if (lueItem.EditValue == null && lueStore.EditValue == null)
                {
                    if (lueItem.EditValue == "" && lueStore.EditValue == "")
                    {
                        stockDetailBindingSource.DataSource = StockHelper.GetItemStocksDetailAll();
                    }
                }
            }
        }
        public bool validationResult()
        {
            bool validationRules = true;
            if (lueItem.EditNullableIntValue() == 0)
            {
                lueItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueItem.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueItem.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
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