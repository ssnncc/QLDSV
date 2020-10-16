namespace QLDSV.Report
{
    partial class Xrpt_BangDiemTongKet
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblLOP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.sp_BANGDIEMTONGKET_ReportTableAdapter = new QLDSV.DSTableAdapters.sp_BANGDIEMTONGKET_ReportTableAdapter();
            this.ds1 = new QLDSV.DS();
            this.fieldHOTEN1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldTENMH1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDIEM1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.tableAdapterManager1 = new QLDSV.ds_PMTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblLOP,
            this.xrLabel1,
            this.xrLabel2});
            this.TopMargin.HeightF = 124F;
            this.TopMargin.Name = "TopMargin";
            // 
            // lblLOP
            // 
            this.lblLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOP.ForeColor = System.Drawing.Color.Blue;
            this.lblLOP.LocationFloat = new DevExpress.Utils.PointFloat(154.5833F, 68.49998F);
            this.lblLOP.Multiline = true;
            this.lblLOP.Name = "lblLOP";
            this.lblLOP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLOP.SizeF = new System.Drawing.SizeF(444.7917F, 23F);
            this.lblLOP.StylePriority.UseFont = false;
            this.lblLOP.StylePriority.UseForeColor = false;
            this.lblLOP.Text = "lblLOP";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Red;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(198.3333F, 23.33333F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(236.4583F, 33.00001F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BẢNG ĐIỂM TỔNG KẾT ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.Red;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(94.16664F, 68.49998F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(47.91666F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "Lớp : ";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(542.2917F, 10F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(97.70831F, 23F);
            this.xrPageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(146.6666F, 23F);
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.Name = "Detail";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.Lines.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.DataAdapter = this.sp_BANGDIEMTONGKET_ReportTableAdapter;
            this.xrPivotGrid1.DataMember = "sp_BANGDIEMTONGKET_Report";
            this.xrPivotGrid1.DataSource = this.ds1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldHOTEN1,
            this.fieldTENMH1,
            this.fieldDIEM1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OLAPConnectionString = "";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsView.RowTreeWidth = 30;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowColumnHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowDataHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(312.0833F, 57.29166F);
            // 
            // sp_BANGDIEMTONGKET_ReportTableAdapter
            // 
            this.sp_BANGDIEMTONGKET_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.EnforceConstraints = false;
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldHOTEN1
            // 
            this.fieldHOTEN1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldHOTEN1.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldHOTEN1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHOTEN1.AreaIndex = 0;
            this.fieldHOTEN1.Caption = "Mã sinh viên - Họ tên";
            this.fieldHOTEN1.FieldName = "HOTEN";
            this.fieldHOTEN1.Name = "fieldHOTEN1";
            this.fieldHOTEN1.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.fieldHOTEN1.Options.AllowSortBySummary = DevExpress.Utils.DefaultBoolean.False;
            this.fieldHOTEN1.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.fieldHOTEN1.Width = 200;
            // 
            // fieldTENMH1
            // 
            this.fieldTENMH1.Appearance.CustomTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldTENMH1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldTENMH1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTENMH1.AreaIndex = 0;
            this.fieldTENMH1.Caption = "Tên môn học";
            this.fieldTENMH1.FieldName = "TENMH";
            this.fieldTENMH1.Name = "fieldTENMH1";
            this.fieldTENMH1.Width = 200;
            // 
            // fieldDIEM1
            // 
            this.fieldDIEM1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldDIEM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDIEM1.AreaIndex = 0;
            this.fieldDIEM1.Caption = "Điểm ";
            this.fieldDIEM1.FieldName = "DIEM";
            this.fieldDIEM1.Name = "fieldDIEM1";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.ds_PMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Xrpt_BangDiemTongKet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ds1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 124, 100);
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        public DevExpress.XtraReports.UI.XRLabel lblLOP;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        public DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DS ds1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHOTEN1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldTENMH1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDIEM1;
        private ds_PMTableAdapters.TableAdapterManager tableAdapterManager1;
        private DSTableAdapters.sp_BANGDIEMTONGKET_ReportTableAdapter sp_BANGDIEMTONGKET_ReportTableAdapter;
    }
}
