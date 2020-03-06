namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0011
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0011));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnTransferSelecteds = new DevExpress.XtraEditors.SimpleButton();
            this.gcStockDetail = new DevExpress.XtraGrid.GridControl();
            this.stockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTOCKDETAIL_BARCODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKDETAIL_QUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).BeginInit();
            this.gControlDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gControlDetail, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gControlDetail
            // 
            this.gControlDetail.Controls.Add(this.tableLayoutPanel2);
            this.gControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControlDetail.Location = new System.Drawing.Point(3, 3);
            this.gControlDetail.Name = "gControlDetail";
            this.gControlDetail.Size = new System.Drawing.Size(1178, 555);
            this.gControlDetail.TabIndex = 1;
            this.gControlDetail.Text = "Liste";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcStockDetail, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 533);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(194, 527);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Giriş";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnTransferSelecteds);
            this.groupControl4.Location = new System.Drawing.Point(5, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(184, 86);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "İşlem";
            // 
            // btnTransferSelecteds
            // 
            this.btnTransferSelecteds.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferSelecteds.ImageOptions.Image")));
            this.btnTransferSelecteds.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTransferSelecteds.Location = new System.Drawing.Point(5, 23);
            this.btnTransferSelecteds.Name = "btnTransferSelecteds";
            this.btnTransferSelecteds.Size = new System.Drawing.Size(174, 60);
            this.btnTransferSelecteds.TabIndex = 12;
            this.btnTransferSelecteds.Text = "Seçili olanları aktar";
            this.btnTransferSelecteds.Click += new System.EventHandler(this.btnTransferSelecteds_Click);
            // 
            // gcStockDetail
            // 
            this.gcStockDetail.DataSource = this.stockDetailBindingSource;
            this.gcStockDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStockDetail.Location = new System.Drawing.Point(203, 3);
            this.gcStockDetail.MainView = this.gvStockDetail;
            this.gcStockDetail.Name = "gcStockDetail";
            this.gcStockDetail.Size = new System.Drawing.Size(968, 527);
            this.gcStockDetail.TabIndex = 1;
            this.gcStockDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStockDetail});
            // 
            // stockDetailBindingSource
            // 
            this.stockDetailBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.StockDetail);
            // 
            // gvStockDetail
            // 
            this.gvStockDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTOCKDETAIL_BARCODE_ID,
            this.colSTOCKDETAIL_QUANTITY,
            this.colStore,
            this.colItemUnit,
            this.colItemName});
            this.gvStockDetail.GridControl = this.gcStockDetail;
            this.gvStockDetail.Name = "gvStockDetail";
            this.gvStockDetail.OptionsSelection.MultiSelect = true;
            this.gvStockDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colSTOCKDETAIL_BARCODE_ID
            // 
            this.colSTOCKDETAIL_BARCODE_ID.Caption = "Barkod";
            this.colSTOCKDETAIL_BARCODE_ID.FieldName = "STOCKDETAIL_BARCODE_ID";
            this.colSTOCKDETAIL_BARCODE_ID.Name = "colSTOCKDETAIL_BARCODE_ID";
            this.colSTOCKDETAIL_BARCODE_ID.Visible = true;
            this.colSTOCKDETAIL_BARCODE_ID.VisibleIndex = 1;
            // 
            // colSTOCKDETAIL_QUANTITY
            // 
            this.colSTOCKDETAIL_QUANTITY.Caption = "Miktar";
            this.colSTOCKDETAIL_QUANTITY.FieldName = "STOCKDETAIL_QUANTITY";
            this.colSTOCKDETAIL_QUANTITY.Name = "colSTOCKDETAIL_QUANTITY";
            this.colSTOCKDETAIL_QUANTITY.Visible = true;
            this.colSTOCKDETAIL_QUANTITY.VisibleIndex = 2;
            // 
            // colStore
            // 
            this.colStore.Caption = "Depo";
            this.colStore.FieldName = "STOCKDETAIL_STORE_NAME";
            this.colStore.Name = "colStore";
            this.colStore.Visible = true;
            this.colStore.VisibleIndex = 3;
            // 
            // colItemUnit
            // 
            this.colItemUnit.Caption = "Birim";
            this.colItemUnit.FieldName = "STOCKDETAIL_ITEM_UNIT";
            this.colItemUnit.Name = "colItemUnit";
            this.colItemUnit.Visible = true;
            this.colItemUnit.VisibleIndex = 4;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Malzeme";
            this.colItemName.FieldName = "STOCKDETAIL_ITEM_NAME";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // prj0011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0011";
            this.Text = "Stok Öneri Listesi";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).EndInit();
            this.gControlDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl gControlDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnTransferSelecteds;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcStockDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockDetail;
        private System.Windows.Forms.BindingSource stockDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_BARCODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_QUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colStore;
        private DevExpress.XtraGrid.Columns.GridColumn colItemUnit;
    }
}