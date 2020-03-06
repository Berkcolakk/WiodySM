using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiodySM.Data.Model.Context;

namespace WiodySM.UI.Utilities
{
    public static class StockHelper
    {
        public static List<StockDetailVM> GetStoreStocks(int storeId)
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.Where(x => x.STOCKDETAIL_STORE_ID == storeId).GroupBy(x => new { x.STOCKDETAIL_BARCODE_ID, x.Item.ITEM_NAME,x.Item.ITEM_CODE }).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.ITEM_NAME,
                        STOCKDETAIL_ITEM_CODE = g.Key.ITEM_CODE,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY),
                    }).ToList();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static List<StockDetailVM> GetStoreStocksDetail(int storeId)
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.Where(x => x.STOCKDETAIL_STORE_ID == storeId).GroupBy(x => new { x.STOCKDETAIL_BARCODE_ID, x.Item.ITEM_NAME, x.Item.ParameterDetail_Item_Unit.PARAMETERDETAIL_NAME, x.STOCKDETAIL_STORE_ID, x.Item.ITEM_CODE }).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.ITEM_NAME,
                        STOCKDETAIL_ITEM_CODE = g.Key.ITEM_CODE,
                        STOCKDETAIL_ITEM_UNIT = g.Key.PARAMETERDETAIL_NAME,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY),
                        CREATED_DATE = dbContext.StockDetail.FirstOrDefault(x => x.STOCKDETAIL_STORE_ID == storeId && x.STOCKDETAIL_BARCODE_ID == g.Key.STOCKDETAIL_BARCODE_ID) == null ? DateTime.Now : dbContext.StockDetail.FirstOrDefault(x => x.STOCKDETAIL_STORE_ID == storeId && x.STOCKDETAIL_BARCODE_ID == g.Key.STOCKDETAIL_BARCODE_ID).CREATED_DATE,
                    }).ToList();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static List<StockDetailVM> GetItemStocksDetail(int itemId)
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.Where(x => x.STOCKDETAIL_ITEM_ID == itemId).GroupBy(x => new StockDetailVMT { STOCKDETAIL_BARCODE_ID = x.STOCKDETAIL_BARCODE_ID, STOCKDETAIL_ITEM_NAME = x.Item.ITEM_NAME, STOCKDETAIL_ITEM_UNIT = x.Item.ParameterDetail_Item_Unit.PARAMETERDETAIL_NAME, STOCKDETAIL_STORE_NAME = x.ParameterDetail_StockDetail_Store.PARAMETERDETAIL_NAME, STOCKDETAIL_ITEM_CODE= x.Item.ITEM_CODE}).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.STOCKDETAIL_ITEM_NAME,
                        STOCKDETAIL_ITEM_UNIT = g.Key.STOCKDETAIL_ITEM_UNIT,
                        STOCKDETAIL_ITEM_CODE = g.Key.STOCKDETAIL_ITEM_CODE,
                        STOCKDETAIL_STORE_NAME = g.Key.STOCKDETAIL_STORE_NAME,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY),
                    }).ToList();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static List<StockDetailVM> GetItemStocksDetailAll()
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.GroupBy(x => new StockDetailVMT { STOCKDETAIL_BARCODE_ID = x.STOCKDETAIL_BARCODE_ID, STOCKDETAIL_ITEM_NAME = x.Item.ITEM_NAME, STOCKDETAIL_ITEM_UNIT = x.Item.ParameterDetail_Item_Unit.PARAMETERDETAIL_NAME, STOCKDETAIL_STORE_NAME = x.ParameterDetail_StockDetail_Store.PARAMETERDETAIL_NAME, STOCKDETAIL_ITEM_CODE = x.Item.ITEM_CODE }).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.STOCKDETAIL_ITEM_NAME,
                        STOCKDETAIL_ITEM_UNIT = g.Key.STOCKDETAIL_ITEM_UNIT,
                        STOCKDETAIL_ITEM_CODE = g.Key.STOCKDETAIL_ITEM_CODE,
                        STOCKDETAIL_STORE_NAME = g.Key.STOCKDETAIL_STORE_NAME,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY),
                    }).ToList();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static StockDetailVM GetBarcodeStocks(string barcodeId)
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.Where(x => x.STOCKDETAIL_BARCODE_ID == barcodeId).GroupBy(x => new { x.STOCKDETAIL_BARCODE_ID, x.Item.ITEM_NAME, x.STOCKDETAIL_STORE_ID, x.STOCKDETAIL_ITEM_ID, x.STOCKDETAIL_RACK_ID }).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.ITEM_NAME,
                        STOCKDETAIL_STORE_ID = g.Key.STOCKDETAIL_STORE_ID,
                        STOCKDETAIL_RACK_ID = g.Key.STOCKDETAIL_RACK_ID,
                        STOCKDETAIL_ITEM_ID = g.Key.STOCKDETAIL_ITEM_ID,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY),

                    }).Where(x => x.STOCKDETAIL_QUANTITY > 0).FirstOrDefault();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static StockDetailVM GetBarcodeStocksWithStore(string barcodeId, int storeId)
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.Where(x => x.STOCKDETAIL_BARCODE_ID == barcodeId && x.STOCKDETAIL_STORE_ID == storeId).GroupBy(x => new { x.STOCKDETAIL_BARCODE_ID, x.Item.ITEM_NAME, x.STOCKDETAIL_STORE_ID, x.STOCKDETAIL_ITEM_ID, x.STOCKDETAIL_RACK_ID }).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.ITEM_NAME,
                        STOCKDETAIL_STORE_ID = g.Key.STOCKDETAIL_STORE_ID,
                        STOCKDETAIL_RACK_ID = g.Key.STOCKDETAIL_RACK_ID,
                        STOCKDETAIL_ITEM_ID = g.Key.STOCKDETAIL_ITEM_ID,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY),

                    }).Where(x => x.STOCKDETAIL_QUANTITY > 0).FirstOrDefault();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static List<StockDetailVM> GetItemsStocksDetail(List<int> itemIds)
        {
            using (var dbContext = new WiodySMContext())
            {
                try
                {
                    var result = dbContext.StockDetail.Where(x => itemIds.Contains(x.STOCKDETAIL_ITEM_ID)).GroupBy(x => new StockDetailVMT { STOCKDETAIL_BARCODE_ID = x.STOCKDETAIL_BARCODE_ID, STOCKDETAIL_ITEM_NAME = x.Item.ITEM_NAME, STOCKDETAIL_ITEM_UNIT = x.Item.ParameterDetail_Item_Unit.PARAMETERDETAIL_NAME, STOCKDETAIL_STORE_NAME = x.ParameterDetail_StockDetail_Store.PARAMETERDETAIL_NAME }).Select(g => new StockDetailVM
                    {
                        STOCKDETAIL_BARCODE_ID = g.Key.STOCKDETAIL_BARCODE_ID,
                        STOCKDETAIL_ITEM_NAME = g.Key.STOCKDETAIL_ITEM_NAME,
                        STOCKDETAIL_ITEM_UNIT = g.Key.STOCKDETAIL_ITEM_UNIT,
                        STOCKDETAIL_STORE_NAME = g.Key.STOCKDETAIL_STORE_NAME,
                        STOCKDETAIL_QUANTITY = g.Sum(x => x.STOCKDETAIL_QUANTITY)
                    }).ToList();
                    return result;


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public class StockDetailVM
        {
            public string STOCKDETAIL_BARCODE_ID { get; set; }
            public string STOCKDETAIL_ITEM_NAME { get; set; }
            public string STOCKDETAIL_STORE_NAME { get; set; }
            public int STOCKDETAIL_STORE_ID { get; set; }
            public int STOCKDETAIL_ITEM_ID { get; set; }
            public int STOCKDETAIL_RACK_ID { get; set; }
            public string STOCKDETAIL_ITEM_UNIT { get; set; }
            public string STOCKDETAIL_ITEM_CODE { get; set; }
            public double STOCKDETAIL_QUANTITY { get; set; }
            public DateTime CREATED_DATE { get; set; }
        }
        public class StockDetailReportVM
        {
            public string REPORT_ITEM_NAME { get; set; }
            public double? REPORT_DEMANDQUANTITY { get; set; }
            public double? REPORT_SENDQUANTITY { get; set; }
            public double? REPORT_OUTPUTQUANTITY { get; set; }
            public double? REPORT_PAYOFFQUANTITY { get; set; }
            public double? REPORT_DIFF { get; set; }
            public List<StockDetailVM> REPORT_DETAILS { get; set; }
        }
        public class StockDetailVMT
        {
            public string STOCKDETAIL_BARCODE_ID { get; set; }
            public string STOCKDETAIL_ITEM_NAME { get; set; }
            public string STOCKDETAIL_STORE_NAME { get; set; }
            public string STOCKDETAIL_ITEM_UNIT { get; set; }
            public string STOCKDETAIL_ITEM_CODE { get; set; }
            public double STOCKDETAIL_QUANTITY { get; set; }
        }
    }
}
