namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0010
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0010));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gcStockDetail = new DevExpress.XtraGrid.GridControl();
            this.stockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTOCKDETAIL_BARCODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKDETAIL_QUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_StockDetail_Store = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrivate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrivate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gContForm = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCableEnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCableStart = new DevExpress.XtraEditors.TextEdit();
            this.lueStore = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPARAMETERDETAIL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnItemDemandDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnMRPList = new DevExpress.XtraEditors.SimpleButton();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).BeginInit();
            this.gControlDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gContForm)).BeginInit();
            this.gContForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.gcStockDetail, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gContForm, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 533);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.gcStockDetail.DoubleClick += new System.EventHandler(this.gcStockDetail_DoubleClick);
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
            this.colItem,
            this.colParameterDetail_StockDetail_Store,
            this.colItemCode,
            this.colPrivate1,
            this.colPrivate2});
            this.gvStockDetail.GridControl = this.gcStockDetail;
            this.gvStockDetail.Name = "gvStockDetail";
            // 
            // colSTOCKDETAIL_BARCODE_ID
            // 
            this.colSTOCKDETAIL_BARCODE_ID.Caption = "Barkod";
            this.colSTOCKDETAIL_BARCODE_ID.FieldName = "STOCKDETAIL_BARCODE_ID";
            this.colSTOCKDETAIL_BARCODE_ID.Name = "colSTOCKDETAIL_BARCODE_ID";
            this.colSTOCKDETAIL_BARCODE_ID.Visible = true;
            this.colSTOCKDETAIL_BARCODE_ID.VisibleIndex = 2;
            // 
            // colSTOCKDETAIL_QUANTITY
            // 
            this.colSTOCKDETAIL_QUANTITY.Caption = "Miktar";
            this.colSTOCKDETAIL_QUANTITY.FieldName = "STOCKDETAIL_QUANTITY";
            this.colSTOCKDETAIL_QUANTITY.Name = "colSTOCKDETAIL_QUANTITY";
            this.colSTOCKDETAIL_QUANTITY.Visible = true;
            this.colSTOCKDETAIL_QUANTITY.VisibleIndex = 4;
            // 
            // colItem
            // 
            this.colItem.Caption = "Malzeme";
            this.colItem.FieldName = "Item.ITEM_NAME";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            // 
            // colParameterDetail_StockDetail_Store
            // 
            this.colParameterDetail_StockDetail_Store.Caption = "Depo";
            this.colParameterDetail_StockDetail_Store.FieldName = "ParameterDetail_StockDetail_Store.PARAMETERDETAIL_NAME";
            this.colParameterDetail_StockDetail_Store.Name = "colParameterDetail_StockDetail_Store";
            this.colParameterDetail_StockDetail_Store.Visible = true;
            this.colParameterDetail_StockDetail_Store.VisibleIndex = 3;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Malzeme Kodu";
            this.colItemCode.FieldName = "Item.ITEM_CODE";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            // 
            // colPrivate1
            // 
            this.colPrivate1.Caption = "Kablo Uç 1";
            this.colPrivate1.FieldName = "STOCKDETAIL_PRIVATEVALUE1";
            this.colPrivate1.Name = "colPrivate1";
            this.colPrivate1.Visible = true;
            this.colPrivate1.VisibleIndex = 5;
            // 
            // colPrivate2
            // 
            this.colPrivate2.Caption = "Kablo Uç 2";
            this.colPrivate2.FieldName = "STOCKDETAIL_PRIVATEVALUE2";
            this.colPrivate2.Name = "colPrivate2";
            this.colPrivate2.Visible = true;
            this.colPrivate2.VisibleIndex = 6;
            // 
            // gContForm
            // 
            this.gContForm.Controls.Add(this.labelControl4);
            this.gContForm.Controls.Add(this.txtCableEnd);
            this.gContForm.Controls.Add(this.labelControl2);
            this.gContForm.Controls.Add(this.txtCableStart);
            this.gContForm.Controls.Add(this.lueStore);
            this.gContForm.Controls.Add(this.labelControl1);
            this.gContForm.Controls.Add(this.labelControl3);
            this.gContForm.Controls.Add(this.txtQuantity);
            this.gContForm.Controls.Add(this.labelControl7);
            this.gContForm.Controls.Add(this.txtBarcode);
            this.gContForm.Controls.Add(this.groupControl4);
            this.gContForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gContForm.Location = new System.Drawing.Point(3, 3);
            this.gContForm.Name = "gContForm";
            this.gContForm.Size = new System.Drawing.Size(194, 527);
            this.gContForm.TabIndex = 0;
            this.gContForm.Text = "Giriş";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Kablo Uç 2";
            // 
            // txtCableEnd
            // 
            this.txtCableEnd.Location = new System.Drawing.Point(63, 137);
            this.txtCableEnd.Name = "txtCableEnd";
            this.txtCableEnd.Size = new System.Drawing.Size(125, 20);
            this.txtCableEnd.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Kablo Uç 1";
            // 
            // txtCableStart
            // 
            this.txtCableStart.Location = new System.Drawing.Point(63, 111);
            this.txtCableStart.Name = "txtCableStart";
            this.txtCableStart.Size = new System.Drawing.Size(125, 20);
            this.txtCableStart.TabIndex = 17;
            // 
            // lueStore
            // 
            this.lueStore.EditValue = "";
            this.lueStore.Location = new System.Drawing.Point(63, 33);
            this.lueStore.Name = "lueStore";
            this.lueStore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStore.Properties.DataSource = this.storeBindingSource;
            this.lueStore.Properties.DisplayMember = "PARAMETERDETAIL_NAME";
            this.lueStore.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueStore.Properties.ValueMember = "ID";
            this.lueStore.Size = new System.Drawing.Size(125, 20);
            this.lueStore.TabIndex = 16;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPARAMETERDETAIL_NAME});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPARAMETERDETAIL_NAME
            // 
            this.colPARAMETERDETAIL_NAME.Caption = "Detay";
            this.colPARAMETERDETAIL_NAME.FieldName = "PARAMETERDETAIL_NAME";
            this.colPARAMETERDETAIL_NAME.Name = "colPARAMETERDETAIL_NAME";
            this.colPARAMETERDETAIL_NAME.Visible = true;
            this.colPARAMETERDETAIL_NAME.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Depo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Miktar";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(63, 85);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 62);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Barkod";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(63, 59);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(125, 20);
            this.txtBarcode.TabIndex = 11;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnItemDemandDetail);
            this.groupControl4.Controls.Add(this.btnSave);
            this.groupControl4.Controls.Add(this.btnDelete);
            this.groupControl4.Controls.Add(this.btnMRPList);
            this.groupControl4.Location = new System.Drawing.Point(3, 185);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(184, 152);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "İşlem";
            // 
            // btnItemDemandDetail
            // 
            this.btnItemDemandDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDemandDetail.ImageOptions.Image")));
            this.btnItemDemandDetail.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnItemDemandDetail.Location = new System.Drawing.Point(120, 23);
            this.btnItemDemandDetail.Name = "btnItemDemandDetail";
            this.btnItemDemandDetail.Size = new System.Drawing.Size(50, 60);
            this.btnItemDemandDetail.TabIndex = 16;
            this.btnItemDemandDetail.Text = "Detay";
            this.btnItemDemandDetail.Click += new System.EventHandler(this.btnItemDemandDetail_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(7, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 60);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(64, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 60);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnMRPList
            // 
            this.btnMRPList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMRPList.ImageOptions.Image")));
            this.btnMRPList.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMRPList.Location = new System.Drawing.Point(5, 87);
            this.btnMRPList.Name = "btnMRPList";
            this.btnMRPList.Size = new System.Drawing.Size(174, 60);
            this.btnMRPList.TabIndex = 12;
            this.btnMRPList.Text = "Listeden Seç";
            this.btnMRPList.Click += new System.EventHandler(this.btnMRPList_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // prj0010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0010";
            this.Text = "Talepten Malzeme Çıkış";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).EndInit();
            this.gControlDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gContForm)).EndInit();
            this.gContForm.ResumeLayout(false);
            this.gContForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraEditors.GroupControl gControlDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl gContForm;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnMRPList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gcStockDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockDetail;
        private System.Windows.Forms.BindingSource stockDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_BARCODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_QUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_StockDetail_Store;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SearchLookUpEdit lueStore;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPARAMETERDETAIL_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnItemDemandDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPrivate1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrivate2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCableEnd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCableStart;
    }
}