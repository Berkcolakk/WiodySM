using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using WiodySM.UI.ViewModels;
using WiodySM.Data.Model.Context;
using System.Linq;

namespace WiodySM.UI.Forms.Report
{
    public partial class TestReportDeduc : DevExpress.XtraReports.UI.XtraReport
    {
        List<PayoffDeductionVM> temp = new List<PayoffDeductionVM>();
        double totalTemp = 0;
        double totalNet = 0;
        double currentTemp = 0;
        double currentNet = 0;
        public TestReportDeduc(int payoffMasterId)
        {
            InitializeComponent();

            using (var dbContext = new WiodySMContext())
            {
                
                var defPayoffMaster = dbContext.PayoffMaster.Find(payoffMasterId);
                SelfDeduc(defPayoffMaster.Project.Contract.MasterContract.CONTRACT_PRICECUTRATE,payoffMasterId,defPayoffMaster.Project.Company.COMPANY_COMPANY_NAME,defPayoffMaster.PAYOFFMASTER_PROJECT_ID);
                var payoffList = dbContext.PayoffMaster.Where(x => x.PAYOFFMASTER_PROJECT_ID == defPayoffMaster.PAYOFFMASTER_PROJECT_ID && x.ID != payoffMasterId).OrderBy(x => x.ID).ToList();
                foreach (var item in payoffList)
                {
                    PayoffDeductionVM vm = new PayoffDeductionVM();
                    int index = payoffList.FindIndex(a => a.ID == item.ID);
                    index = index + 1;
                    var payoffMaster = dbContext.PayoffMaster.Find(item.ID);
                    double toplam = Math.Round(dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId).Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP), 2);
                    double tenzilat = Math.Round(toplam * payoffMaster.Project.Contract.MasterContract.CONTRACT_PRICECUTRATE / 100, 2);
                    double tenzilatToplam = Math.Round(toplam - tenzilat, 2);
                    var oldToplamData = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PayoffMaster.PAYOFFMASTER_PROJECT_ID == payoffMaster.PAYOFFMASTER_PROJECT_ID && x.PAYOFFCONTROL_PAYOFFMASTER_ID != payoffMasterId && x.PAYOFFCONTROL_PAYOFFMASTER_ID < payoffMasterId).ToList();
                    double oldToplam = oldToplamData == null ? 0 : Math.Round(oldToplamData.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP), 2);
                    double odenecekTutar = Math.Round(tenzilatToplam - oldToplam, 2);
                    double geciciKabulKesinti = Math.Round(tenzilatToplam * 0.025, 2);
                    double kesinKabulKesinti = Math.Round(tenzilatToplam * 0.025, 2);
                    totalTemp += geciciKabulKesinti;
                    totalNet += kesinKabulKesinti;
                    vm.Description = index + " Nolu Hakediş";
                    vm.TempDeduc = geciciKabulKesinti.ToString() + " TL";
                    vm.NetDeduc = kesinKabulKesinti.ToString() + " TL";
                    temp.Add(vm);
                }
                TotalDeduc();
                objectDataSource1.DataSource = temp;
            }
      
        }
        void SelfDeduc(double rate,int payoffMasterId,string companyName,int projectId)
        {
            using (var dbContext = new WiodySMContext())
            {
                PayoffDeductionVM vm = new PayoffDeductionVM();
                double toplam = Math.Round(dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId).Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP), 2);
                double tenzilat = Math.Round(toplam * rate / 100, 2);
                double tenzilatToplam = Math.Round(toplam - tenzilat, 2);
                var oldToplamData = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PayoffMaster.PAYOFFMASTER_PROJECT_ID == projectId && x.PAYOFFCONTROL_PAYOFFMASTER_ID != payoffMasterId && x.PAYOFFCONTROL_PAYOFFMASTER_ID < payoffMasterId).ToList();
                double oldToplam = oldToplamData == null ? 0 : Math.Round(oldToplamData.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP), 2);
                double odenecekTutar = Math.Round(tenzilatToplam - oldToplam, 2);
                double geciciKabulKesinti = Math.Round(tenzilatToplam * 0.025, 2);
                double kesinKabulKesinti = Math.Round(tenzilatToplam * 0.025, 2);
                currentNet = kesinKabulKesinti;
                currentTemp = geciciKabulKesinti;
                vm.FirmaAdi = companyName;
                vm.Description = "BU HAKEDİŞ KESİLMESİ GEREKEN";
                vm.TempDeduc = geciciKabulKesinti.ToString() + " TL";
                vm.NetDeduc = kesinKabulKesinti.ToString() + " TL";
                temp.Add(vm);
            }
        }
        void TotalDeduc()
        {
            using (var dbContext = new WiodySMContext())
            {
                PayoffDeductionVM vm = new PayoffDeductionVM();
                vm.Description = "BU HAKEDİŞTE KESİLMESİ GEREKEN";
                vm.TempDeduc = (currentTemp - totalTemp).ToString() + " TL";
                vm.NetDeduc = (currentNet - totalNet).ToString() + " TL";
                temp.Add(vm);
            }
        }
    }
}
