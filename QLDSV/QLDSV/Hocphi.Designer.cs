namespace QLDSV
{
    partial class Hocphi
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label2 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSP_HP = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_HocphiTableAdapter = new QLDSV.DSTableAdapters.SP_HocphiTableAdapter();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBD,
            this.btnGhi,
            this.btnRefresh,
            this.btnThoat,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "THÊM";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnBD
            // 
            this.btnBD.Caption = "BẮT ĐẦU";
            this.btnBD.Id = 0;
            this.btnBD.ImageOptions.Image = global::QLDSV.Properties.Resources.icons8_Circled_Play_24px_3;
            this.btnBD.Name = "btnBD";
            this.btnBD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBD_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = global::QLDSV.Properties.Resources.Save_icon_24;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = global::QLDSV.Properties.Resources.Exit_24_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1093, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 538);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1093, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1093, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "REFRESH";
            this.btnRefresh.Id = 2;
            this.btnRefresh.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(this.cmbTenLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 231);
            this.panel1.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(590, 128);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(289, 35);
            this.txtHoTen.TabIndex = 34;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(114, 132);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(432, 30);
            this.txtMaSV.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã SV:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(590, 63);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(289, 32);
            this.txtMaLop.TabIndex = 31;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "MALOP", true));
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(114, 64);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(432, 31);
            this.cmbTenLop.TabIndex = 30;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged_1);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên lớp:";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.DataSource = this.bdsSP_HP;
            this.hOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hOCPHIGridControl.Location = new System.Drawing.Point(0, 271);
            this.hOCPHIGridControl.MainView = this.gridView1;
            this.hOCPHIGridControl.MenuManager = this.barManager1;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(1093, 267);
            this.hOCPHIGridControl.TabIndex = 10;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsSP_HP
            // 
            this.bdsSP_HP.DataMember = "SP_Hocphi";
            this.bdsSP_HP.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.hOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.MinWidth = 25;
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 94;
            // 
            // sP_HocphiTableAdapter
            // 
            this.sP_HocphiTableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 4;
            this.btnThem.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon1;
            this.btnThem.Name = "btnThem";
            // 
            // Hocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 558);
            this.Controls.Add(this.hOCPHIGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Hocphi";
            this.Text = "Hocphi";
            this.Load += new System.EventHandler(this.Hocphi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBD;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.BindingSource bdsSP_HP;
        private DSTableAdapters.SP_HocphiTableAdapter sP_HocphiTableAdapter;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
    }
}