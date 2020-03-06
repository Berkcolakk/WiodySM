namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0012
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0012));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.lueActiveStockDetail = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.activeStockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcStockDetail = new DevExpress.XtraGrid.GridControl();
            this.stockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTOCKDETAIL_BARCODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKDETAIL_QUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCableEnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCableStart = new DevExpress.XtraEditors.TextEdit();
            this.colPrivate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrivate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).BeginInit();
            this.gControlDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueActiveStockDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeStockDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableStart.Properties)).BeginInit();
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
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.txtCableStart);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txtCableEnd);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.txtQuantity);
            this.groupControl3.Controls.Add(this.lueActiveStockDetail);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(194, 527);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Giriş";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDelete);
            this.groupControl4.Controls.Add(this.btnSave);
            this.groupControl4.Location = new System.Drawing.Point(3, 128);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(184, 86);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "İşlem";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(87, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 60);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(31, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 60);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Miktar";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(62, 50);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // lueActiveStockDetail
            // 
            this.lueActiveStockDetail.EditValue = "";
            this.lueActiveStockDetail.Location = new System.Drawing.Point(62, 23);
            this.lueActiveStockDetail.Name = "lueActiveStockDetail";
            this.lueActiveStockDetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueActiveStockDetail.Properties.DataSource = this.activeStockDetailBindingSource;
            this.lueActiveStockDetail.Properties.DisplayMember = "STOCKDETAIL_ITEM_NAME";
            this.lueActiveStockDetail.Properties.PopupView = this.gridView3;
            this.lueActiveStockDetail.Properties.ValueMember = "STOCKDETAIL_BARCODE_ID";
            this.lueActiveStockDetail.Size = new System.Drawing.Size(125, 20);
            this.lueActiveStockDetail.TabIndex = 1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarcode,
            this.gridColumn2,
            this.colItemName,
            this.colQuantity});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Barkod";
            this.colBarcode.FieldName = "STOCKDETAIL_BARCODE_ID";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Malzeme Kodu";
            this.gridColumn2.FieldName = "STOCKDETAIL_ITEM_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Malzeme";
            this.colItemName.FieldName = "STOCKDETAIL_ITEM_NAME";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Stok";
            this.colQuantity.FieldName = "STOCKDETAIL_QUANTITY";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Ürün";
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
            this.colItem,
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
            this.colSTOCKDETAIL_BARCODE_ID.VisibleIndex = 0;
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
            this.colItem.Caption = "Malzeme";
            this.colItem.FieldName = "Item.ITEM_NAME";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 1;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Malzeme Kodu";
            this.colItemCode.FieldName = "Item.ITEM_CODE";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Kablo Uç 2";
            // 
            // txtCableEnd
            // 
            this.txtCableEnd.Location = new System.Drawing.Point(62, 102);
            this.txtCableEnd.Name = "txtCableEnd";
            this.txtCableEnd.Size = new System.Drawing.Size(125, 20);
            this.txtCableEnd.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Kablo Uç 1";
            // 
            // txtCableStart
            // 
            this.txtCableStart.Location = new System.Drawing.Point(62, 76);
            this.txtCableStart.Name = "txtCableStart";
            this.txtCableStart.Size = new System.Drawing.Size(125, 20);
            this.txtCableStart.TabIndex = 11;
            // 
            // colPrivate1
            // 
            this.colPrivate1.Caption = "Kablo Uç 1";
            this.colPrivate1.FieldName = "STOCKDETAIL_PRIVATEVALUE1";
            this.colPrivate1.Name = "colPrivate1";
            this.colPrivate1.Visible = true;
            this.colPrivate1.VisibleIndex = 4;
            // 
            // colPrivate2
            // 
            this.colPrivate2.Caption = "Kablo Uç 2";
            this.colPrivate2.FieldName = "STOCKDETAIL_PRIVATEVALUE2";
            this.colPrivate2.Name = "colPrivate2";
            this.colPrivate2.Visible = true;
            this.colPrivate2.VisibleIndex = 5;
            // 
            // prj0012
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0012";
            this.Text = "Malzeme Sarf";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).EndInit();
            this.gControlDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueActiveStockDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeStockDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCableStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl gControlDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.SearchLookUpEdit lueActiveStockDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource activeStockDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.GridControl gcStockDetail;
        private System.Windows.Forms.BindingSource stockDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_BARCODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKDETAIL_QUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCableStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCableEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colPrivate1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrivate2;
    }
}