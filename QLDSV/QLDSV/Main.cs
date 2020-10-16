using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void unEnableButton()
        {
            barButtonMH.Enabled = false;
            barButtonLH.Enabled = false;
            barButtonSV.Enabled = false;
            barButtonDiem.Enabled = false;
            barButtonHP.Enabled = false;
            barButtonCL.Enabled = false;
            barButtonDSSV.Enabled = false;
            barButtonDSTHM.Enabled = false;
            barButtonBDMH.Enabled = false;
            barButtonPD.Enabled = false;
            barButtonDSDHP.Enabled = false;
            barButtonBDTK.Enabled = false;
        }
        Boolean Dangxuat = false;
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Dangxuat)
            {
                if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Program.formDN.Visible = true;
                    Program.formDN.Close();
                }
                else e.Cancel = true;
            }
        }
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDN));
            if (frm != null) frm.Activate();
            else
            {
                FormDN f = new FormDN();
                //f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dangxuat = true;
            Program.frmChinh.Close();
            Program.formDN.Visible = true;
        }

        private void barBtnTaologin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Dangky));
        }

        private void barButtonMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Monhoc));
        }

        private void barButtonLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Lophoc));
        }

        private void barButtonSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Sinhvien));
        }

        private void barButtonDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.DSSV));
        }

        private void barButtonDSTHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.DSThihetmon));
        }

        private void barButtonBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.BangdiemMH));
        }

        private void barButtonPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Phieudiem));
        }

        private void barButtonDSDHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.DSDonghocphi));
        }

        private void barButtonBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.BangdiemTK));
        }

        private void barButtonHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Hocphi));
        }

        private void barButtonDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Diem));
        }
    }
}
