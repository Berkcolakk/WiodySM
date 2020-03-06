namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0008
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0008));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnItemDemandDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueProject = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_PYP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcStockMaster = new DevExpress.XtraGrid.GridControl();
            this.stockMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStockMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).BeginInit();
            this.gControlDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockMaster)).BeginInit();
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcStockMaster, 1, 0);
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
            this.groupControl3.Controls.Add(this.lueProject);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(182, 527);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Giriş";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnItemDemandDetail);
            this.groupControl4.Controls.Add(this.btnDelete);
            this.groupControl4.Controls.Add(this.btnSave);
            this.groupControl4.Location = new System.Drawing.Point(3, 49);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(173, 88);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "İşlem";
            // 
            // btnItemDemandDetail
            // 
            this.btnItemDemandDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDemandDetail.ImageOptions.Image")));
            this.btnItemDemandDetail.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnItemDemandDetail.Location = new System.Drawing.Point(117, 21);
            this.btnItemDemandDetail.Name = "btnItemDemandDetail";
            this.btnItemDemandDetail.Size = new System.Drawing.Size(50, 60);
            this.btnItemDemandDetail.TabIndex = 14;
            this.btnItemDemandDetail.Text = "Detay";
            this.btnItemDemandDetail.Click += new System.EventHandler(this.btnItemDemandDetail_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(61, 21);
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
            this.btnSave.Location = new System.Drawing.Point(5, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 60);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lueProject
            // 
            this.lueProject.EditValue = "";
            this.lueProject.Location = new System.Drawing.Point(62, 23);
            this.lueProject.Name = "lueProject";
            this.lueProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProject.Properties.DataSource = this.projectBindingSource;
            this.lueProject.Properties.DisplayMember = "PROJECT_PYP_NO";
            this.lueProject.Properties.PopupView = this.gridView3;
            this.lueProject.Properties.ValueMember = "ID";
            this.lueProject.Size = new System.Drawing.Size(114, 20);
            this.lueProject.TabIndex = 1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_PYP_NO});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colPROJECT_PYP_NO
            // 
            this.colPROJECT_PYP_NO.Caption = "Detay";
            this.colPROJECT_PYP_NO.FieldName = "PROJECT_PYP_NO";
            this.colPROJECT_PYP_NO.Name = "colPROJECT_PYP_NO";
            this.colPROJECT_PYP_NO.Visible = true;
            this.colPROJECT_PYP_NO.VisibleIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Proje";
            // 
            // gcStockMaster
            // 
            this.gcStockMaster.DataSource = this.stockMasterBindingSource;
            this.gcStockMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStockMaster.Location = new System.Drawing.Point(191, 3);
            this.gcStockMaster.MainView = this.gvStockMaster;
            this.gcStockMaster.Name = "gcStockMaster";
            this.gcStockMaster.Size = new System.Drawing.Size(980, 527);
            this.gcStockMaster.TabIndex = 1;
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
            this.colType,
            this.colPYP,
            this.colDate,
            this.colID});
            this.gvStockMaster.GridControl = this.gcStockMaster;
            this.gvStockMaster.Name = "gvStockMaster";
            // 
            // colType
            // 
            this.colType.Caption = "Tip";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 0;
            // 
            // colPYP
            // 
            this.colPYP.Caption = "PYP";
            this.colPYP.FieldName = "PYP";
            this.colPYP.Name = "colPYP";
            this.colPYP.Visible = true;
            this.colPYP.VisibleIndex = 1;
            // 
            // colDate
            // 
            this.colDate.Caption = "Kayıt Tarih";
            this.colDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "CREATED_DATE";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            // 
            // colID
            // 
            this.colID.Caption = "No";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // prj0008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0008";
            this.Text = "Proje Malzeme Sarf";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).EndInit();
            this.gControlDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.SearchLookUpEdit lueProject;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnItemDemandDetail;
        private DevExpress.XtraGrid.GridControl gcStockMaster;
        private System.Windows.Forms.BindingSource stockMasterBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colPYP;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_PYP_NO;
    }
}