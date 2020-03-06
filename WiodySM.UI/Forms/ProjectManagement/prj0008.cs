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
using WiodySM.Data.Model.Context;
using WiodySM.Data.Utilities;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class prj0008 : BaseForm
    {
        int _projectId = 0;

        public prj0008()
        {
            InitializeComponent();
            projectBindingSource.DataSource = dbContext.Project.ToList();
            LoadData();
        }

        private void LoadData()
        {
            foreach (var entity in dbContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            var projects = dbContext.ProjectManager.Where(x => x.PROJECTMANAGER_USER_ID == SystemActive.UserId).Select(x => x.Project.ID).ToList();
            stockMasterBindingSource.DataSource =
                dbContext.StockMaster.Join(dbContext.Project, stockMaster => stockMaster.STOCKMASTER_REF_ID, project => project.ID, (stockMaster, project) => new { StockMaster = stockMaster, Project = project }).Where(x => projects.Contains(x.StockMaster.STOCKMASTER_REF_ID.Value) && x.StockMaster.STOCKMASTER_REF_LINK == "ProjectOutput").Select(x => new StockMasterProjectVM
                {
                    Type = x.StockMaster.ParameterDetail_StockMaster_Type.PARAMETERDETAIL_NAME,
                    PYP = x.Project.PROJECT_PYP_NO,
                    Date = x.StockMaster.CREATED_DATE,
                    ID = x.StockMaster.ID
                }).ToList();
        }
        public class StockMasterProjectVM
        {
            public string Type { get; set; }
            public string PYP { get; set; }
            public DateTime Date { get; set; }
            public int ID { get; set; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {

                var selectedProject = dbContext.Project.Find(lueProject.EditValue);
                dbContext.StockMaster.Add(new StockMaster
                {
                    STOCKMASTER_COMPANY_ID = selectedProject.PROJECT_COMPANY_ID,
                    STOCKMASTER_SOURCESTORE_ID = selectedProject.Company.COMPANY_STORE_ID.Value,
                    STOCKMASTER_TARGETSTORE_ID = selectedProject.Company.COMPANY_STORE_ID.Value,
                    STOCKMASTER_TYPE_ID = StaticTypes.Sarf,
                    STOCKMASTER_REF_ID = selectedProject.ID,
                    STOCKMASTER_REF_LINK = "ProjectOutput"
                });
                lueProject.EditValue = null;
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int itemDemandMasterId = gvItemDemandMaster.GetNullableRowCellValue();
            //if (itemDemandMasterId == 0)
            //    return;
            //DialogResult dialog = XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialog == DialogResult.Yes)
            //{
            //    dbContext.ItemDemandMaster.Remove(dbContext.ItemDemandMaster.Find(itemDemandMasterId));
            //    dbContext.SaveChanges();
            //}
            //LoadData();
        }

        private void btnItemDemandDetail_Click(object sender, EventArgs e)
        {
            int stockMasterId = gvStockMaster.GetNullableRowCellValue();
            if (stockMasterId == 0)
                return;
            prj0012 frm = new prj0012(stockMasterId);
            frm.Show();
        }

        private void btnProjectExplore_Click(object sender, EventArgs e)
        {
            if (lueProject.EditValue == "" || lueProject.EditValue == null)
                return;
            prj0003 frm = new prj0003((int)lueProject.EditValue);
            frm.Show();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (lueProject.EditNullableIntValue() == 0)
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