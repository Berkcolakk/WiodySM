namespace WiodySM.UI.Forms.Definition
{
    partial class rprt0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rprt0001));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueStore = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMPANY_COMPANY_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueItem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGetReport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcStockReport = new DevExpress.XtraGrid.GridControl();
            this.stockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTOCKDETAIL_BARCODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKDETAIL_QUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lueStore);
            this.groupControl1.Controls.Add(this.lueItem);
            this.groupControl1.Controls.Add(this.btnGetReport);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1178, 89);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlem";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Depo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Malzeme";
            // 
            // lueStore
            // 
            this.lueStore.EditValue = "";
            this.lueStore.Location = new System.Drawing.Point(72, 61);
            this.lueStore.Name = "lueStore";
            this.lueStore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStore.Properties.DataSource = this.storeBindingSource;
            this.lueStore.Properties.DisplayMember = "PARAMETERDETAIL_NAME";
            this.lueStore.Properties.PopupView = this.searchLookUpEdit2View;
            this.lueStore.Properties.ValueMember = "ID";
            this.lueStore.Size = new System.Drawing.Size(187, 20);
            this.lueStore.TabIndex = 2;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.Company);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMPANY_COMPANY_NAME});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCOMPANY_COMPANY_NAME
            // 
            this.colCOMPANY_COMPANY_NAME.Caption = "Firma";
            this.colCOMPANY_COMPANY_NAME.FieldName = "PARAMETERDETAIL_NAME";
            this.colCOMPANY_COMPANY_NAME.Name = "colCOMPANY_COMPANY_NAME";
            this.colCOMPANY_COMPANY_NAME.Visible = true;
            this.colCOMPANY_COMPANY_NAME.VisibleIndex = 0;
            // 
            // lueItem
            // 
            this.lueItem.EditValue = "";
            this.lueItem.Location = new System.Drawing.Point(72, 23);
            this.lueItem.Name = "lueItem";
            this.lueItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueItem.Properties.DataSource = this.itemBindingSource;
            this.lueItem.Properties.DisplayMember = "ITEM_NAME";
            this.lueItem.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueItem.Properties.ValueMember = "ID";
            this.lueItem.Size = new System.Drawing.Size(188, 20);
            this.lueItem.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEM_NAME,
            this.colITEM_CODE});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colITEM_NAME
            // 
            this.colITEM_NAME.Caption = "Malzeme";
            this.colITEM_NAME.FieldName = "ITEM_NAME";
            this.colITEM_NAME.Name = "colITEM_NAME";
            this.colITEM_NAME.Visible = true;
            this.colITEM_NAME.VisibleIndex = 0;
            // 
            // colITEM_CODE
            // 
            this.colITEM_CODE.Caption = "Kod";
            this.colITEM_CODE.FieldName = "ITEM_CODE";
            this.colITEM_CODE.Name = "colITEM_CODE";
            this.colITEM_CODE.Visible = true;
            this.colITEM_CODE.VisibleIndex = 1;
            // 
            // btnGetReport
            // 
            this.btnGetReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGetReport.ImageOptions.Image")));
            this.btnGetReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnGetReport.Location = new System.Drawing.Point(266, 23);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(50, 60);
            this.btnGetReport.TabIndex = 0;
            this.btnGetReport.Text = "Uygula";
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcStockReport);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
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
            this.gcStockReport.Size = new System.Drawing.Size(1174, 438);
            this.gcStockReport.TabIndex = 2;
            this.gcStockReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStockReport});
            // 
            // gvStockReport
            // 
            this.gvStockReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTOCKDETAIL_BARCODE_ID,
            this.colSTOCKDETAIL_QUANTITY,
            this.colItem,
            this.colUnit,
            this.gridColumn1,
            this.colItemCode});
            this.gvStockReport.GridControl = this.gcStockReport;
            this.gvStockReport.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STOCKDETAIL_QUANTITY", null, "(Miktar: {0:0.##})")});
            this.gvStockReport.Name = "gvStockReport";
            this.gvStockReport.OptionsBehavior.Editable = false;
            // 
            // colSTOCKDETAIL_BARCODE_ID
            // 
            this.colSTOCKDETAIL_BARCODE_ID.Caption = "Barkod";
            this.colSTOCKDETAIL_BARCODE_ID.FieldName = "STOCKDETAIL_BARCODE_ID";
            this.colSTOCKDETAIL_BARCODE_ID.Name = "colSTOCKDETAIL_BARCODE_ID";
            this.colSTOCKDETAIL_BARCODE_ID.Visible = true;
            this.colSTOCKDETAIL_BARCODE_ID.VisibleIndex = 4;
            // 
            // colSTOCKDETAIL_QUANTITY
            // 
            this.colSTOCKDETAIL_QUANTITY.Caption = "Miktar";
            this.colSTOCKDETAIL_QUANTITY.FieldName = "STOCKDETAIL_QUANTITY";
            this.colSTOCKDETAIL_QUANTITY.Name = "colSTOCKDETAIL_QUANTITY";
            this.colSTOCKDETAIL_QUANTITY.Visible = true;
            this.colSTOCKDETAIL_QUANTITY.VisibleIndex = 3;
            // 
            // colItem
            // 
            this.colItem.Caption = "Ürün";
            this.colItem.FieldName = "STOCKDETAIL_ITEM_NAME";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Birim";
            this.colUnit.FieldName = "STOCKDETAIL_ITEM_UNIT";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Depo";
            this.gridColumn1.FieldName = "STOCKDETAIL_STORE_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Kod";
            this.colItemCode.FieldName = "STOCKDETAIL_ITEM_CODE";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            // 
            // rprt0001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "rprt0001";
            this.Text = "Stok Raporu";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource storeBindingSource;
        private DevExpress.XtraGrid.GridControl gcStockReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockReport;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_BARCODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_QUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lueStore;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit lueItem;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource stockDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_COMPANY_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CODE;
    }
}