namespace WiodySM.UI.Forms.Definition
{
    partial class def0007
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(def0007));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcContract = new DevExpress.XtraGrid.GridControl();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvContract = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCONTRACT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTRACT_TOTALPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTRACT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterContract = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceCut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContract)).BeginInit();
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
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1178, 89);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlem";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(119, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 60);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(63, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 60);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(5, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 60);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Yeni";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcContract);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Liste";
            // 
            // gcContract
            // 
            this.gcContract.DataSource = this.contractBindingSource;
            this.gcContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContract.Location = new System.Drawing.Point(2, 20);
            this.gcContract.MainView = this.gvContract;
            this.gcContract.Name = "gcContract";
            this.gcContract.Size = new System.Drawing.Size(1174, 438);
            this.gcContract.TabIndex = 0;
            this.gcContract.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContract});
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.Contract);
            // 
            // gvContract
            // 
            this.gvContract.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCONTRACT_NAME,
            this.colCONTRACT_TOTALPRICE,
            this.colCONTRACT_DATE,
            this.colMasterContract,
            this.colPriceCut});
            this.gvContract.GridControl = this.gcContract;
            this.gvContract.Name = "gvContract";
            // 
            // colCONTRACT_NAME
            // 
            this.colCONTRACT_NAME.Caption = "Sözleşme Adı";
            this.colCONTRACT_NAME.DisplayFormat.FormatString = "DateTime \"dd/MM/yyyy hh:mm:ss\"";
            this.colCONTRACT_NAME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCONTRACT_NAME.FieldName = "CONTRACT_NAME";
            this.colCONTRACT_NAME.Name = "colCONTRACT_NAME";
            this.colCONTRACT_NAME.Visible = true;
            this.colCONTRACT_NAME.VisibleIndex = 0;
            // 
            // colCONTRACT_TOTALPRICE
            // 
            this.colCONTRACT_TOTALPRICE.Caption = "Toplam Tutar";
            this.colCONTRACT_TOTALPRICE.FieldName = "CONTRACT_TOTALPRICE";
            this.colCONTRACT_TOTALPRICE.Name = "colCONTRACT_TOTALPRICE";
            this.colCONTRACT_TOTALPRICE.Visible = true;
            this.colCONTRACT_TOTALPRICE.VisibleIndex = 1;
            // 
            // colCONTRACT_DATE
            // 
            this.colCONTRACT_DATE.Caption = "Sözleşme Tarihi";
            this.colCONTRACT_DATE.DisplayFormat.FormatString = "d";
            this.colCONTRACT_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCONTRACT_DATE.FieldName = "CONTRACT_DATE";
            this.colCONTRACT_DATE.Name = "colCONTRACT_DATE";
            this.colCONTRACT_DATE.Visible = true;
            this.colCONTRACT_DATE.VisibleIndex = 2;
            // 
            // colMasterContract
            // 
            this.colMasterContract.Caption = "Üst Sözleşme";
            this.colMasterContract.FieldName = "MasterContract.CONTRACT_NAME";
            this.colMasterContract.Name = "colMasterContract";
            this.colMasterContract.Visible = true;
            this.colMasterContract.VisibleIndex = 3;
            // 
            // colPriceCut
            // 
            this.colPriceCut.Caption = "Tenzilat";
            this.colPriceCut.FieldName = "CONTRACT_PRICECUTRATE";
            this.colPriceCut.Name = "colPriceCut";
            this.colPriceCut.Visible = true;
            this.colPriceCut.VisibleIndex = 4;
            // 
            // def0007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "def0007";
            this.Text = "Sözleşme Tanımları";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcContract;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContract;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTRACT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTRACT_TOTALPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTRACT_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterContract;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceCut;
    }
}