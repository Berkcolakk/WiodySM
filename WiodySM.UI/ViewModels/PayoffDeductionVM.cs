using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.UI.ViewModels
{
    public class PayoffDeductionVM
    {
        public string FirmaAdi { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; } = 0.05;
        public string TempDeduc { get; set; }
        public string NetDeduc { get; set; }
    }
}
