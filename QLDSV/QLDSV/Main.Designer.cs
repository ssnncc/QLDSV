namespace QLDSV
{
    partial class Main
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
        public void enableButton()
        {
            barButtonMH.Enabled = true;
            barButtonLH.Enabled = true;
            barButtonSV.Enabled = true;
            barButtonDiem.Enabled = true;
            barButtonHP.Enabled = true;
            barButtonDSSV.Enabled = true;
            barButtonDSTHM.Enabled = true;
            barButtonBDMH.Enabled = true;
            barButtonPD.Enabled = true;
            barButtonDSDHP.Enabled = true;
            barButtonBDTK.Enabled = true;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaologin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCL = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSTHM = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBDMH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSDHP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHP = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDSTHM = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Khoa = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.barButtonLogin,
            this.barButtonLogout,
            this.barBtnTaologin,
            this.barButtonItem1,
            this.barButtonMH,
            this.barButtonLH,
            this.barButtonSV,
            this.barButtonDiem,
            this.barButtonCL,
            this.barButtonDSSV,
            this.barButtonDSTHM,
            this.barButtonBDMH,
            this.barButtonPD,
            this.barButtonDSDHP,
            this.barButtonBDTK,
            this.barButtonHP});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl2.MaxItemId = 26;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl2.Size = new System.Drawing.Size(1075, 225);
            // 
            // barButtonLogin
            // 
            this.barButtonLogin.Caption = "ĐĂNG NHẬP";
            this.barButtonLogin.Id = 1;
            this.barButtonLogin.ImageOptions.Image = global::QLDSV.Properties.Resources.login_icon;
            this.barButtonLogin.Name = "barButtonLogin";
            this.barButtonLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogin_ItemClick);
            // 
            // barButtonLogout
            // 
            this.barButtonLogout.Caption = "ĐĂNG XUẤT";
            this.barButtonLogout.Id = 2;
            this.barButtonLogout.ImageOptions.Image = global::QLDSV.Properties.Resources.logout_icon;
            this.barButtonLogout.Name = "barButtonLogout";
            this.barButtonLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogout_ItemClick);
            // 
            // barBtnTaologin
            // 
            this.barBtnTaologin.Caption = "TẠO TÀI KHOẢN";
            this.barBtnTaologin.Id = 3;
            this.barBtnTaologin.ImageOptions.Image = global::QLDSV.Properties.Resources.add_16x16;
            this.barBtnTaologin.ImageOptions.LargeImage = global::QLDSV.Properties.Resources.add_32x32;
            this.barBtnTaologin.Name = "barBtnTaologin";
            this.barBtnTaologin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaologin_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonMH
            // 
            this.barButtonMH.Caption = "MÔN HỌC";
            this.barButtonMH.Id = 5;
            this.barButtonMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonMH.ImageOptions.Image")));
            this.barButtonMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonMH.ImageOptions.LargeImage")));
            this.barButtonMH.Name = "barButtonMH";
            this.barButtonMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMH_ItemClick);
            // 
            // barButtonLH
            // 
            this.barButtonLH.Caption = "LỚP HỌC";
            this.barButtonLH.Id = 6;
            this.barButtonLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonLH.ImageOptions.Image")));
            this.barButtonLH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonLH.ImageOptions.LargeImage")));
            this.barButtonLH.Name = "barButtonLH";
            this.barButtonLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLH_ItemClick);
            // 
            // barButtonSV
            // 
            this.barButtonSV.Caption = "SINH VIÊN";
            this.barButtonSV.Id = 7;
            this.barButtonSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSV.ImageOptions.Image")));
            this.barButtonSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSV.ImageOptions.LargeImage")));
            this.barButtonSV.Name = "barButtonSV";
            this.barButtonSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSV_ItemClick);
            // 
            // barButtonDiem
            // 
            this.barButtonDiem.Caption = "ĐIỂM";
            this.barButtonDiem.Id = 8;
            this.barButtonDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDiem.ImageOptions.Image")));
            this.barButtonDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDiem.ImageOptions.LargeImage")));
            this.barButtonDiem.Name = "barButtonDiem";
            this.barButtonDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDiem_ItemClick);
            // 
            // barButtonCL
            // 
            this.barButtonCL.Caption = "CHUYỂN LỚP";
            this.barButtonCL.Id = 9;
            this.barButtonCL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonCL.ImageOptions.Image")));
            this.barButtonCL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonCL.ImageOptions.LargeImage")));
            this.barButtonCL.Name = "barButtonCL";
            // 
            // barButtonDSSV
            // 
            this.barButtonDSSV.Caption = "DS SINH VIÊN";
            this.barButtonDSSV.Id = 19;
            this.barButtonDSSV.ImageOptions.Image = global::QLDSV.Properties.Resources.table_32;
            this.barButtonDSSV.Name = "barButtonDSSV";
            this.barButtonDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSSV_ItemClick);
            // 
            // barButtonDSTHM
            // 
            this.barButtonDSTHM.Caption = "DS THI HẾT MÔN";
            this.barButtonDSTHM.Id = 20;
            this.barButtonDSTHM.ImageOptions.Image = global::QLDSV.Properties.Resources.table_32;
            this.barButtonDSTHM.Name = "barButtonDSTHM";
            this.barButtonDSTHM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSTHM_ItemClick);
            // 
            // barButtonBDMH
            // 
            this.barButtonBDMH.Caption = "BẢNG ĐIỂM MÔN HỌC";
            this.barButtonBDMH.Id = 21;
            this.barButtonBDMH.ImageOptions.Image = global::QLDSV.Properties.Resources.table_32;
            this.barButtonBDMH.Name = "barButtonBDMH";
            this.barButtonBDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBDMH_ItemClick);
            // 
            // barButtonPD
            // 
            this.barButtonPD.Caption = "PHIẾU ĐIỂM";
            this.barButtonPD.Id = 22;
            this.barButtonPD.ImageOptions.Image = global::QLDSV.Properties.Resources.table_32;
            this.barButtonPD.Name = "barButtonPD";
            this.barButtonPD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPD_ItemClick);
            // 
            // barButtonDSDHP
            // 
            this.barButtonDSDHP.Caption = "DANH SÁCH ĐÓNG HỌC PHÍ";
            this.barButtonDSDHP.Id = 23;
            this.barButtonDSDHP.ImageOptions.Image = global::QLDSV.Properties.Resources.table_32;
            this.barButtonDSDHP.Name = "barButtonDSDHP";
            this.barButtonDSDHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSDHP_ItemClick);
            // 
            // barButtonBDTK
            // 
            this.barButtonBDTK.Caption = "BẢNG ĐIỂM TỔNG KẾT";
            this.barButtonBDTK.Id = 24;
            this.barButtonBDTK.ImageOptions.Image = global::QLDSV.Properties.Resources.table_32;
            this.barButtonBDTK.Name = "barButtonBDTK";
            this.barButtonBDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBDTK_ItemClick);
            // 
            // barButtonHP
            // 
            this.barButtonHP.Caption = "HỌC PHÍ";
            this.barButtonHP.Id = 25;
            this.barButtonHP.ImageOptions.Image = global::QLDSV.Properties.Resources.financial_16x16;
            this.barButtonHP.ImageOptions.LargeImage = global::QLDSV.Properties.Resources.financial_32x32;
            this.barButtonHP.Name = "barButtonHP";
            this.barButtonHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHP_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.ImageOptions.Image = global::QLDSV.Properties.Resources.Teacher_male_icon_48;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản trị";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonLogin);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonLogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnTaologin);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup1});
            this.ribbonPage3.ImageOptions.Image = global::QLDSV.Properties.Resources.Keyboard_48_icon;
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Nhập liệu";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonMH);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonLH);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonSV);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonDiem);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonHP);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonDSTHM,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13,
            this.ribbonPageGroup14});
            this.ribbonPage4.ImageOptions.Image = global::QLDSV.Properties.Resources.Excel_48_icon;
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonDSSV);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonDSTHM
            // 
            this.ribbonDSTHM.ItemLinks.Add(this.barButtonDSTHM);
            this.ribbonDSTHM.Name = "ribbonDSTHM";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.barButtonBDMH);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.barButtonPD);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.barButtonDSDHP);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.barButtonBDTK);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaGV,
            this.HoTen,
            this.Khoa});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1075, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaGV
            // 
            this.MaGV.Name = "MaGV";
            this.MaGV.Size = new System.Drawing.Size(53, 20);
            this.MaGV.Text = "Mã GV";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(75, 20);
            this.HoTen.Text = "Họ và Tên";
            // 
            // Khoa
            // 
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(43, 20);
            this.Khoa.Text = "Khoa";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl2;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        public DevExpress.XtraBars.BarButtonItem barButtonLogin;
        public DevExpress.XtraBars.BarButtonItem barButtonLogout;
        public DevExpress.XtraBars.BarButtonItem barBtnTaologin;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem barButtonMH;
        public DevExpress.XtraBars.BarButtonItem barButtonLH;
        public DevExpress.XtraBars.BarButtonItem barButtonSV;
        public DevExpress.XtraBars.BarButtonItem barButtonDiem;
        public DevExpress.XtraBars.BarButtonItem barButtonCL;
        public DevExpress.XtraBars.BarButtonItem barButtonHP;
        public DevExpress.XtraBars.BarButtonItem barButtonDSSV;
        public DevExpress.XtraBars.BarButtonItem barButtonDSTHM;
        public DevExpress.XtraBars.BarButtonItem barButtonBDMH;
        public DevExpress.XtraBars.BarButtonItem barButtonPD;
        public DevExpress.XtraBars.BarButtonItem barButtonDSDHP;
        public DevExpress.XtraBars.BarButtonItem barButtonBDTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonDSTHM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MaGV;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel Khoa;
    }
}

