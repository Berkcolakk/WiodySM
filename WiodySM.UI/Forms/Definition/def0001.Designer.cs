namespace WiodySM.UI.Forms.Definition
{
    partial class def0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(def0001));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcCompany = new DevExpress.XtraGrid.GridControl();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMPANY_TAXNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY_TAXNUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY_COMPANY_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY_PHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY_FAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY_ADRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParameterDetail_Company_Store = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY_SUBCONTRACTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).BeginInit();
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
            this.groupControl2.Controls.Add(this.gcCompany);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Liste";
            // 
            // gcCompany
            // 
            this.gcCompany.DataSource = this.companyBindingSource;
            this.gcCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCompany.Location = new System.Drawing.Point(2, 20);
            this.gcCompany.MainView = this.gvCompany;
            this.gcCompany.Name = "gcCompany";
            this.gcCompany.Size = new System.Drawing.Size(1174, 438);
            this.gcCompany.TabIndex = 0;
            this.gcCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompany});
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.Company);
            // 
            // gvCompany
            // 
            this.gvCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMPANY_TAXNAME,
            this.colCOMPANY_TAXNUMBER,
            this.colCOMPANY_COMPANY_NAME,
            this.colCOMPANY_PHONE,
            this.colCOMPANY_FAX,
            this.colCOMPANY_ADRESS,
            this.colParameterDetail_Company_Store,
            this.colCOMPANY_SUBCONTRACTOR});
            this.gvCompany.GridControl = this.gcCompany;
            this.gvCompany.Name = "gvCompany";
            // 
            // colCOMPANY_TAXNAME
            // 
            this.colCOMPANY_TAXNAME.Caption = "Vergi Daire";
            this.colCOMPANY_TAXNAME.FieldName = "COMPANY_TAXNAME";
            this.colCOMPANY_TAXNAME.Name = "colCOMPANY_TAXNAME";
            this.colCOMPANY_TAXNAME.Visible = true;
            this.colCOMPANY_TAXNAME.VisibleIndex = 1;
            // 
            // colCOMPANY_TAXNUMBER
            // 
            this.colCOMPANY_TAXNUMBER.Caption = "Vergi No";
            this.colCOMPANY_TAXNUMBER.FieldName = "COMPANY_TAXNUMBER";
            this.colCOMPANY_TAXNUMBER.Name = "colCOMPANY_TAXNUMBER";
            this.colCOMPANY_TAXNUMBER.Visible = true;
            this.colCOMPANY_TAXNUMBER.VisibleIndex = 2;
            // 
            // colCOMPANY_COMPANY_NAME
            // 
            this.colCOMPANY_COMPANY_NAME.Caption = "Firma";
            this.colCOMPANY_COMPANY_NAME.FieldName = "COMPANY_COMPANY_NAME";
            this.colCOMPANY_COMPANY_NAME.Name = "colCOMPANY_COMPANY_NAME";
            this.colCOMPANY_COMPANY_NAME.Visible = true;
            this.colCOMPANY_COMPANY_NAME.VisibleIndex = 0;
            // 
            // colCOMPANY_PHONE
            // 
            this.colCOMPANY_PHONE.Caption = "Telefon";
            this.colCOMPANY_PHONE.FieldName = "COMPANY_PHONE";
            this.colCOMPANY_PHONE.Name = "colCOMPANY_PHONE";
            this.colCOMPANY_PHONE.Visible = true;
            this.colCOMPANY_PHONE.VisibleIndex = 3;
            // 
            // colCOMPANY_FAX
            // 
            this.colCOMPANY_FAX.Caption = "Fax";
            this.colCOMPANY_FAX.FieldName = "COMPANY_FAX";
            this.colCOMPANY_FAX.Name = "colCOMPANY_FAX";
            this.colCOMPANY_FAX.Visible = true;
            this.colCOMPANY_FAX.VisibleIndex = 4;
            // 
            // colCOMPANY_ADRESS
            // 
            this.colCOMPANY_ADRESS.Caption = "Adres";
            this.colCOMPANY_ADRESS.FieldName = "COMPANY_ADRESS";
            this.colCOMPANY_ADRESS.Name = "colCOMPANY_ADRESS";
            this.colCOMPANY_ADRESS.Visible = true;
            this.colCOMPANY_ADRESS.VisibleIndex = 5;
            // 
            // colParameterDetail_Company_Store
            // 
            this.colParameterDetail_Company_Store.Caption = "Sanal Depo";
            this.colParameterDetail_Company_Store.FieldName = "ParameterDetail_Company_Store.PARAMETERDETAIL_NAME";
            this.colParameterDetail_Company_Store.Name = "colParameterDetail_Company_Store";
            this.colParameterDetail_Company_Store.Visible = true;
            this.colParameterDetail_Company_Store.VisibleIndex = 6;
            // 
            // colCOMPANY_SUBCONTRACTOR
            // 
            this.colCOMPANY_SUBCONTRACTOR.Caption = "Taşeron";
            this.colCOMPANY_SUBCONTRACTOR.FieldName = "COMPANY_SUBCONTRACTOR";
            this.colCOMPANY_SUBCONTRACTOR.Name = "colCOMPANY_SUBCONTRACTOR";
            this.colCOMPANY_SUBCONTRACTOR.Visible = true;
            this.colCOMPANY_SUBCONTRACTOR.VisibleIndex = 7;
            // 
            // def0001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "def0001";
            this.Text = "Firma Tanımları";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_TAXNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_TAXNUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_COMPANY_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_PHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_FAX;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_ADRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterDetail_Company_Store;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY_SUBCONTRACTOR;
    }
}