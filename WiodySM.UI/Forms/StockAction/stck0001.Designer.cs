namespace WiodySM.UI.Forms.StockAction
{
    partial class stck0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stck0001));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewImport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcStockMaster = new DevExpress.XtraGrid.GridControl();
            this.stockMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTOCKMASTER_WAYBILL_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKMASTER_WAYBILL_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_StockMaster_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_StockMaster_Store = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockMaster)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnReturn);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnNewImport);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1178, 89);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "İşlem";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(185, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(56, 60);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Transfer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.Image")));
            this.btnReturn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(123, 24);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(56, 60);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "İade Giriş";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(67, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 60);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewImport
            // 
            this.btnNewImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewImport.ImageOptions.Image")));
            this.btnNewImport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNewImport.Location = new System.Drawing.Point(9, 24);
            this.btnNewImport.Name = "btnNewImport";
            this.btnNewImport.Size = new System.Drawing.Size(50, 60);
            this.btnNewImport.TabIndex = 2;
            this.btnNewImport.Text = "Giriş";
            this.btnNewImport.Click += new System.EventHandler(this.btnNewImport_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcStockMaster);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Liste";
            // 
            // gcStockMaster
            // 
            this.gcStockMaster.DataSource = this.stockMasterBindingSource;
            this.gcStockMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStockMaster.Location = new System.Drawing.Point(2, 20);
            this.gcStockMaster.MainView = this.gvStockMaster;
            this.gcStockMaster.Name = "gcStockMaster";
            this.gcStockMaster.Size = new System.Drawing.Size(1174, 438);
            this.gcStockMaster.TabIndex = 0;
            this.gcStockMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStockMaster});
            // 
            // stockMasterBindingSource
            // 
            this.stockMasterBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.StockMaster);
            // 
            // gvStockMaster
            // 
            this.gvStockMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTOCKMASTER_WAYBILL_NO,
            this.colSTOCKMASTER_WAYBILL_DATE,
            this.colCompany,
            this.colSubCompany,
            this.colParameterDetail_StockMaster_Type,
            this.colParameterDetail_StockMaster_Store,
            this.colID,
            this.colCREATED_DATE});
            this.gvStockMaster.GridControl = this.gcStockMaster;
            this.gvStockMaster.Name = "gvStockMaster";
            // 
            // colSTOCKMASTER_WAYBILL_NO
            // 
            this.colSTOCKMASTER_WAYBILL_NO.Caption = "İrsaliye No";
            this.colSTOCKMASTER_WAYBILL_NO.FieldName = "STOCKMASTER_WAYBILL_NO";
            this.colSTOCKMASTER_WAYBILL_NO.Name = "colSTOCKMASTER_WAYBILL_NO";
            this.colSTOCKMASTER_WAYBILL_NO.Visible = true;
            this.colSTOCKMASTER_WAYBILL_NO.VisibleIndex = 5;
            // 
            // colSTOCKMASTER_WAYBILL_DATE
            // 
            this.colSTOCKMASTER_WAYBILL_DATE.Caption = "İrsaliye Tarihi";
            this.colSTOCKMASTER_WAYBILL_DATE.FieldName = "STOCKMASTER_WAYBILL_DATE";
            this.colSTOCKMASTER_WAYBILL_DATE.Name = "colSTOCKMASTER_WAYBILL_DATE";
            this.colSTOCKMASTER_WAYBILL_DATE.Visible = true;
            this.colSTOCKMASTER_WAYBILL_DATE.VisibleIndex = 6;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Firma";
            this.colCompany.FieldName = "Company.COMPANY_COMPANY_NAME";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 2;
            // 
            // colSubCompany
            // 
            this.colSubCompany.Caption = "Alt Fimra";
            this.colSubCompany.FieldName = "SubCompany.COMPANY_COMPANY_NAME";
            this.colSubCompany.Name = "colSubCompany";
            this.colSubCompany.Visible = true;
            this.colSubCompany.VisibleIndex = 3;
            // 
            // colParameterDetail_StockMaster_Type
            // 
            this.colParameterDetail_StockMaster_Type.Caption = "Tip";
            this.colParameterDetail_StockMaster_Type.FieldName = "ParameterDetail_StockMaster_Type.PARAMETERDETAIL_NAME";
            this.colParameterDetail_StockMaster_Type.Name = "colParameterDetail_StockMaster_Type";
            this.colParameterDetail_StockMaster_Type.Visible = true;
            this.colParameterDetail_StockMaster_Type.VisibleIndex = 1;
            // 
            // colParameterDetail_StockMaster_Store
            // 
            this.colParameterDetail_StockMaster_Store.Caption = "Depo";
            this.colParameterDetail_StockMaster_Store.FieldName = "ParameterDetail_StockMaster_Store.PARAMETERDETAIL_NAME";
            this.colParameterDetail_StockMaster_Store.Name = "colParameterDetail_StockMaster_Store";
            this.colParameterDetail_StockMaster_Store.Visible = true;
            this.colParameterDetail_StockMaster_Store.VisibleIndex = 4;
            // 
            // colID
            // 
            this.colID.Caption = "No";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCREATED_DATE
            // 
            this.colCREATED_DATE.Caption = "Fiş Tarihi";
            this.colCREATED_DATE.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colCREATED_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCREATED_DATE.FieldName = "CREATED_DATE";
            this.colCREATED_DATE.Name = "colCREATED_DATE";
            this.colCREATED_DATE.Visible = true;
            this.colCREATED_DATE.VisibleIndex = 7;
            // 
            // stck0001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "stck0001";
            this.Text = "Stok İşlemleri";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcStockMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcStockMaster;
        private System.Windows.Forms.BindingSource stockMasterBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKMASTER_WAYBILL_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKMASTER_WAYBILL_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_StockMaster_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_StockMaster_Store;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATED_DATE;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNewImport;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}