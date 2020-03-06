namespace WiodySM.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.nbgStock = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiStockTransaction = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiStockReportCompany = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPYPActionControl = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiStockDemand = new DevExpress.XtraNavBar.NavBarItem();
            this.stckreport2 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgDefinition = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiStatic = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiUser = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiItem = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCompany = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMenuRole = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiUserRole = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgProject = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiContract = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiProject = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiProjectStart = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMyStockDemand = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMyProject = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiPayoff = new DevExpress.XtraNavBar.NavBarItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barSkin = new DevExpress.XtraBars.SkinBarSubItem();
            this.barUsername = new DevExpress.XtraBars.BarStaticItem();
            this.barDate = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Ara = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // nbgStock
            // 
            this.nbgStock.Caption = "Stok İşlemleri";
            this.nbgStock.Expanded = true;
            this.nbgStock.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiStockTransaction),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiStockReportCompany),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPYPActionControl),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiStockDemand),
            new DevExpress.XtraNavBar.NavBarItemLink(this.stckreport2)});
            this.nbgStock.Name = "nbgStock";
            // 
            // nbiStockTransaction
            // 
            this.nbiStockTransaction.Caption = "Stok Hareketleri";
            this.nbiStockTransaction.Name = "nbiStockTransaction";
            this.nbiStockTransaction.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiStockTransaction_LinkClicked);
            // 
            // nbiStockReportCompany
            // 
            this.nbiStockReportCompany.Caption = "Stok Raporu";
            this.nbiStockReportCompany.Name = "nbiStockReportCompany";
            this.nbiStockReportCompany.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiStockReportCompany_LinkClicked);
            // 
            // nbiPYPActionControl
            // 
            this.nbiPYPActionControl.Caption = "PYP Hareket Raporu";
            this.nbiPYPActionControl.Name = "nbiPYPActionControl";
            this.nbiPYPActionControl.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPYPActionControl_LinkClicked);
            // 
            // nbiStockDemand
            // 
            this.nbiStockDemand.Caption = "Malzeme Talepleri";
            this.nbiStockDemand.Name = "nbiStockDemand";
            this.nbiStockDemand.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiStockDemand_LinkClicked);
            // 
            // stckreport2
            // 
            this.stckreport2.Caption = "Stok Raporu 2";
            this.stckreport2.Name = "stckreport2";
            this.stckreport2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.stckreport2_LinkClicked);
            // 
            // nbgDefinition
            // 
            this.nbgDefinition.Caption = "Tanımlar";
            this.nbgDefinition.Expanded = true;
            this.nbgDefinition.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiStatic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCompany),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMenuRole),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUserRole)});
            this.nbgDefinition.Name = "nbgDefinition";
            // 
            // nbiStatic
            // 
            this.nbiStatic.Caption = "Sabit Tanımlar";
            this.nbiStatic.Name = "nbiStatic";
            // 
            // nbiUser
            // 
            this.nbiUser.Caption = "Kullanıcı Tanımları";
            this.nbiUser.Name = "nbiUser";
            this.nbiUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUser_LinkClicked);
            // 
            // nbiItem
            // 
            this.nbiItem.Caption = "Ürün Tanımları";
            this.nbiItem.Name = "nbiItem";
            this.nbiItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiItem_LinkClicked);
            // 
            // nbiCompany
            // 
            this.nbiCompany.Caption = "Firma Tanımları";
            this.nbiCompany.Name = "nbiCompany";
            this.nbiCompany.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCompany_LinkClicked);
            // 
            // nbiMenuRole
            // 
            this.nbiMenuRole.Caption = "Menu Rol Tanımları";
            this.nbiMenuRole.Name = "nbiMenuRole";
            this.nbiMenuRole.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMenuRole_LinkClicked);
            // 
            // nbiUserRole
            // 
            this.nbiUserRole.Caption = "Kullanıcı Rol Tanımları";
            this.nbiUserRole.Name = "nbiUserRole";
            this.nbiUserRole.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUserRole_LinkClicked);
            // 
            // nbgProject
            // 
            this.nbgProject.Caption = "Proje İşlemleri";
            this.nbgProject.Expanded = true;
            this.nbgProject.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiContract),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiProject),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiProjectStart),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMyStockDemand),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMyProject),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.nbgProject.Name = "nbgProject";
            // 
            // nbiContract
            // 
            this.nbiContract.Caption = "Sözleşme Tanımları";
            this.nbiContract.Name = "nbiContract";
            this.nbiContract.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiContract_LinkClicked);
            // 
            // nbiProject
            // 
            this.nbiProject.Caption = "Proje Tanımları";
            this.nbiProject.Name = "nbiProject";
            this.nbiProject.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiProject_LinkClicked);
            // 
            // nbiProjectStart
            // 
            this.nbiProjectStart.Caption = "Proje Atamaları";
            this.nbiProjectStart.Name = "nbiProjectStart";
            this.nbiProjectStart.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiProjectStart_LinkClicked);
            // 
            // nbiMyStockDemand
            // 
            this.nbiMyStockDemand.Caption = "Malzeme Talep İşlemleri";
            this.nbiMyStockDemand.Name = "nbiMyStockDemand";
            this.nbiMyStockDemand.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMyStockDemand_LinkClicked);
            // 
            // nbiMyProject
            // 
            this.nbiMyProject.Caption = "Günlük Montaj Bilgisi";
            this.nbiMyProject.Name = "nbiMyProject";
            this.nbiMyProject.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMyProject_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Malzeme Talep Onay";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPMConfirmation_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Hakediş";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPayoff)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiPayoff
            // 
            this.nbiPayoff.Caption = "Hakediş Hazırlama";
            this.nbiPayoff.Name = "nbiPayoff";
            this.nbiPayoff.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPayoff_LinkClicked);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSkin,
            this.barUsername,
            this.barDate});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSkin),
            new DevExpress.XtraBars.LinkPersistInfo(this.barUsername),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDate)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barSkin
            // 
            this.barSkin.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barSkin.Caption = "Tema";
            this.barSkin.Id = 0;
            this.barSkin.Name = "barSkin";
            // 
            // barUsername
            // 
            this.barUsername.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barUsername.Caption = "UserName";
            this.barUsername.Id = 1;
            this.barUsername.Name = "barUsername";
            // 
            // barDate
            // 
            this.barDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barDate.Caption = "Date";
            this.barDate.Id = 2;
            this.barDate.Name = "barDate";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1184, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1184, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1184, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 536);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchControl);
            this.layoutControl1.Controls.Add(this.navBarControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(158, 514);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchControl
            // 
            this.searchControl.Location = new System.Drawing.Point(22, 2);
            this.searchControl.MenuManager = this.barManager1;
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Size = new System.Drawing.Size(134, 20);
            this.searchControl.StyleController = this.layoutControl1;
            this.searchControl.TabIndex = 5;
            this.searchControl.TextChanged += new System.EventHandler(this.searchControl_TextChanged);
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.nbgStock;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgStock,
            this.nbgDefinition,
            this.nbgProject,
            this.navBarGroup1});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiStockTransaction,
            this.nbiStockReportCompany,
            this.nbiStockDemand,
            this.nbiStatic,
            this.nbiUser,
            this.nbiItem,
            this.nbiCompany,
            this.nbiContract,
            this.nbiProject,
            this.nbiProjectStart,
            this.nbiMyProject,
            this.nbiMyStockDemand,
            this.nbiMenuRole,
            this.nbiUserRole,
            this.nbiPayoff,
            this.nbiPYPActionControl,
            this.navBarItem1,
            this.stckreport2});
            this.navBarControl.Location = new System.Drawing.Point(2, 26);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 154;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(154, 486);
            this.navBarControl.TabIndex = 4;
            this.navBarControl.Text = "nAVBA";
            this.navBarControl.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.Ara});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(158, 514);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(158, 490);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Ara
            // 
            this.Ara.Control = this.searchControl;
            this.Ara.Enabled = false;
            this.Ara.Location = new System.Drawing.Point(0, 0);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(158, 24);
            this.Ara.TextSize = new System.Drawing.Size(17, 13);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(162, 536);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "OSKAR NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraNavBar.NavBarGroup nbgStock;
        private DevExpress.XtraNavBar.NavBarItem nbiStockTransaction;
        private DevExpress.XtraNavBar.NavBarItem nbiStockReportCompany;
        private DevExpress.XtraNavBar.NavBarItem nbiStockDemand;
        private DevExpress.XtraNavBar.NavBarGroup nbgDefinition;
        private DevExpress.XtraNavBar.NavBarItem nbiStatic;
        private DevExpress.XtraNavBar.NavBarItem nbiUser;
        private DevExpress.XtraNavBar.NavBarItem nbiItem;
        private DevExpress.XtraNavBar.NavBarItem nbiCompany;
        private DevExpress.XtraNavBar.NavBarGroup nbgProject;
        private DevExpress.XtraNavBar.NavBarItem nbiContract;
        private DevExpress.XtraNavBar.NavBarItem nbiProject;
        private DevExpress.XtraNavBar.NavBarItem nbiProjectStart;
        private DevExpress.XtraNavBar.NavBarItem nbiMyProject;
        private DevExpress.XtraNavBar.NavBarItem nbiMyStockDemand;
        private DevExpress.XtraNavBar.NavBarItem nbiMenuRole;
        private DevExpress.XtraNavBar.NavBarItem nbiUserRole;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiPayoff;
        private DevExpress.XtraNavBar.NavBarItem nbiPYPActionControl;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.SkinBarSubItem barSkin;
        private DevExpress.XtraBars.BarStaticItem barUsername;
        private DevExpress.XtraBars.BarStaticItem barDate;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraNavBar.NavBarItem stckreport2;
        private DevExpress.XtraEditors.SearchControl searchControl;
        private DevExpress.XtraLayout.LayoutControlItem Ara;
    }
}

