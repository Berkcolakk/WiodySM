using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.UI.ViewModels
{
    public class PayoffReportVM
    {
        public string Toplam { get; set; }
        public string Tenzilat { get; set; }
        public string TenzilatToplam { get; set; }
        public string EskiTenzilatToplam { get; set; }
        public string OdenecekTutar { get; set; }
        public string GeciciKabulKesintisi { get; set; }
        public string KesinKabulKesintisi { get; set; }
        public string Kesintiler { get; set; }
        public string KesinOdenecekToplam { get; set; }
        public string KDV { get; set; }
        public string TahakkukToplam { get; set; }
        public double TenzilatOran { get; set; }
        public string TenzilatOranText { get; set; }
        public string Firma { get; set; }
        public string Proje { get; set; }
        public string Tarih { get; set; }
        public string HakNo { get; set; }
    }
}
