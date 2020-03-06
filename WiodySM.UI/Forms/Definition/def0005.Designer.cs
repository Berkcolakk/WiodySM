namespace WiodySM.UI.Forms.Definition
{
    partial class def0005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(def0005));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcItem = new DevExpress.XtraGrid.GridControl();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_ASSM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_DEASSM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_DEASSMDE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItem)).BeginInit();
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
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.groupControl2.Controls.Add(this.gcItem);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Liste";
            // 
            // gcItem
            // 
            this.gcItem.DataSource = this.itemBindingSource;
            this.gcItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItem.Location = new System.Drawing.Point(2, 20);
            this.gcItem.MainView = this.gvItem;
            this.gcItem.Name = "gcItem";
            this.gcItem.Size = new System.Drawing.Size(1174, 438);
            this.gcItem.TabIndex = 0;
            this.gcItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItem});
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.Item);
            // 
            // gvItem
            // 
            this.gvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEM_CODE,
            this.colITEM_ASSM_CODE,
            this.colITEM_DEASSM_CODE,
            this.colITEM_DEASSMDE_CODE,
            this.colITEM_DESCRIPTION,
            this.colITEM_NAME});
            this.gvItem.GridControl = this.gcItem;
            this.gvItem.Name = "gvItem";
            // 
            // colITEM_CODE
            // 
            this.colITEM_CODE.Caption = "Ürün Kodu";
            this.colITEM_CODE.FieldName = "ITEM_CODE";
            this.colITEM_CODE.Name = "colITEM_CODE";
            this.colITEM_CODE.Visible = true;
            this.colITEM_CODE.VisibleIndex = 0;
            // 
            // colITEM_ASSM_CODE
            // 
            this.colITEM_ASSM_CODE.Caption = "Montaj";
            this.colITEM_ASSM_CODE.FieldName = "ITEM_ASSM_CODE";
            this.colITEM_ASSM_CODE.Name = "colITEM_ASSM_CODE";
            this.colITEM_ASSM_CODE.Visible = true;
            this.colITEM_ASSM_CODE.VisibleIndex = 2;
            // 
            // colITEM_DEASSM_CODE
            // 
            this.colITEM_DEASSM_CODE.Caption = "Demontaj";
            this.colITEM_DEASSM_CODE.FieldName = "ITEM_DEASSM_CODE";
            this.colITEM_DEASSM_CODE.Name = "colITEM_DEASSM_CODE";
            this.colITEM_DEASSM_CODE.Visible = true;
            this.colITEM_DEASSM_CODE.VisibleIndex = 3;
            // 
            // colITEM_DEASSMDE_CODE
            // 
            this.colITEM_DEASSMDE_CODE.Caption = "Demontaj Montaj";
            this.colITEM_DEASSMDE_CODE.FieldName = "ITEM_DEASSMDE_CODE";
            this.colITEM_DEASSMDE_CODE.Name = "colITEM_DEASSMDE_CODE";
            this.colITEM_DEASSMDE_CODE.Visible = true;
            this.colITEM_DEASSMDE_CODE.VisibleIndex = 4;
            // 
            // colITEM_DESCRIPTION
            // 
            this.colITEM_DESCRIPTION.Caption = "Açıklama";
            this.colITEM_DESCRIPTION.FieldName = "ITEM_DESCRIPTION";
            this.colITEM_DESCRIPTION.Name = "colITEM_DESCRIPTION";
            this.colITEM_DESCRIPTION.Visible = true;
            this.colITEM_DESCRIPTION.VisibleIndex = 5;
            // 
            // colITEM_NAME
            // 
            this.colITEM_NAME.Caption = "Ürün Adı";
            this.colITEM_NAME.FieldName = "ITEM_NAME";
            this.colITEM_NAME.Name = "colITEM_NAME";
            this.colITEM_NAME.Visible = true;
            this.colITEM_NAME.VisibleIndex = 1;
            // 
            // def0005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "def0005";
            this.Text = "Firma Tanımları";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItem;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_ASSM_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_DEASSM_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_DEASSMDE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NAME;
    }
}