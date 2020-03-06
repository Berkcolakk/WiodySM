namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0001));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnProjectExplore = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcProject = new DevExpress.XtraGrid.GridControl();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_PYP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_DAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_Project_ContractType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_Project_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContract = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).BeginInit();
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
            this.groupControl1.Controls.Add(this.btnProjectExplore);
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
            // btnProjectExplore
            // 
            this.btnProjectExplore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectExplore.ImageOptions.Image")));
            this.btnProjectExplore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnProjectExplore.Location = new System.Drawing.Point(175, 23);
            this.btnProjectExplore.Name = "btnProjectExplore";
            this.btnProjectExplore.Size = new System.Drawing.Size(50, 60);
            this.btnProjectExplore.TabIndex = 3;
            this.btnProjectExplore.Text = "Keşif";
            this.btnProjectExplore.Click += new System.EventHandler(this.btnProjectExplore_Click);
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
            this.groupControl2.Controls.Add(this.gcProject);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Liste";
            // 
            // gcProject
            // 
            this.gcProject.DataSource = this.projectBindingSource;
            this.gcProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProject.Location = new System.Drawing.Point(2, 20);
            this.gcProject.MainView = this.gvProject;
            this.gcProject.Name = "gcProject";
            this.gcProject.Size = new System.Drawing.Size(1174, 438);
            this.gcProject.TabIndex = 0;
            this.gcProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProject});
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.Project);
            // 
            // gvProject
            // 
            this.gvProject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_NAME,
            this.colPROJECT_PYP_NO,
            this.colPROJECT_DESC,
            this.colPROJECT_DAY,
            this.colParameterDetail_Project_ContractType,
            this.colParameterDetail_Project_State,
            this.colCompany,
            this.colContract,
            this.colPROJECT_GROUP});
            this.gvProject.GridControl = this.gcProject;
            this.gvProject.Name = "gvProject";
            // 
            // colPROJECT_NAME
            // 
            this.colPROJECT_NAME.Caption = "Proje Adı";
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
            // colPROJECT_DESC
            // 
            this.colPROJECT_DESC.Caption = "Açıklama";
            this.colPROJECT_DESC.FieldName = "PROJECT_DESC";
            this.colPROJECT_DESC.Name = "colPROJECT_DESC";
            this.colPROJECT_DESC.Visible = true;
            this.colPROJECT_DESC.VisibleIndex = 2;
            // 
            // colPROJECT_DAY
            // 
            this.colPROJECT_DAY.Caption = "Gün";
            this.colPROJECT_DAY.FieldName = "PROJECT_DAY";
            this.colPROJECT_DAY.Name = "colPROJECT_DAY";
            this.colPROJECT_DAY.Visible = true;
            this.colPROJECT_DAY.VisibleIndex = 3;
            // 
            // colParameterDetail_Project_ContractType
            // 
            this.colParameterDetail_Project_ContractType.Caption = "Tip";
            this.colParameterDetail_Project_ContractType.FieldName = "ParameterDetail_Project_ContractType.PARAMETERDETAIL_NAME";
            this.colParameterDetail_Project_ContractType.Name = "colParameterDetail_Project_ContractType";
            this.colParameterDetail_Project_ContractType.Visible = true;
            this.colParameterDetail_Project_ContractType.VisibleIndex = 4;
            // 
            // colParameterDetail_Project_State
            // 
            this.colParameterDetail_Project_State.Caption = "Durum";
            this.colParameterDetail_Project_State.FieldName = "ParameterDetail_Project_State.PARAMETERDETAIL_NAME";
            this.colParameterDetail_Project_State.Name = "colParameterDetail_Project_State";
            this.colParameterDetail_Project_State.Visible = true;
            this.colParameterDetail_Project_State.VisibleIndex = 5;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Firma";
            this.colCompany.FieldName = "Company.COMPANY_COMPANY_NAME";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 6;
            // 
            // colContract
            // 
            this.colContract.Caption = "Sözleşme";
            this.colContract.FieldName = "Contract.CONTRACT_NAME";
            this.colContract.Name = "colContract";
            this.colContract.Visible = true;
            this.colContract.VisibleIndex = 7;
            // 
            // colPROJECT_GROUP
            // 
            this.colPROJECT_GROUP.Caption = "Grup";
            this.colPROJECT_GROUP.FieldName = "PROJECT_GROUP";
            this.colPROJECT_GROUP.Name = "colPROJECT_GROUP";
            this.colPROJECT_GROUP.Visible = true;
            this.colPROJECT_GROUP.VisibleIndex = 8;
            // 
            // prj0001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0001";
            this.Text = "Proje İşlemleri";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcProject;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProject;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_PYP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_DAY;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_Project_ContractType;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_Project_State;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colContract;
        private DevExpress.XtraEditors.SimpleButton btnProjectExplore;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_GROUP;
    }
}