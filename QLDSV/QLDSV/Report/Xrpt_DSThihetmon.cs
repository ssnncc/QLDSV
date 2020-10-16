using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xrpt_DSThihetmon : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSThihetmon( String Malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.dSThihetmon_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSThihetmon_ReportTableAdapter.Fill(ds1.DSThihetmon_Report, Malop);
        }

    }
}
