using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.UI.ViewModels
{
    public class StockActionVM
    {
        public string ItemName { get; set; }
        public string Barcode { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        public int RackId { get; set; }
    }
}
