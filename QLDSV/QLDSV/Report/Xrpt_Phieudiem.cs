using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xrpt_Phieudiem : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_Phieudiem(String masv)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.pHIEUDIEM_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUDIEM_ReportTableAdapter.Fill(ds1.PHIEUDIEM_Report, masv);


        }

    }
}
