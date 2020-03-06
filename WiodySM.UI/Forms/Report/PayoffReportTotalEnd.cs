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
    public partial class PayoffReportTotalEnd : DevExpress.XtraReports.UI.XtraReport
    {
        public PayoffReportTotalEnd(int payoffMasterId)
        {
            InitializeComponent();
            using (var dbContext = new WiodySMContext())
            {
                PayoffReportVM vm = new PayoffReportVM();
                var payoffMaster = dbContext.PayoffMaster.Find(payoffMasterId);
                var payoffList = dbContext.PayoffMaster.Where(x => x.PAYOFFMASTER_PROJECT_ID == payoffMaster.PAYOFFMASTER_PROJECT_ID).OrderBy(x => x.ID).ToList();
                int index = payoffList.FindIndex(a => a.ID == payoffMasterId);
                index = index + 1;
                vm.HakNo = index + " Nolu Hakediş";
                vm.Proje = payoffMaster.Project.PROJECT_NAME;
                vm.Firma = payoffMaster.Project.Company.COMPANY_COMPANY_NAME;
                vm.Tarih = payoffMaster.CREATED_DATE + "  TARİHİNE KADAR YAPILAN İŞİN / HİZMETİN";
                double toplam = Math.Round(dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PAYOFFCONTROL_PAYOFFMASTER_ID == payoffMasterId).Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP),2);
                vm.Toplam = toplam.ToString() + " TL";
                vm.TenzilatOran = payoffMaster.Project.Contract.MasterContract.CONTRACT_PRICECUTRATE / 100;
                vm.TenzilatOranText = payoffMaster.Project.Contract.MasterContract.CONTRACT_PRICECUTRATE.ToString() + "%";
                double tenzilat = Math.Round(toplam * vm.TenzilatOran,2);
                vm.Tenzilat = tenzilat.ToString() + " TL";
                double tenzilatToplam = Math.Round(toplam - tenzilat,2);
                vm.TenzilatToplam = tenzilatToplam.ToString() + " TL";
                var oldToplamData = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_TYPE_ID == 1 && x.PayoffMaster.PAYOFFMASTER_PROJECT_ID == payoffMaster.PAYOFFMASTER_PROJECT_ID && x.PAYOFFCONTROL_PAYOFFMASTER_ID != payoffMasterId && x.PAYOFFCONTROL_PAYOFFMASTER_ID <payoffMasterId).ToList();
                double oldToplam = oldToplamData == null ? 0 : Math.Round(oldToplamData.Sum(x => x.PAYOFFCONTROL_TOTALTENSIZUP),2);
                vm.EskiTenzilatToplam = oldToplam.ToString() + " TL";
                double odenecekTutar = Math.Round(tenzilatToplam - oldToplam,2);
                vm.OdenecekTutar = odenecekTutar.ToString() + " TL";
                double geciciKabulKesinti = Math.Round(tenzilatToplam * 0.025,2);
                double kesinKabulKesinti = Math.Round(tenzilatToplam * 0.025,2);
                vm.GeciciKabulKesintisi= (geciciKabulKesinti * -1).ToString() + " TL";
                vm.KesinKabulKesintisi= (kesinKabulKesinti*-1).ToString() + " TL";
                double kesintiler = Math.Round(payoffMaster.PAYOFFMASTER_PARAMETERCODE,2);
                vm.Kesintiler = payoffMaster.PAYOFFMASTER_PARAMETERCODE.ToString() + " TL";
                double hakedisToplam = Math.Round(odenecekTutar - (geciciKabulKesinti + kesinKabulKesinti + kesintiler),2);
                vm.KesinOdenecekToplam = hakedisToplam.ToString() + " TL";
                double kdv = Math.Round(hakedisToplam * 0.18,2);
                vm.KDV = kdv.ToString() + " TL";
                double tahakkukToplam = Math.Round(hakedisToplam + kdv, 2);
                vm.TahakkukToplam = tahakkukToplam.ToString() + " TL";
                objectDataSource1.DataSource = vm;

            }
        }

    }
}
