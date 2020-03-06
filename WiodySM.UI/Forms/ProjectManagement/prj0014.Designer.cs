namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0014
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0014));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDecline = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnItemDemandDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gcItemDemandMaster = new DevExpress.XtraGrid.GridControl();
            this.itemDemandMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvItemDemandMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_ItemDemandMaster_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).BeginInit();
            this.gControlDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItemDemandMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDemandMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemDemandMaster)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.gcItemDemandMaster, 1, 0);
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
            this.groupControl3.Size = new System.Drawing.Size(182, 527);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Giriş";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDecline);
            this.groupControl4.Controls.Add(this.btnConfirm);
            this.groupControl4.Controls.Add(this.btnItemDemandDetail);
            this.groupControl4.Location = new System.Drawing.Point(4, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(173, 90);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "İşlem";
            // 
            // btnDecline
            // 
            this.btnDecline.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDecline.ImageOptions.Image")));
            this.btnDecline.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDecline.Location = new System.Drawing.Point(117, 25);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(50, 60);
            this.btnDecline.TabIndex = 16;
            this.btnDecline.Text = "İptal";
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnConfirm.Location = new System.Drawing.Point(61, 25);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(50, 60);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnItemDemandDetail
            // 
            this.btnItemDemandDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDemandDetail.ImageOptions.Image")));
            this.btnItemDemandDetail.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnItemDemandDetail.Location = new System.Drawing.Point(5, 25);
            this.btnItemDemandDetail.Name = "btnItemDemandDetail";
            this.btnItemDemandDetail.Size = new System.Drawing.Size(50, 60);
            this.btnItemDemandDetail.TabIndex = 14;
            this.btnItemDemandDetail.Text = "Detay";
            this.btnItemDemandDetail.Click += new System.EventHandler(this.btnItemDemandDetail_Click);
            // 
            // gcItemDemandMaster
            // 
            this.gcItemDemandMaster.DataSource = this.itemDemandMasterBindingSource;
            this.gcItemDemandMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItemDemandMaster.Location = new System.Drawing.Point(191, 3);
            this.gcItemDemandMaster.MainView = this.gvItemDemandMaster;
            this.gcItemDemandMaster.Name = "gcItemDemandMaster";
            this.gcItemDemandMaster.Size = new System.Drawing.Size(980, 527);
            this.gcItemDemandMaster.TabIndex = 1;
            this.gcItemDemandMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItemDemandMaster});
            // 
            // itemDemandMasterBindingSource
            // 
            this.itemDemandMasterBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.ItemDemandMaster);
            // 
            // gvItemDemandMaster
            // 
            this.gvItemDemandMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProject,
            this.colParameterDetail_ItemDemandMaster_State,
            this.colID,
            this.colCREATED_DATE,
            this.colUSERID});
            this.gvItemDemandMaster.GridControl = this.gcItemDemandMaster;
            this.gvItemDemandMaster.Name = "gvItemDemandMaster";
            // 
            // colProject
            // 
            this.colProject.Caption = "Proje PYP";
            this.colProject.FieldName = "Project.PROJECT_PYP_NO";
            this.colProject.Name = "colProject";
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 1;
            this.colProject.Width = 367;
            // 
            // colParameterDetail_ItemDemandMaster_State
            // 
            this.colParameterDetail_ItemDemandMaster_State.Caption = "Durum";
            this.colParameterDetail_ItemDemandMaster_State.FieldName = "ParameterDetail_ItemDemandMaster_State.PARAMETERDETAIL_NAME";
            this.colParameterDetail_ItemDemandMaster_State.Name = "colParameterDetail_ItemDemandMaster_State";
            this.colParameterDetail_ItemDemandMaster_State.Visible = true;
            this.colParameterDetail_ItemDemandMaster_State.VisibleIndex = 2;
            this.colParameterDetail_ItemDemandMaster_State.Width = 294;
            // 
            // colID
            // 
            this.colID.Caption = "No";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 154;
            // 
            // colCREATED_DATE
            // 
            this.colCREATED_DATE.Caption = "Kayıt Tarihi";
            this.colCREATED_DATE.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colCREATED_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCREATED_DATE.FieldName = "CREATED_DATE";
            this.colCREATED_DATE.Name = "colCREATED_DATE";
            this.colCREATED_DATE.Visible = true;
            this.colCREATED_DATE.VisibleIndex = 3;
            this.colCREATED_DATE.Width = 147;
            // 
            // colUSERID
            // 
            this.colUSERID.Caption = "Personel";
            this.colUSERID.FieldName = "User.USER_NAME_SURNAME";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.Visible = true;
            this.colUSERID.VisibleIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // prj0014
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0014";
            this.Text = "Malzeme Talepleri";
            this.Load += new System.EventHandler(this.prj0014_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).EndInit();
            this.gControlDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItemDemandMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDemandMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemDemandMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl gControlDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnItemDemandDetail;
        private DevExpress.XtraGrid.GridControl gcItemDemandMaster;
        private System.Windows.Forms.BindingSource itemDemandMasterBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItemDemandMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_ItemDemandMaster_State;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATED_DATE;
        private DevExpress.XtraEditors.SimpleButton btnDecline;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERID;
    }
}