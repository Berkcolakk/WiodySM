using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WiodySM.Data.Model.Context;
using WiodySM.UI.ViewModels;
using System.Linq;

namespace WiodySM.UI.Forms.Report
{
    public partial class PayoffCover : DevExpress.XtraReports.UI.XtraReport
    {
        public PayoffCover(int payoffMasterId)
        {
            InitializeComponent();
            using (var dbContext = new WiodySMContext())
            {
                PayoffIcmalVM vm = new PayoffIcmalVM();

                vm.Tarih = DateTime.Now.ToShortDateString();
                var payoffMaster = dbContext.PayoffMaster.Find(payoffMasterId);
                var payoffList = dbContext.PayoffMaster.Where(x=>x.PAYOFFMASTER_PROJECT_ID == payoffMaster.PAYOFFMASTER_PROJECT_ID).OrderBy(x=>x.ID).ToList();
                int index = payoffList.FindIndex(a => a.ID == payoffMasterId);
                index = index+1;
                vm.HakNo = index + " Nolu Hakediş";
                vm.Yıl = DateTime.Now.Year.ToString();
                vm.GrupNo = payoffMaster.Project.PROJECT_GROUP;
                vm.PypNo = payoffMaster.Project.PROJECT_PYP_NO;
                vm.IsAdi = payoffMaster.Project.PROJECT_NAME;
                vm.FirmaAdi = payoffMaster.Project.Company.COMPANY_COMPANY_NAME;
                vm.Tenzilat = payoffMaster.Project.Contract.MasterContract.CONTRACT_PRICECUTRATE.ToString() + "%";
                //vm.Toplam = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId).Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP);
                objectDataSource1.DataSource = vm;

            }
        }

    }
}
