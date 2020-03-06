using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.ViewModels;

namespace WiodySM.UI.Utilities
{
    public static class ExcelHelper
    {
        public static List<PayoffAlvVM> ReadExcel(string filePath)
        {
            List<PayoffAlvVM> assets = new List<PayoffAlvVM>();
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=Excel 8.0;", @filePath);

            var adapter = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", connectionString);
            var ds = new DataSet();

            adapter.Fill(ds, "hardcatAssets");
            DataTable data = ds.Tables["hardcatAssets"];

            foreach (DataRow row in data.Rows)
            {
                PayoffAlvVM asset = new PayoffAlvVM();
                int i = 0;
                foreach (PropertyInfo pinfo in asset.GetType().GetProperties())
                {
                    pinfo.SetValue(asset, row.ItemArray[i].ToString());
                    i++;
                }

                assets.Add(asset);
            }

            return assets;
        }
        public static List<ExploreVM> ReadExcelExpore(string filePath)
        {
            List<ExploreVM> assets = new List<ExploreVM>();
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=Excel 8.0;", @filePath);

            var adapter = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", connectionString);
            var ds = new DataSet();

            adapter.Fill(ds, "hardcatAssets");
            DataTable data = ds.Tables["hardcatAssets"];

            foreach (DataRow row in data.Rows)
            {
                ExploreVM asset = new ExploreVM();
                int i = 0;
                foreach (PropertyInfo pinfo in asset.GetType().GetProperties())
                {
                    pinfo.SetValue(asset, row.ItemArray[i].ToString());
                    i++;
                }

                assets.Add(asset);
            }

            return assets;
        }
        public static string SplitCamelCase(this string str)
        {
            return Regex.Replace(
                Regex.Replace(
                    str,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }
    }
}
