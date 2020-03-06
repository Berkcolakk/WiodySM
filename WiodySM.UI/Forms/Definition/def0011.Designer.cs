namespace WiodySM.UI.Forms.Definition
{
    partial class def0011
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(def0011));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcUserRole = new DevExpress.XtraGrid.GridControl();
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvUserRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSERROLE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERROLE_ROLE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserRole)).BeginInit();
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
            this.groupControl2.Controls.Add(this.gcUserRole);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1178, 460);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Liste";
            // 
            // gcUserRole
            // 
            this.gcUserRole.DataSource = this.userRoleBindingSource;
            this.gcUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUserRole.Location = new System.Drawing.Point(2, 20);
            this.gcUserRole.MainView = this.gvUserRole;
            this.gcUserRole.Name = "gcUserRole";
            this.gcUserRole.Size = new System.Drawing.Size(1174, 438);
            this.gcUserRole.TabIndex = 0;
            this.gcUserRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUserRole});
            // 
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataSource = typeof(WiodySM.Data.Model.Entity.UserRole);
            // 
            // gvUserRole
            // 
            this.gvUserRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSERROLE_USER_ID,
            this.colUSERROLE_ROLE_ID});
            this.gvUserRole.GridControl = this.gcUserRole;
            this.gvUserRole.Name = "gvUserRole";
            // 
            // colUSERROLE_USER_ID
            // 
            this.colUSERROLE_USER_ID.Caption = "Kullanıcı";
            this.colUSERROLE_USER_ID.FieldName = "User.USER_NAME_SURNAME";
            this.colUSERROLE_USER_ID.Name = "colUSERROLE_USER_ID";
            this.colUSERROLE_USER_ID.Visible = true;
            this.colUSERROLE_USER_ID.VisibleIndex = 0;
            // 
            // colUSERROLE_ROLE_ID
            // 
            this.colUSERROLE_ROLE_ID.Caption = "Rolü";
            this.colUSERROLE_ROLE_ID.FieldName = "ParameterDetail_UserRole_Role.PARAMETERDETAIL_NAME";
            this.colUSERROLE_ROLE_ID.Name = "colUSERROLE_ROLE_ID";
            this.colUSERROLE_ROLE_ID.Visible = true;
            this.colUSERROLE_ROLE_ID.VisibleIndex = 1;
            // 
            // def0011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "def0011";
            this.Text = "Kullanıcı Rol Tanımları";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcUserRole;
        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERROLE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERROLE_ROLE_ID;
    }
}