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
    public partial class PayoffExtractReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PayoffExtractReport(int payoffMasterId)
        {
            InitializeComponent();
            using (var dbContext = new WiodySMContext())
            {
                PayoffIcmalVM vm = new PayoffIcmalVM();

                vm.Tarih = DateTime.Now.ToShortDateString();
                var payoffMaster = dbContext.PayoffMaster.Find(payoffMasterId);
                vm.Yıl = DateTime.Now.Year.ToString();
                vm.GrupNo = payoffMaster.Project.PROJECT_GROUP;
                vm.PypNo = payoffMaster.Project.PROJECT_PYP_NO;
                vm.IsAdi = payoffMaster.Project.PROJECT_NAME;

                var mlz = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId && x.PAYOFFCONTROL_LB == "MLZ").ToList();
                vm.Malzeme = mlz == null ? "0 TL"  : mlz.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP).ToString() + " TL";

                var mon = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId && x.PAYOFFCONTROL_LB == "MON").ToList();
                vm.Montaj = mon == null ? "0 TL" : mon.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP).ToString() + " TL";
                var deMon = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId && x.PAYOFFCONTROL_LB == "DM").ToList();
                vm.DeMontaj = deMon == null ? "0 TL" : deMon.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP).ToString() + " TL";
                var dmm = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId && x.PAYOFFCONTROL_LB == "DMM").ToList();
                vm.DMM = dmm == null ? "0 TL" : dmm.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP).ToString() + " TL";
                var ins = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId && x.PAYOFFCONTROL_LB == "İNS").ToList();
                vm.Insaat = ins == null ? "0 TL" : ins.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP).ToString() + " TL";
                vm.Total = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId).Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP).ToString() + " TL";
                objectDataSource1.DataSource = vm;

            }
        }

    }
}
