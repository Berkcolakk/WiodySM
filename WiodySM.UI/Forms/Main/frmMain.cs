using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using WiodySM.Data.Model.Context;
using WiodySM.Data.Utilities;
using WiodySM.UI.Forms.Definition;
using WiodySM.UI.Forms.ProjectManagement;
using WiodySM.UI.Forms.StockAction;
using WiodySM.UI.Utilities;

namespace WiodySM.UI
{
    public partial class frmMain : BaseForm
    {
        private NavBarFilter _flt;
        private NavBarFilter GetFilter()
        {
            if (_flt == null)
                _flt = new NavBarFilter(navBarControl);
            return _flt;
        }
        
        public frmMain()
        {
            InitializeComponent();
            if (SystemActive.UserId != 1)
            {
                InitMenu();
            }
            barUsername.Caption = SystemActive.NameSurname;
            barDate.Caption = DateTime.Now.ToShortDateString();
        }
        void InitMenu()
        {
            //work
            var role = dbContext.UserRole.FirstOrDefault(x => x.USERROLE_USER_ID == SystemActive.UserId);
            var accessMenuList = dbContext.MenuRole.Where(x => x.MENUROLE_ROLE_ID == role.USERROLE_ROLE_ID).ToList();
            for (int i = 0; i < navBarControl.Items.Count; i++)
            {
                var menu = accessMenuList.FirstOrDefault(x => x.ParameterDetail_MenuRole_Menu.PARAMETERDETAIL_NAME == navBarControl.Items[i].Caption);
                if (menu == null)
                {
                    navBarControl.Items[i].Visible = false;
                }
            }

            for (int i = 0; i < navBarControl.Groups.Count; i++)
            {
                var menu = accessMenuList.FirstOrDefault(x => x.ParameterDetail_MenuRole_Menu.PARAMETERDETAIL_VALUE1 == navBarControl.Groups[i].Caption);
                if (menu == null)
                {
                    navBarControl.Groups[i].Visible = false;
                }
            }
        }
        private void searchControl_TextChanged(object sender, EventArgs e)
        {
            NavBarFilter flt = GetFilter();
            flt.FilterNavBar(searchControl.Text);
        }

        private void nbiCompany_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            def0001 frm = new def0001();
            FormIsOpen(frm);

        }

        private void nbiStockTransaction_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stck0001 frm = new stck0001();
            FormIsOpen(frm);

        }

        private void nbiProject_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0001 frm = new prj0001();
            FormIsOpen(frm);

        }

        private void nbiProjectConfirm_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0004 frm = new prj0004();
            FormIsOpen(frm);

        }

        private void nbiProjectStart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0005 frm = new prj0005();
            FormIsOpen(frm);

        }

        private void nbiUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            def0003 frm = new def0003();
            FormIsOpen(frm);

        }

        private void nbiMyProject_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0008 frm = new prj0008();
            FormIsOpen(frm);

        }

        private void nbiMyStockDemand_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0006 frm = new prj0006();
            FormIsOpen(frm);

        }

        private void nbiItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            def0005 frm = new def0005();
            FormIsOpen(frm);

        }

        private void nbiContract_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            def0007 frm = new def0007();
            FormIsOpen(frm);

        }

        private void nbiMenuRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            def0009 frm = new def0009();
            FormIsOpen(frm);

        }

        private void nbiUserRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            def0011 frm = new def0011();
            FormIsOpen(frm);

        }

        private void nbiStockDemand_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0009 frm = new prj0009();
            FormIsOpen(frm);

        }

        private void nbiStockReportCompany_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            rprt0001 frm = new rprt0001();
            FormIsOpen(frm);

        }

        private void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Program kapatılacak emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }

        }

        private void nbiPayoff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pyf0001 frm = new pyf0001();
            FormIsOpen(frm);

        }

        private void nbiPYPActionControl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            rprt0002 frm = new rprt0002();
            FormIsOpen(frm);
        }
        private void FormIsOpen(Form frm)
        {
            bool isOpen = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (frm.Name == MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    isOpen = true;
                }
            }
            if (isOpen == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Dispose();
            }
        }

        private void nbiPMConfirmation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            prj0014 frm = new prj0014();
            FormIsOpen(frm);
        }

        private void stckreport2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            rprt0003 frm = new rprt0003();
            FormIsOpen(frm);

        }
    }
}
