using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using WiodySM.Data.Model.Entity;
using WiodySM.UI.Utilities;
using WiodySM.UI.ViewModels;
using DevExpress.XtraGrid.Views.Grid;
using WiodySM.UI.Forms.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.Utils;
using DevExpress.XtraPrinting;

namespace WiodySM.UI.Forms.ProjectManagement
{
    public partial class pyf0002 : BaseForm
    {
        int _payoffMasterId = 0;
        List<PayoffDefault> _payoffDefault = new List<PayoffDefault>();
        PayoffMaster payoffMaster = new PayoffMaster();
        public pyf0002(int payoffMasterId)
        {
            InitializeComponent();
            _payoffMasterId = payoffMasterId;
            payoffMaster = dbContext.PayoffMaster.Find(_payoffMasterId);
            payoffDefaultBindingSource.DataSource = dbContext.PayoffDefault.Where(x => x.PAYOFFDEFAULT_PAYOFFMASTER_ID == _payoffMasterId).ToList();
            payoffControlVMBindingSource.DataSource = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_PAYOFFMASTER_ID == _payoffMasterId &&x.PAYOFFCONTROL_TYPE_ID == 0).OrderBy(x => x.PAYOFFCONTROL_LB).ToList();
            payoffBindingSource.DataSource = dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_PAYOFFMASTER_ID == _payoffMasterId && x.PAYOFFCONTROL_TYPE_ID == 1).OrderBy(x => x.PAYOFFCONTROL_LB).ToList();
            PayoffCover rp = new PayoffCover(_payoffMasterId); 
            rp.CreateDocument();
            payoffReportCover.DocumentSource = rp;
            PayoffExtractReport rp1 = new PayoffExtractReport(_payoffMasterId);
            rp1.CreateDocument();
            payoffReportIcmal.DocumentSource = rp1;
            PayoffReportTotalEnd rp2 = new PayoffReportTotalEnd(_payoffMasterId);
            rp2.CreateDocument();
            payoffReportPrintPreview.DocumentSource = rp2;
            TestReportDeduc rp3 = new TestReportDeduc(_payoffMasterId);
            rp3.CreateDocument();
            payoffReportDeduc.DocumentSource = rp3;
        }

        private void gvALV_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void gvALV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                int payoffDefaultID = gvALV.GetNullableRowCellValue();
                if (payoffDefaultID == 0)
                    return;
                dbContext.PayoffDefault.Remove(dbContext.PayoffDefault.Find(payoffDefaultID));
                dbContext.SaveChanges();
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gvControl_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void gvControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                int controlId = gvControl.GetNullableRowCellValue();
                if (controlId == 0)
                    return;
                dbContext.PayoffControl.Remove(dbContext.PayoffControl.Find(controlId));
                dbContext.SaveChanges();
                view.DeleteRow(view.FocusedRowHandle);
            }
            if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Taşeron hakedişine aktar?", "Onay", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                int controlId = gvControl.GetNullableRowCellValue();
                if (controlId == 0)
                    return;
                var payoffControl = dbContext.PayoffControl.Find(controlId);
                PayoffControl newPayoffControl = payoffControl;
                newPayoffControl.PAYOFFCONTROL_TYPE_ID = 1;
                dbContext.PayoffControl.Add(newPayoffControl);
                dbContext.SaveChanges();
                XtraMessageBox.Show("Aktarım Başarılı", "OK");
            }
        }
        PayoffControl newRow;
        private void gvPayoff_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            newRow = this.gvPayoff.GetRow(e.RowHandle) as PayoffControl;
        }
        private void gvPayoff_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (newRow !=null)
            {
                newRow.PAYOFFCONTROL_TYPE_ID = 1;
                newRow.PAYOFFCONTROL_PAYOFFMASTER_ID = _payoffMasterId;
               newRow.PAYOFFCONTROL_TENSIZUP = Math.Round((Convert.ToDouble(newRow.PAYOFFCONTROL_TENUP) / payoffMaster.PAYOFFMASTER_PARAMETERCODE), 2);
               newRow.PAYOFFCONTROL_TOTALTENUP = newRow.PAYOFFCONTROL_QUANTITY * newRow.PAYOFFCONTROL_TENUP;
                newRow.PAYOFFCONTROL_TOTALTENSIZUP = newRow.PAYOFFCONTROL_QUANTITY * newRow.PAYOFFCONTROL_TENSIZUP;
                dbContext.PayoffControl.Add(newRow);
            }
            dbContext.SaveChanges();
            newRow = null;
        }

        private void gvPayoff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                int controlId = gvPayoff.GetNullableRowCellValue();
                if (controlId == 0)
                    return;
                dbContext.PayoffControl.Remove(dbContext.PayoffControl.Find(controlId));
                dbContext.SaveChanges();
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

      
        float CalculateHeightOfReport(dynamic t)
        {
            float maxvalue = 0;
            BrickEnumerator be = t.Pages[t.Pages.Count - 1].GetEnumerator();
            while (be.MoveNext())
            {
                RectangleF bounds = t.Pages[t.Pages.Count - 1].GetBrickBounds(be.CurrentBrick);
                maxvalue = bounds.Bottom > maxvalue ? bounds.Bottom : maxvalue;
            }
            return maxvalue;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PayoffCover rp = new PayoffCover(_payoffMasterId);
            rp.ExportOptions.Xls.SheetName = "HAKEDİŞ KAPAK";
            rp.CreateDocument(false);
            PayoffExtractReport rp1 = new PayoffExtractReport(_payoffMasterId);
            rp1.ExportOptions.Xls.SheetName = "İCMAL";
            rp1.CreateDocument(false);
            PayoffReportTotalEnd rp2 = new PayoffReportTotalEnd(_payoffMasterId);
            rp2.ExportOptions.Xls.SheetName = "HAKEDİŞ RAPORU";
            rp2.CreateDocument(false);
            TestReportDeduc rp3 = new TestReportDeduc(_payoffMasterId);
            rp3.ExportOptions.Xls.SheetName = "İHTİYAT BLOKE KESİNTİLER";
            rp3.CreateDocument(false);
            PayoffAlvReport rp4 = new PayoffAlvReport(dbContext.PayoffDefault.Where(x => x.PAYOFFDEFAULT_PAYOFFMASTER_ID == _payoffMasterId).ToList());
            rp4.ExportOptions.Xls.SheetName = "ENERJİSA ALV 1";
            rp4.CreateDocument(false);
            rp4.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            rp4.PageHeight = rp4.PageHeight * (rp4.Pages.Count - 1) - ((rp4.Margins.Top + rp4.Margins.Bottom) * (rp4.Pages.Count - 2)) + ((int)(CalculateHeightOfReport(rp4) / 1 * 0.96f));
            rp4.CreateDocument(false);
            PayoffControlReport rp5 = new PayoffControlReport(dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_PAYOFFMASTER_ID == _payoffMasterId && x.PAYOFFCONTROL_TYPE_ID == 0).OrderBy(x => x.PAYOFFCONTROL_LB).ToList());
            rp5.ExportOptions.Xls.SheetName = "ENERJİSA KONTROL";
            rp5.CreateDocument(false);
            rp5.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            rp5.PageHeight = rp5.PageHeight * (rp5.Pages.Count - 1) - ((rp5.Margins.Top + rp5.Margins.Bottom) * (rp5.Pages.Count - 2)) + ((int)(CalculateHeightOfReport(rp5) / 1 * 0.96f));
            rp5.CreateDocument(false);

            PayoffControlReport rp6 = new PayoffControlReport(dbContext.PayoffControl.Where(x => x.PAYOFFCONTROL_PAYOFFMASTER_ID == _payoffMasterId && x.PAYOFFCONTROL_TYPE_ID == 1).OrderBy(x => x.PAYOFFCONTROL_LB).ToList());
            rp5.ExportOptions.Xls.SheetName = "TAŞERON HAKEDİŞ";
            rp6.CreateDocument(false);
            rp6.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            rp6.PageHeight = rp6.PageHeight * (rp6.Pages.Count - 1) - ((rp6.Margins.Top + rp6.Margins.Bottom) * (rp6.Pages.Count - 2)) + ((int)(CalculateHeightOfReport(rp6) / 1 * 0.96f));
            rp6.CreateDocument(false);

            rp.Pages.AddRange(rp1.Pages);
            rp.Pages.AddRange(rp4.Pages);
            rp.Pages.AddRange(rp5.Pages);
            rp.Pages.AddRange(rp6.Pages);
            rp.Pages.AddRange(rp3.Pages);
            rp.Pages.AddRange(rp2.Pages);
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreviewDialog();
        }
    }
}