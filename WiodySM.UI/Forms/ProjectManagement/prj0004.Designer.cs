namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0004));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lueProjectState = new DevExpress.XtraEditors.LookUpEdit();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProjectExplore = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProjectState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
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
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.btnProjectExplore);
            this.groupControl1.Controls.Add(this.btnUnConfirm);
            this.groupControl1.Controls.Add(this.btnConfirm);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1178, 89);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlem";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lueProjectState);
            this.groupControl3.Location = new System.Drawing.Point(175, 24);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(177, 59);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Filtre";
            // 
            // lueProjectState
            // 
            this.lueProjectState.Location = new System.Drawing.Point(5, 23);
            this.lueProjectState.Name = "lueProjectState";
            this.lueProjectState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProjectState.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PARAMETERDETAIL_NAME", "Detay")});
            this.lueProjectState.Properties.DataSource = this.stateBindingSource;
            this.lueProjectState.Properties.DisplayMember = "PARAMETERDETAIL_NAME";
            this.lueProjectState.Properties.ValueMember = "ID";
            this.lueProjectState.Size = new System.Drawing.Size(167, 20);
            this.lueProjectState.TabIndex = 0;
            this.lueProjectState.EditValueChanged += new System.EventHandler(this.lueProjectState_EditValueChanged);
            // 
            // btnProjectExplore
            // 
            this.btnProjectExplore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectExplore.ImageOptions.Image")));
            this.btnProjectExplore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnProjectExplore.Location = new System.Drawing.Point(119, 23);
            this.btnProjectExplore.Name = "btnProjectExplore";
            this.btnProjectExplore.Size = new System.Drawing.Size(50, 60);
            this.btnProjectExplore.TabIndex = 3;
            this.btnProjectExplore.Text = "Keşif";
            this.btnProjectExplore.Click += new System.EventHandler(this.btnProjectExplore_Click);
            // 
            // btnUnConfirm
            // 
            this.btnUnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnConfirm.ImageOptions.Image")));
            this.btnUnConfirm.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnUnConfirm.Location = new System.Drawing.Point(63, 23);
            this.btnUnConfirm.Name = "btnUnConfirm";
            this.btnUnConfirm.Size = new System.Drawing.Size(50, 60);
            this.btnUnConfirm.TabIndex = 1;
            this.btnUnConfirm.Text = "İptal";
            this.btnUnConfirm.Click += new System.EventHandler(this.btnUnConfirm_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnConfirm.Location = new System.Drawing.Point(5, 23);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(50, 60);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Onay";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.gcProject.Location = new System.Drawing.Point(2, 23);
            this.gcProject.MainView = this.gvProject;
            this.gcProject.Name = "gcProject";
            this.gcProject.Size = new System.Drawing.Size(1174, 435);
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
            this.colContract});
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
            // prj0004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0004";
            this.Text = "Proje Onay";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueProjectState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnUnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
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
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LookUpEdit lueProjectState;
        private System.Windows.Forms.BindingSource stateBindingSource;
    }
}