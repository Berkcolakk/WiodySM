using System;
using System.Drawing;
using System.Linq;
using static WiodySM.UI.Utilities.StockHelper;

namespace WiodySM.UI.Forms.Definition
{
    public partial class rprt0002 : BaseForm
    {
        int _projectId = 0;

        public rprt0002()
        {
            InitializeComponent();
            projectBindingSource.DataSource = dbContext.Project.ToList();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            _projectId = (int)lueProject.EditValue;
            var project = dbContext.Project.Find((int)lueProject.EditValue);
            var demandList = dbContext.ItemDemandMaster.Where(x => x.ITEMDEMANDMASTER_PROJECT_ID == _projectId).Select(x => x.ID).ToList();


            stockDetailBindingSource.DataSource = dbContext.StockDetail.Where(x => x.StockMaster.STOCKMASTER_REF_LINK == "ProjectOutput" && x.StockMaster.STOCKMASTER_REF_ID == _projectId).GroupBy(x => new { x.Item.ITEM_NAME, x.Item.ParameterDetail_Item_Unit.PARAMETERDETAIL_NAME, x.Item.ITEM_CODE, x.STOCKDETAIL_ITEM_ID }).Select(g => new StockDetailReportVM
            {
                REPORT_ITEM_NAME = g.Key.ITEM_NAME,
                REPORT_OUTPUTQUANTITY = g.Sum(x => Math.Abs(x.STOCKDETAIL_QUANTITY)),
                REPORT_DEMANDQUANTITY = dbContext.ItemDemandDetail.Where(x => x.ItemDemandMaster.ITEMDEMANDMASTER_PROJECT_ID == _projectId && x.ITEMDEMANDDETAIL_ITEM_ID == g.Key.STOCKDETAIL_ITEM_ID).Sum(x => x.ITEMDEMANDDETAIL_QUANTITY),
                REPORT_SENDQUANTITY = dbContext.StockDetail.Where(x => x.StockMaster.STOCKMASTER_REF_LINK == "ItemDemandMaster" && x.STOCKDETAIL_ITEM_ID == g.Key.STOCKDETAIL_ITEM_ID && x.STOCKDETAIL_STORE_ID == project.Company.COMPANY_STORE_ID && x.STOCKDETAIL_QUANTITY > 0 && demandList.Contains(x.StockMaster.STOCKMASTER_REF_ID.Value)).Sum(x => x.STOCKDETAIL_QUANTITY),
                REPORT_DETAILS = dbContext.StockDetail.Where(x => x.StockMaster.STOCKMASTER_REF_LINK == "ProjectOutput" && x.StockMaster.STOCKMASTER_REF_ID == _projectId).Select(y => new StockDetailVM
                {
                    STOCKDETAIL_BARCODE_ID = y.STOCKDETAIL_BARCODE_ID,
                    STOCKDETAIL_ITEM_NAME = y.Item.ITEM_NAME,
                    STOCKDETAIL_ITEM_CODE = y.Item.ITEM_CODE,
                    STOCKDETAIL_QUANTITY = y.STOCKDETAIL_QUANTITY,
                }).ToList(),
                REPORT_PAYOFFQUANTITY = dbContext.PayoffControl.FirstOrDefault(x => x.PayoffMaster.PAYOFFMASTER_PROJECT_ID == _projectId && g.Key.ITEM_NAME == x.PAYOFFCONTROL_ITEMNAME).PAYOFFCONTROL_QUANTITY

            }).ToList();
        }
        public bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(lueProject.Text))
            {
                lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                lueProject.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                lueProject.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}