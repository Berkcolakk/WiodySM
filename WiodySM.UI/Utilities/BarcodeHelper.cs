using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiodySM.Data.Model.Context;
using WiodySM.UI.ViewModels;

namespace WiodySM.UI.Utilities
{
    public static class BarcodeHelper
    {

        public static StockActionVM GetBarcodeDetail(string barcode, int storeId)
        {
            using (var dbContext = new WiodySMContext())
            {
                return dbContext.StockDetail.Where(x => x.STOCKDETAIL_BARCODE_ID == barcode && x.STOCKDETAIL_STORE_ID == storeId)
                            .GroupBy(x => new { x.STOCKDETAIL_BARCODE_ID, x.STOCKDETAIL_ITEM_ID, x.Item.ITEM_NAME, x.STOCKDETAIL_STORE_ID, x.ParameterDetail_StockDetail_Store.PARAMETERDETAIL_NAME,x.STOCKDETAIL_RACK_ID })
                            .Select(g => new StockActionVM
                            {
                                Quantity = g.Sum(x => x.STOCKDETAIL_QUANTITY),
                                Barcode = g.Key.STOCKDETAIL_BARCODE_ID,
                                ItemName = g.Key.ITEM_NAME,
                                ItemId = g.Key.STOCKDETAIL_ITEM_ID,
                                RackId = g.Key.STOCKDETAIL_RACK_ID
                            }).FirstOrDefault();
            }

        }
        public static string BarcodeVerify(string barcode)
        {
            string newBarcode = barcode.Substring(0, barcode.Length - 1);
            newBarcode = "0" + newBarcode;
            return newBarcode;
        }
        public static string GenerateBarcode()
        {
            string newBarcode = GenerateRandomNo().ToString() + "1";
            for (int i = 1; i < 12; i++)
            {
                if (newBarcode.Length < 12)
                {
                    newBarcode = "0" + newBarcode;
                }
            }
            return newBarcode;
        }
        public static int GenerateRandomNo()
        {
            int _min = 10000;
            int _max = 99999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        public static void PrintBarcode(String L1, String L2, String L3, String L4, String L5, String L6)
        {
            string filename = @"test1.prn";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + filename;
            String tempFile = filePath;
            String PrinterName = "TSC TTP-244CE";
            StreamReader SR = new StreamReader(tempFile, Encoding.Default);
            String all = SR.ReadToEnd();
            SR.Close();
            all = all.Replace("barcodeId", L1);
            L2 = L2.Replace("\"", "\\[\"]");
            all = all.Replace("itemName", L2);
            all = all.Replace("refCode", L3);
            all = all.Replace("quantity", L4 + "-" + L5);
            all = all.Replace("serialNo", "Seri No:" + L6);
            RawPrinterHelper.SendStringToPrinter(PrinterName, all);
        }
    }
}
