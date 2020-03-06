namespace WiodySM.UI.Forms.Definition
{
    partial class rprt0002
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rprt0002));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueProject = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_PYP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGetReport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcStockReport = new DevExpress.XtraGrid.GridControl();
            this.stockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REPORT_DEMANDQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYOFFQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lueProject);
            this.groupControl1.Controls.Add(this.btnGetReport);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1178, 49);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlem";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Proje";
            // 
            // lueProject
            // 
            this.lueProject.EditValue = "";
            this.lueProject.Location = new System.Drawing.Point(72, 23);
            this.lueProject.Name = "lueProject";
            this.lueProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProject.Properties.DataSource = this.projectBindingSource;
            this.lueProject.Properties.DisplayMember = "PROJECT_NAME";
            this.lueProject.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueProject.Properties.ValueMember = "ID";
            this.lueProject.Size = new System.Drawing.Size(188, 20);
            this.lueProject.TabIndex = 1;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.Company);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_NAME,
            this.colPROJECT_PYP_NO});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPROJECT_NAME
            // 
            this.colPROJECT_NAME.Caption = "Proje";
            this.colPROJECT_NAME.FieldName = "PROJECT_NAME";
            this.colPROJECT_NAME.Name = "colPROJECT_NAME";
            this.colPROJECT_NAME.Visible = true;
            this.colPROJECT_NAME.VisibleIndex = 0;
            // 
            // colPROJECT_PYP_NO
            // 
            this.colPROJECT_PYP_NO.Caption = "PYP";
            this.colPROJECT_PYP_NO.FieldName = "PROJECT_PYP_NO";
            this.colPROJECT_PYP_NO.Name = "colPROJECT_PYP_NO";
            this.colPROJECT_PYP_NO.Visible = true;
            this.colPROJECT_PYP_NO.VisibleIndex = 1;
            // 
            // btnGetReport
            // 
            this.btnGetReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGetReport.ImageOptions.Image")));
            this.btnGetReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGetReport.Location = new System.Drawing.Point(266, 23);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(112, 20);
            this.btnGetReport.TabIndex = 0;
            this.btnGetReport.Text = "Uygula";
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcStockReport);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 58);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 500);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Liste";
            // 
            // gcStockReport
            // 
            this.gcStockReport.DataSource = this.stockDetailBindingSource;
            this.gcStockReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStockReport.Location = new System.Drawing.Point(2, 20);
            this.gcStockReport.MainView = this.gvStockReport;
            this.gcStockReport.Name = "gcStockReport";
            this.gcStockReport.Size = new System.Drawing.Size(1174, 478);
            this.gcStockReport.TabIndex = 2;
            this.gcStockReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStockReport});
            // 
            // gvStockReport
            // 
            this.gvStockReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItem,
            this.gridColumn1,
            this.gridColumn2,
            this.REPORT_DEMANDQUANTITY,
            this.colPAYOFFQUANTITY,
            this.colTOTAL});
            this.gvStockReport.GridControl = this.gcStockReport;
            this.gvStockReport.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STOCKDETAIL_QUANTITY", null, "(Miktar: {0:0.##})")});
            this.gvStockReport.Name = "gvStockReport";
            this.gvStockReport.OptionsBehavior.Editable = false;
            // 
            // colItem
            // 
            this.colItem.Caption = "Ürün";
            this.colItem.FieldName = "REPORT_ITEM_NAME";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Gönderilen";
            this.gridColumn1.FieldName = "REPORT_SENDQUANTITY";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sarf Edilen";
            this.gridColumn2.FieldName = "REPORT_OUTPUTQUANTITY";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // REPORT_DEMANDQUANTITY
            // 
            this.REPORT_DEMANDQUANTITY.Caption = "Talep";
            this.REPORT_DEMANDQUANTITY.FieldName = "REPORT_DEMANDQUANTITY";
            this.REPORT_DEMANDQUANTITY.Name = "REPORT_DEMANDQUANTITY";
            this.REPORT_DEMANDQUANTITY.Visible = true;
            this.REPORT_DEMANDQUANTITY.VisibleIndex = 1;
            // 
            // colPAYOFFQUANTITY
            // 
            this.colPAYOFFQUANTITY.Caption = "Hakediş";
            this.colPAYOFFQUANTITY.FieldName = "REPORT_PAYOFFQUANTITY";
            this.colPAYOFFQUANTITY.Name = "colPAYOFFQUANTITY";
            this.colPAYOFFQUANTITY.Visible = true;
            this.colPAYOFFQUANTITY.VisibleIndex = 4;
            // 
            // colTOTAL
            // 
            this.colTOTAL.Caption = "SARF-HAKEDİŞ";
            this.colTOTAL.FieldName = "REPORT_DIFF";
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.UnboundExpression = "[colPAYOFFQUANTITY] - [gridColumn2]";
            this.colTOTAL.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 5;
            // 
            // rprt0002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "rprt0002";
            this.Text = "Stok Raporu";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcStockReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnGetReport;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraGrid.GridControl gcStockReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockReport;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lueProject;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource stockDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_PYP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn REPORT_DEMANDQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colPAYOFFQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL;
    }
}