using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xrpt_BangdiemMH : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangdiemMH(String malop, String mamonhoc, int lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.bangdiemMH_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bangdiemMH_ReportTableAdapter.Fill(ds1.BangdiemMH_Report, malop, mamonhoc, lan);
        }

    }
}
