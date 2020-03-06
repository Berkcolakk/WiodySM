using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.UI.Utilities
{
    public static class Helpers
    {
        public static int? EditNullableIntValue(this SearchLookUpEdit slue)
        {
            if (slue.EditValue == null)
            {
                return null;
            }
            if (slue.EditValue.ToString() == "")
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(slue.EditValue);
            }
        }
        public static int GetNullableRowCellValue(this GridView gv)
        {
            if (gv.GetRowCellValue(gv.FocusedRowHandle, "ID") == null)
            {
                XtraMessageBox.Show("Lütfen geçerli bir seçim yapın.", "Uyarı!");
                return 0;
            }
            else
            {
                return (int)gv.GetRowCellValue(gv.FocusedRowHandle, "ID");
            }
        }
        public static string GetNullableRowCellValue(this GridView gv,string fieldName)
        {
            if (gv.GetRowCellValue(gv.FocusedRowHandle, fieldName) == null)
            {
                XtraMessageBox.Show("Lütfen geçerli bir seçim yapın.", "Uyarı!");
                return "";
            }
            else
            {
                return (string)gv.GetRowCellValue(gv.FocusedRowHandle, fieldName);
            }
        }
    }
}
