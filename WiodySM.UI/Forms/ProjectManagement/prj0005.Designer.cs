namespace WiodySM.UI.Forms.ProjectManagement
{
    partial class prj0005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prj0005));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcProjectManager = new DevExpress.XtraGrid.GridControl();
            this.projectManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProjectManager = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueUser = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSER_NAME_SURNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).BeginInit();
            this.gControlDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProjectManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjectManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.gcProject, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 530);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gcProject
            // 
            this.gcProject.DataSource = this.projectBindingSource;
            this.gcProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProject.Location = new System.Drawing.Point(203, 3);
            this.gcProject.MainView = this.gvProject;
            this.gcProject.Name = "gcProject";
            this.gcProject.Size = new System.Drawing.Size(968, 527);
            this.gcProject.TabIndex = 1;
            this.gcProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProject});
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
            this.gvProject.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvProject_FocusedRowChanged);
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl1);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.lueUser);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(194, 527);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Giriş";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcProjectManager);
            this.groupControl1.Location = new System.Drawing.Point(5, 141);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(182, 381);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Şantiye Şefleri";
            // 
            // gcProjectManager
            // 
            this.gcProjectManager.DataSource = this.projectManagerBindingSource;
            this.gcProjectManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProjectManager.Location = new System.Drawing.Point(2, 23);
            this.gcProjectManager.MainView = this.gvProjectManager;
            this.gcProjectManager.Name = "gcProjectManager";
            this.gcProjectManager.Size = new System.Drawing.Size(178, 356);
            this.gcProjectManager.TabIndex = 0;
            this.gcProjectManager.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProjectManager});
            // 
            // projectManagerBindingSource
            // 
            this.projectManagerBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.ProjectManager);
            // 
            // gvProjectManager
            // 
            this.gvProjectManager.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser});
            this.gvProjectManager.GridControl = this.gcProjectManager;
            this.gvProjectManager.Name = "gvProjectManager";
            // 
            // colUser
            // 
            this.colUser.Caption = "Personel";
            this.colUser.FieldName = "User.USER_NAME_SURNAME";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDelete);
            this.groupControl4.Controls.Add(this.btnSave);
            this.groupControl4.Location = new System.Drawing.Point(3, 49);
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
            // lueUser
            // 
            this.lueUser.EditValue = "";
            this.lueUser.Location = new System.Drawing.Point(62, 23);
            this.lueUser.Name = "lueUser";
            this.lueUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUser.Properties.DataSource = this.userBindingSource;
            this.lueUser.Properties.DisplayMember = "USER_NAME_SURNAME";
            this.lueUser.Properties.PopupView = this.gridView3;
            this.lueUser.Properties.ValueMember = "ID";
            this.lueUser.Size = new System.Drawing.Size(125, 20);
            this.lueUser.TabIndex = 1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSER_NAME_SURNAME});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Personel";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // colUSER_NAME_SURNAME
            // 
            this.colUSER_NAME_SURNAME.Caption = "Detay";
            this.colUSER_NAME_SURNAME.FieldName = "USER_NAME_SURNAME";
            this.colUSER_NAME_SURNAME.Name = "colUSER_NAME_SURNAME";
            this.colUSER_NAME_SURNAME.Visible = true;
            this.colUSER_NAME_SURNAME.VisibleIndex = 0;
            // 
            // prj0005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "prj0005";
            this.Text = "Proje Başlangıç";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlDetail)).EndInit();
            this.gControlDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProjectManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjectManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
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
        private DevExpress.XtraEditors.SearchLookUpEdit lueUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcProjectManager;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProjectManager;
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
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource projectManagerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NAME_SURNAME;
    }
}