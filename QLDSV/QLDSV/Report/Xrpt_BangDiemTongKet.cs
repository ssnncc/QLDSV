using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xrpt_BangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemTongKet(String malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_BANGDIEMTONGKET_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_BANGDIEMTONGKET_ReportTableAdapter.Fill(ds1.sp_BANGDIEMTONGKET_Report, malop);
        }

    }
}
